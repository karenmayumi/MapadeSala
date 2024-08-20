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
    public class ProfessorDAO
    {
        private string LinhaConexao = "Server=LS05MPF;Database=Aula_DS;User Id=SA;Password=admsasql;"; //LS05M020
        private SqlConnection Conexao;
        public ProfessorDAO()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }
        public void Inserir(ProfessoresEntidade professor)
        {
            Conexao.Open();
            string Query = "INSERT into Professores (Nome, Apelido) VALUES (@nome,@apelido); ";
            SqlCommand Comando = new SqlCommand(Query, Conexao);
            SqlParameter par1 = new SqlParameter("@nome", professor.Nome);
            SqlParameter par2 = new SqlParameter("@apelido", professor.Apelido);

            Comando.Parameters.Add(par1);
            Comando.Parameters.Add(par2);
            Comando.ExecuteNonQuery();
            Conexao.Close();
        }
        public DataTable ObterProfessores()
        {
            DataTable retorno = new DataTable();
            Conexao.Open();
            string query = "SELECT ID, NOME, APELIDO FROM PROFESSORES ORDER BY ID DESC";
            SqlCommand Comando = new SqlCommand(query,Conexao);

            SqlDataReader Leitura = Comando.ExecuteReader();

            foreach ( var atributos in typeof(ProfessoresEntidade).GetProperties())
            {
                retorno.Columns.Add(atributos.Name);
            }

            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    ProfessoresEntidade p = new ProfessoresEntidade();
                    p.Id = Convert.ToInt32(Leitura[0]);
                    p.Nome = Leitura[1].ToString();
                    p.Apelido = Leitura[2].ToString();
                    retorno.Rows.Add(p.Linha());
                }
            }
            Conexao.Close();
            return retorno;
        }
        public void ExcluirProfessor(int indexProfessor)
        {
            Conexao.Open();
            string Query = "DELETE FROM Professores WHERE id = @id; ";
            SqlCommand Comando = new SqlCommand(Query, Conexao);
            SqlParameter par1 = new SqlParameter("@id", indexProfessor);

            Comando.Parameters.Add(par1);
            Comando.ExecuteNonQuery();
            Conexao.Close();
        }
        public DataTable PesquisarProfessor(string search)
        {
            DataTable retorno = new DataTable();
            Conexao.Open();
            string query = "";
            if (string.IsNullOrEmpty(search))
            {
                query = "SELECT ID, NOME, APELIDO FROM PROFESSORES ORDER BY ID DESC";
            }
            else
            {
                query = "SELECT ID, NOME, APELIDO FROM PROFESSORES WHERE NOME LIKE '%"+search+ "%' OR APELIDO LIKE '%" + search + "%' ORDER BY ID DESC";
            }
            SqlCommand Comando = new SqlCommand(query, Conexao);

            SqlDataReader Leitura = Comando.ExecuteReader();

            foreach (var atributos in typeof(ProfessoresEntidade).GetProperties())
            {
                retorno.Columns.Add(atributos.Name);
            }

            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    ProfessoresEntidade p = new ProfessoresEntidade();
                    p.Id = Convert.ToInt32(Leitura[0]);
                    p.Nome = Leitura[1].ToString();
                    p.Apelido = Leitura[2].ToString();
                    retorno.Rows.Add(p.Linha());
                }
            }
            Conexao.Close();
            return retorno;
        }
    }
}
