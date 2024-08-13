using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.Entidades;
using MapadeSala.Ferramentas;

namespace MapadeSala.Formularios
{
    public partial class frmUsuario : Form
    {
        DataTable dados;
        int LinhaSelecionada;
        public frmUsuario()
        {
            InitializeComponent();
            dados = new DataTable();
            foreach (var atributos in typeof(UsuarioEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

            dtGridUsuario.DataSource = dados;
        }
        private void btnSalvar_Click(object sender, EventArgs e) //criar
        {
            UsuarioEntidade usuario = new UsuarioEntidade();
            usuario.Id = Convert.ToInt32(numId.Text);
            usuario.Login = txtLogin.Text;
            usuario.Senha = txtSenha.Text;
            usuario.Nome = txtNome.Text;
            usuario.Ativo = chkAtivo.Checked;

            dados.Rows.Add(usuario.Linha());

            Comandos c = new Comandos();
            List<object[]> Inputs = new List<object[]>();
            Inputs.Add(new object[] { numId, "num" });
            Inputs.Add(new object[] { txtLogin, "txt" });
            Inputs.Add(new object[] { txtSenha, "txt" });
            Inputs.Add(new object[] { txtNome, "txt" });
            Inputs.Add(new object[] { chkAtivo, "chk" });

            c.ClearInsertForm(Inputs);

        }

        private void btnSalvar_Click_1(object sender, EventArgs e) //criar
        {
            DataGridViewRow linha = dtGridUsuario.Rows[LinhaSelecionada];

            linha.Cells[0].Value = numId.Value;
            linha.Cells[1].Value = txtLogin.Text;
            linha.Cells[2].Value = txtSenha.Text;
            linha.Cells[3].Value = txtNome.Text;
            linha.Cells[4].Value = chkAtivo.Checked;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //limpar campos
            Comandos c = new Comandos();
            List<object[]> Inputs = new List<object[]>();
            Inputs.Add(new object[] { numId, "num" });
            Inputs.Add(new object[] { txtLogin, "txt" });
            Inputs.Add(new object[] { txtSenha, "txt" });
            Inputs.Add(new object[] { txtNome, "txt" });
            Inputs.Add(new object[] { chkAtivo, "chk" });
            c.ClearInsertForm(Inputs);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dtGridUsuario.Rows.RemoveAt(LinhaSelecionada);
        }

        private void dtGridUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            numId.Value = Convert.ToInt32(dtGridUsuario.Rows[LinhaSelecionada].Cells[0].Value.ToString());
            txtLogin.Text = dtGridUsuario.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            txtSenha.Text = dtGridUsuario.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            txtNome.Text = dtGridUsuario.Rows[LinhaSelecionada].Cells[2].Value.ToString();
            chkAtivo.Checked = Convert.ToBoolean(dtGridUsuario.Rows[LinhaSelecionada].Cells[3].Value.ToString());
        }

    }
}
