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
            usuario.Id = Convert.ToInt32(txtId.Text);
            usuario.Login = txtLogin.Text;
            usuario.Senha = txtSenha.Text;
            usuario.Nome = txtNome.Text;
            usuario.Ativo = chkAtivo.Checked;

            dados.Add(usuario);
        }
    }
}
