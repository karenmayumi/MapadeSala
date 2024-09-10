using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using Model.Entidades;
using System.Data;

namespace MapadeSala.DAO
{
    public class CursoDAO
    {
        private string LinhaConexao = "Server=LS05MPF;Database=Aula_DS;User Id=SA;Password=admsasql;"; //LS05M020
        private SqlConnection Conexao;
        public CursoDAO()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }
        public void Inserir(CursosEntidade curso)
        {
            Conexao.Open();
            string Query = "INSERT into Cursos (Nome, Turno, Sigla, Ativo) VALUES (@nome,@turno,@sigla,@ativo); ";
            SqlCommand Comando = new SqlCommand(Query, Conexao);
            SqlParameter par1 = new SqlParameter("@nome", curso.Nome);
            SqlParameter par2 = new SqlParameter("@turno", curso.Turno);
            SqlParameter par3 = new SqlParameter("@sigla", curso.Sigla);
            SqlParameter par4 = new SqlParameter("@ativo", curso.Ativo);

            Comando.Parameters.Add(par1);
            Comando.Parameters.Add(par2);
            Comando.Parameters.Add(par3);
            Comando.Parameters.Add(par4);
            Comando.ExecuteNonQuery();
            Conexao.Close();
        }
        public DataTable PreencherComboBox()
        {
            DataTable dataTable = new DataTable();

            string query = "SELECT Id, Nome FROM Cursos";

            using (SqlConnection connection = new SqlConnection(LinhaConexao))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                try
                {
                    // Preenche o DataTable com os dados da consulta
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    // Lida com erros, se necessário
                    throw new Exception("Erro ao acessar os dados: " + ex.Message);
                }
            }

            return dataTable;
        }

        public DataTable ObterCursos()
        {
            DataTable retorno = new DataTable();
            Conexao.Open();
            string query = "SELECT ID, NOME, TURNO, SIGLA, ATIVO FROM CURSOS ORDER BY ID DESC";
            SqlCommand Comando = new SqlCommand(query, Conexao);

            SqlDataReader Leitura = Comando.ExecuteReader();

            foreach (var atributos in typeof(CursosEntidade).GetProperties())
            {
                retorno.Columns.Add(atributos.Name);
            }

            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    CursosEntidade c = new CursosEntidade();
                    c.Id = Convert.ToInt32(Leitura[0]);
                    c.Nome = Leitura[1].ToString();
                    c.Turno = Leitura[2].ToString();
                    c.Sigla = Leitura[3].ToString();
                    c.Ativo = Convert.ToBoolean( Leitura[4] );
                    retorno.Rows.Add(c.Linha());
                }
            }

            return retorno;
        }
        public void ExcluirCurso(int indexCurso)
        {
            Conexao.Open();
            string Query = "DELETE FROM Cursos WHERE id = @id; ";
            SqlCommand Comando = new SqlCommand(Query, Conexao);
            SqlParameter par1 = new SqlParameter("@id", indexCurso);

            Comando.Parameters.Add(par1);
            Comando.ExecuteNonQuery();
            Conexao.Close();
        }
        public DataTable PesquisarCurso(string search)
        {
            DataTable retorno = new DataTable();
            Conexao.Open();
            string query = "";
            if (string.IsNullOrEmpty(search))
            {
                query = "SELECT * FROM CURSO ORDER BY ID DESC";
            }
            else
            {
                query = "SELECT * FROM CURSOS WHERE NOME LIKE '%" + search + "%' OR SIGLA LIKE '%" + search + "%' ORDER BY ID DESC";
            }
            SqlCommand Comando = new SqlCommand(query, Conexao);

            SqlDataReader Leitura = Comando.ExecuteReader();

            foreach (var atributos in typeof(CursosEntidade).GetProperties())
            {
                retorno.Columns.Add(atributos.Name);
            }

            if (Leitura.HasRows) //terminar aqui
            {
                while (Leitura.Read())
                {
                    DisciplinaEntidade p = new DisciplinaEntidade();
                    p.Id = Convert.ToInt32(Leitura[0]);
                    p.Nome = Leitura[1].ToString();
                    p.Sigla = Leitura[2].ToString();
                    p.Ativo = Convert.ToBoolean(Leitura[3].ToString());
                    retorno.Rows.Add(p.Linha());
                }
            }
            Conexao.Close();
            return retorno;
        }
    }
}
