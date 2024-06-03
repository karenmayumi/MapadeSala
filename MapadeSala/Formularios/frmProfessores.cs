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
    public partial class frmProfessores : Form
    {
        BindingSource dados;
        public frmProfessores()
        {
            InitializeComponent();
            dados = new BindingSource();
            dtGridSalas.DataSource = dados;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ProfessoresEntidade prof = new ProfessoresEntidade();
            prof.Id = Convert.ToInt32(txtId.Text);
            prof.Nome = txtNome.Text;
            prof.Apelido = txtNome.Text;

            dados.Add(prof);
        }
    }
}
