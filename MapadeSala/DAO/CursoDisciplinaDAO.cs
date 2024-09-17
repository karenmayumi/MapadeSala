using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entidades;

namespace MapaSala.DAO
{
    public class CursoDisciplinaDAO
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private SqlConnection Conexao;
        public CursoDisciplinaDAO()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }

        public void Inserir(CursoDisciplinaEntidade objeto)
        {
            Conexao.Open();
            string query = "Insert into Curso_Disciplina (Curso_Id , Disciplina_Id, Periodo) Values (@Curso_Id, @Disciplina_Id, @Periodo) ";
            SqlCommand comando = new SqlCommand(query, Conexao);

            SqlParameter parametro1 = new SqlParameter("@Curso_Id", objeto.CursoId);
            SqlParameter parametro2 = new SqlParameter("@Disciplina_Id", objeto.DisciplinaId);
            SqlParameter parametro3 = new SqlParameter("@Periodo", objeto.Periodo);

            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.Parameters.Add(parametro3);
            comando.ExecuteNonQuery();
            Conexao.Close();

        }
        public DataTable ObterCursoDisciplina()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            //string query = "SELECT c.Nome, d.Nome  FROM curso as c INNER JOIN disciplina as d in id.d = id.c  Order by c.Id desc";
            string query = @"SELECT C.NOME, CD.Periodo, D.Nome FROM Curso_Disciplina as CD 
                            INNER JOIN CURSOS as C ON C.Id = CD.Curso_id
                            INNER JOIN DISCIPLINAS as D ON D.Id = CD.Disciplina_id
                            Order by c.Id desc; ";
            SqlCommand comando = new SqlCommand(query, Conexao);
            SqlDataReader Leitura = comando.ExecuteReader();

            dt.Columns.Add("Nome Curso");
            dt.Columns.Add("Período");
            dt.Columns.Add("Nome Disciplina");

            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    CursoDisciplinaEntidade p = new CursoDisciplinaEntidade();
                    p.NomeCurso = Leitura[0].ToString();
                    p.NomeDisciplina = Leitura[1].ToString();
                    p.Periodo = Leitura[2].ToString();
                    dt.Rows.Add(p.Linha());
                }
            }
            Conexao.Close();
            return dt;
        }
        public DataTable PesquisarCursoDisciplina(string search) //problema
        {
            DataTable retorno = new DataTable();
            Conexao.Open();
            string query = "";
            if (string.IsNullOrEmpty(search))
            {
                query = @"SELECT D.Nome, C.NOME, CD.Periodo FROM Curso_Disciplina as CD 
                            INNER JOIN CURSOS as C ON C.Id = CD.Curso_id
                            INNER JOIN DISCIPLINAS as D ON D.Id = CD.Disciplina_id
                            ORDER BY C.NOME DESC";
            }
            else
            {
                query = @"SELECT D.Nome, C.NOME, CD.Periodo FROM Curso_Disciplina as CD 
                            INNER JOIN CURSOS as C ON C.Id = CD.Curso_id
                            INNER JOIN DISCIPLINAS as D ON D.Id = CD.Disciplina_id
                            WHERE C.NOME LIKE '%" + search + "%' OR D.NOME LIKE '%" + search + "%' ORDER BY C.NOME DESC";

                //query = "SELECT * FROM CURSO_DISCIPLINA WHERE C.NOME LIKE '%" + search + "%' OR D.NOME LIKE '%" + search + "%' ORDER BY ID DESC";
            }
            SqlCommand Comando = new SqlCommand(query, Conexao);

            SqlDataReader Leitura = Comando.ExecuteReader();

            retorno.Columns.Add("Nome Curso");
            retorno.Columns.Add("Nome Disciplina");
            retorno.Columns.Add("Período");

            if (Leitura.HasRows) //terminar aqui
            {
                while (Leitura.Read())
                {
                    CursoDisciplinaEntidade cd = new CursoDisciplinaEntidade();
                    cd.NomeDisciplina = Leitura[0].ToString();
                    cd.NomeCurso = Leitura[1].ToString();
                    cd.Periodo = Leitura[2].ToString();
                    retorno.Rows.Add(cd.Linha());
                }
            }
            Conexao.Close();
            return retorno;
        }
    }
}