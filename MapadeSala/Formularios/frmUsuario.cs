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
        BindingSource dados;
        public frmUsuario()
        {
            InitializeComponent();
            dados = new BindingSource();
            dtGridSalas.DataSource = dados;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            UsuarioEntidade usuario = new UsuarioEntidade();
            usuario.Id = Convert.ToInt32(numId.Text);
            usuario.Login = txtLogin.Text;
            usuario.Senha = txtSenha.Text;
            usuario.Nome = txtNome.Text;
            usuario.Ativo = chkAtivo.Checked;

            dados.Add(usuario);

            Comandos c = new Comandos();
            List<object[]> Inputs = new List<object[]>();
            Inputs.Add(new object[] { numId, "num" });
            Inputs.Add(new object[] { txtLogin, "txt" });
            Inputs.Add(new object[] { txtSenha, "txt" });
            Inputs.Add(new object[] { txtNome, "txt" });
            Inputs.Add(new object[] { chkAtivo, "chk" });

            c.ClearInsertForm(Inputs);
        }
    }
}
