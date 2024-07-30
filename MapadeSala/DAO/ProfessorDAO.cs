using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using Model.Entidades;

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
            string Query = "INSERT into Professores VALUES (NULL, 'Fernando','Fernandeco'); ";

        }
    }
}
