using MapadeSala.DAO;
using MapadeSala.Ferramentas;
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

namespace MapadeSala.Formularios.Adicionar
{
    public partial class frmAdicionarProfessor : Form
    {
        List<object[]> Inputs = new List<object[]>();
        Comandos c = new Comandos();
        private string LinhaConexao = "Server=LS05MPF;Database=Aula_DS;User Id=SA;Password=admsasql;"; //LS05M020
        private SqlConnection Conexao;
        public frmAdicionarProfessor()
        {
            InitializeComponent();

            //Inserindo os campos do input para limpá-los
            Inputs.Add(new object[] { txtNome, "txt" });
            Inputs.Add(new object[] { txtApelido, "txt" });
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            ProfessoresEntidade prof = new ProfessoresEntidade();
            prof.Nome = txtNome.Text;
            prof.Apelido = txtApelido.Text;

            ProfessorDAO dao = new ProfessorDAO();
            dao.Inserir(prof);

            string query = "insert into Professores (nome,apelido) values (@nome,@apelido)";

            Conexao = new SqlConnection(LinhaConexao);
            Conexao.Open();

            SqlCommand comando = new SqlCommand(query, Conexao);

            comando.Parameters.Add(new SqlParameter("@nome", txtNome.Text));
            comando.Parameters.Add(new SqlParameter("@apelido", txtApelido.Text));

            int resposta = comando.ExecuteNonQuery();

            if (resposta == 1)
            {
                MessageBox.Show("Professor adicionado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            c.ClearInsertForm(Inputs);
        }
    }
}
