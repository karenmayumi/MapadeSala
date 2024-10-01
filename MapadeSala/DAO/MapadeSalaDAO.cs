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
    public class MapadeSalaDAO
    {
        private string LinhaConexao = "Server=LS05MPF;Database=Aula_DS;User Id=SA;Password=admsasql;"; //LS05M020
        private SqlConnection Conexao;
        public MapadeSalaDAO()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }
        public void Inserir(MapadeSalaEntidade mapadeSala)
        {
            Conexao.Open();
            string Query = "INSERT into MapadeSala (Id, Sala, Horario,DiaDaSemana, CursoPeriodoDisciplina, Professor) VALUES (@Id,@Sala,@Horario,@DiadaSemana, @CursoPeriodoDisciplina, @Professor); ";
            SqlCommand Comando = new SqlCommand(Query, Conexao);
            SqlParameter par1 = new SqlParameter("@Id", mapadeSala.Id);
            SqlParameter par2 = new SqlParameter("@Sala", mapadeSala.Sala);
            SqlParameter par3 = new SqlParameter("@Horario", mapadeSala.Horario);
            SqlParameter par4 = new SqlParameter("@DiadaSemana", mapadeSala.DiaDaSemana);
            SqlParameter par5 = new SqlParameter("@CursoPeriodoDisciplina", mapadeSala.CursoPeriodoDisciplina);
            SqlParameter par6 = new SqlParameter("@Professor", mapadeSala.Professor);

            Comando.Parameters.Add(par1);
            Comando.Parameters.Add(par2);
            Comando.Parameters.Add(par3);
            Comando.Parameters.Add(par4);
            Comando.Parameters.Add(par5);
            Comando.Parameters.Add(par6);
            Comando.ExecuteNonQuery();
            Conexao.Close();
        }

        public DataTable ObterMapadeSala()
        {
            DataTable retorno = new DataTable();
            Conexao.Open();
            string query = "SELECT ID, SALA, HORARIO, DIADASEMANA,CURSOPERIODODISCIPLINA,PROFESSOR FROM CURSOS ORDER BY DIADASEMANA DESC";
            SqlCommand Comando = new SqlCommand(query, Conexao);

            SqlDataReader Leitura = Comando.ExecuteReader();

            foreach (var atributos in typeof(MapadeSalaEntidade).GetProperties())
            {
                retorno.Columns.Add(atributos.Name);
            }

            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    MapadeSalaEntidade ms = new MapadeSalaEntidade();
                    ms.Id = Convert.ToInt32(Leitura[0]);
                    ms.Sala = Leitura[1].ToString();
                    ms.Horario = Leitura[2].ToString();
                    ms.DiaDaSemana = Leitura[3].ToString();
                    ms.CursoPeriodoDisciplina = Leitura[4].ToString();
                    ms.Professor = Leitura[5].ToString();
                    retorno.Rows.Add(ms.Linha());
                }
            }
            Conexao.Close();
            return retorno;
        }
        public void ExcluirMapadeSala(int indexMapadeSala)
        {
            Conexao.Open();
            string Query = "DELETE FROM MapadeSala WHERE id = @id; ";
            SqlCommand Comando = new SqlCommand(Query, Conexao);
            SqlParameter par1 = new SqlParameter("@id", indexMapadeSala);

            Comando.Parameters.Add(par1);
            Comando.ExecuteNonQuery();
            Conexao.Close();
        }
        public DataTable PesquisarMapadeSala(string search)
        {
            DataTable retorno = new DataTable();
            Conexao.Open();
            string query = "";
            if (string.IsNullOrEmpty(search))
            {
                query = "SELECT * FROM MapadeSala ORDER BY ID DESC";
            }
            else
            {
                query = "SELECT * FROM MapadeSala WHERE Sala LIKE '%" + search + "%' OR Horario LIKE '%" + search + "%' OR ID LIKE '%" + search + "%' ORDER BY ID DESC";
            }
            SqlCommand Comando = new SqlCommand(query, Conexao);

            SqlDataReader Leitura = Comando.ExecuteReader();

            foreach (var atributos in typeof(MapadeSalaEntidade).GetProperties())
            {
                retorno.Columns.Add(atributos.Name);
            }

            if (Leitura.HasRows) //terminar aqui
            {
                while (Leitura.Read())
                {
                    MapadeSalaEntidade ms = new MapadeSalaEntidade();
                    ms.Id = Convert.ToInt32(Leitura[0]);
                    ms.Sala = Leitura[1].ToString();
                    ms.Horario = Leitura[2].ToString();
                    ms.DiaDaSemana = Leitura[3].ToString();
                    ms.CursoPeriodoDisciplina = Leitura[4].ToString();
                    ms.Professor = Leitura[5].ToString();
                    retorno.Rows.Add(ms.Linha());
                }
            }
            Conexao.Close();
            return retorno;
        }
    }
}
