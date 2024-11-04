using MapadeSala.Ferramentas;
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

namespace MapadeSala.Formularios.Editar
{
    public partial class frmEditarCursos : Form
    {
        List<object[]> Inputs = new List<object[]>();

        Comandos c = new Comandos();

        private string LinhaConexao = "Server=LS05MPF;Database=Aula_DS;User Id=SA;Password=admsasql;"; //LS05M020
        private SqlConnection Conexao;
        public frmEditarCursos(int CursosId)
        {
            InitializeComponent();
            Inputs.Add(new object[] { txtNome, "txt" });
            Inputs.Add(new object[] { txtTurno, "txt" });
            Inputs.Add(new object[] { txtSigla, "txt" });
            Inputs.Add(new object[] { chkAtivo, "chk" });

            string query = "select Id, Nome, Turno, Sigla, Ativo " +
                "from Cursos where Id = @id";

            Conexao = new SqlConnection(LinhaConexao);
            Conexao.Open();

            SqlCommand comando = new SqlCommand(query, Conexao);

            comando.Parameters.Add(new SqlParameter("@id", CursosId));

            SqlDataReader Leitura = comando.ExecuteReader();

            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    label_id.Text = Leitura[0].ToString();
                    txtNome.Text = Leitura[1].ToString();
                    txtTurno.Text = Leitura[2].ToString();
                    txtSigla.Text = Leitura[3].ToString();
                    chkAtivo.Checked = Convert.ToBoolean(Leitura[4]);

                }
            }
            Conexao.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            c.ClearInsertForm(Inputs);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string query = "Delete from Cursos WHERE  Id = @id";

            Conexao = new SqlConnection(LinhaConexao);
            Conexao.Open();

            SqlCommand comando = new SqlCommand(query, Conexao);
            comando.Parameters.Add(new SqlParameter("@id", label_id.Text));
            int resposta = comando.ExecuteNonQuery();

            if (resposta == 1)
            {
                MessageBox.Show("Curso Excluído com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao excluir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string query = "update Cursos set Nome = @nome, Turno = @turno, Sigla = @sigla, Ativo = @ativo WHERE  Id = @id";

            Conexao = new SqlConnection(LinhaConexao);
            Conexao.Open();

            SqlCommand comando = new SqlCommand(query, Conexao);

            comando.Parameters.Add(new SqlParameter("@id", label_id.Text));
            comando.Parameters.Add(new SqlParameter("@nome", txtNome.Text));
            comando.Parameters.Add(new SqlParameter("@turno", txtTurno.Text));
            comando.Parameters.Add(new SqlParameter("@sigla", txtSigla.Text));
            comando.Parameters.Add(new SqlParameter("@ativo", chkAtivo.Checked));

            int resposta = comando.ExecuteNonQuery();

            if (resposta == 1)
            {
                MessageBox.Show("Curso Atualizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
