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
    public partial class frmAdicionarCursos : Form
    {
        List<object[]> Inputs = new List<object[]>();

        Comandos c = new Comandos();

        private string LinhaConexao = "Server=LS05MPF;Database=Aula_DS;User Id=SA;Password=admsasql;"; //LS05M020
        private SqlConnection Conexao;
        public frmAdicionarCursos()
        {
            InitializeComponent();
            Inputs.Add(new object[] { txtNome, "txt" });
            Inputs.Add(new object[] { txtTurno, "txt" });
            Inputs.Add(new object[] { txtSigla, "txt" });
            Inputs.Add(new object[] { chkAtivo, "chk" });
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            CursosEntidade curso = new CursosEntidade();
            curso.Nome = txtNome.Text;
            curso.Turno = txtTurno.Text;
            curso.Sigla = txtSigla.Text;
            curso.Ativo = chkAtivo.Checked;

            string query = "insert into Cursos (nome,turno,sigla,ativo) values (@nome,@turno,@sigla,@ativo)";

            Conexao = new SqlConnection(LinhaConexao);
            Conexao.Open();

            SqlCommand comando = new SqlCommand(query, Conexao);

            comando.Parameters.Add(new SqlParameter("@nome", txtNome.Text));
            comando.Parameters.Add(new SqlParameter("@turno", txtTurno.Text));
            comando.Parameters.Add(new SqlParameter("@sigla", txtSigla.Text));
            comando.Parameters.Add(new SqlParameter("@ativo", chkAtivo.Checked));

            int resposta = comando.ExecuteNonQuery();

            if (resposta == 1)
            {
                MessageBox.Show("Curso adicionado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void frmAdicionarCursos_Load(object sender, EventArgs e)
        {

        }
    }
}
