using MapadeSala.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapadeSala.Formularios.Adicionar
{
    public partial class frmAdicionarUsuario : Form
    {
        public frmAdicionarUsuario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Usuarios u = new Usuarios();
            u.Login = txtLogin.Text;
            u.Senha = txtSenha.Text;
            u.Ativo = chkAtivo.Checked;
            u.Inserir();
            MessageBox.Show("Sucesso", "Cadastrado com sucesso");
            Close();
        }
    }
}
