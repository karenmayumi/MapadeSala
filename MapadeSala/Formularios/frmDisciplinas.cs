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
    public partial class frmDisciplinas : Form
    {

        BindingSource dados;
        public frmDisciplinas()
        {
            InitializeComponent();
            dados = new BindingSource();
            dtGridSalas.DataSource = dados;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DisciplinaEntidade disciplina = new DisciplinaEntidade();
            disciplina.Id = Convert.ToInt32(txtId.Text);
            disciplina.Nome = txtNome.Text;
            disciplina.Sigla = txtSigla.Text;
            disciplina.Ativo = chkAtivo.Checked;

            dados.Add(disciplina);
        }
    }
}
