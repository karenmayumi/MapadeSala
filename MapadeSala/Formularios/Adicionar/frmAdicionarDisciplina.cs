using MapadeSala.DAO;
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
    public partial class frmAdicionarDisciplina : Form
    {
        DataTable dados;
        DisciplinaDAO dao = new DisciplinaDAO();

        private string LinhaConexao = "Server=LS05MPF;Database=Aula_DS;User Id=SA;Password=admsasql;"; //LS05M020
        private SqlConnection Conexao;
        public frmAdicionarDisciplina()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            DisciplinaEntidade disciplina = new DisciplinaEntidade();
            disciplina.Id = Convert.ToInt32(numId.Value);
            disciplina.Nome = txtNome.Text;
            disciplina.Sigla = txtSigla.Text;
            disciplina.Ativo = chkAtivo.Checked;

            //DisciplinaDAO dao = new DisciplinaDAO();
            //dao.InserirDisciplina(disciplina);

            string query = "insert into Disciplinas (nome,sigla,ativo) values (@nome,@sigla,@ativo)";

            Conexao = new SqlConnection(LinhaConexao);
            Conexao.Open();

            SqlCommand comando = new SqlCommand(query, Conexao);

            comando.Parameters.Add(new SqlParameter("@sigla", txtSigla.Text));
            comando.Parameters.Add(new SqlParameter("@nome", txtNome.Text));
            comando.Parameters.Add(new SqlParameter("@ativo", chkAtivo.Checked));

            int resposta = comando.ExecuteNonQuery();




            if (resposta == 1)
            {
                MessageBox.Show("Disciplina adicionada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
