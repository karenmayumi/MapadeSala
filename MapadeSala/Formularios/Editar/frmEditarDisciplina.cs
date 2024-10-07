
using Model.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapadeSala.DAO.Editar
{
    public partial class frmEditarDisciplina : Form
    {
        DataTable dados;
        DisciplinaDAO dao = new DisciplinaDAO();
        int LinhaSelecionada;

        private string LinhaConexao = "Server=LS05MPF;Database=Aula_DS;User Id=SA;Password=admsasql;"; //LS05M020
        private SqlConnection Conexao;

        public frmEditarDisciplina()
        {
            InitializeComponent();
            Conexao = new SqlConnection(LinhaConexao);


            DataTable retorno = new DataTable();
            Conexao.Open();
            string query = "SELECT ID, NOME, SIGLA, ATIVO FROM DISCIPLINAS ORDER BY ID DESC";
            SqlCommand Comando = new SqlCommand(query, Conexao);

            SqlDataReader Leitura = Comando.ExecuteReader();

            foreach (var atributos in typeof(DisciplinaEntidade).GetProperties())
            {
                retorno.Columns.Add(atributos.Name);
            }

            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    DisciplinaEntidade c = new DisciplinaEntidade();
                    c.Id = Convert.ToInt32(Leitura[0]);
                    c.Nome = Leitura[1].ToString();
                    c.Sigla = Leitura[2].ToString();
                    c.Ativo = Convert.ToBoolean(Leitura[3]);
                    retorno.Rows.Add(c.Linha());
                }
            }
            Conexao.Close();

        }

    }
}
