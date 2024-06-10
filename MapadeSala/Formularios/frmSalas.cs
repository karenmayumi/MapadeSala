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
    public partial class frmSalas : Form
    {
        BindingSource dados;
        public frmSalas()
        {
            InitializeComponent();
            dados = new BindingSource();
            dtGridSalas.DataSource = dados;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalasEntidade sala = new SalasEntidade();
            sala.Id = Convert.ToInt32(numId.Value);
            sala.Nome = txtNome.Text;
            sala.IsLab = chkIsLab.Checked;
            sala.NumCadeiras = Convert.ToInt32(numChair.Text);
            sala.NumComputadores = Convert.ToInt32(numNumPc.Value);
            sala.Disponivel = chkDisponivel.Checked;

            dados.Add(sala);
        }
    }
}
