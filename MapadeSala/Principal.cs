using MapadeSala.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapadeSala
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }


        private void salasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalas s = new frmSalas();
            s.ShowDialog();
        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfessores f = new frmProfessores();
            f.ShowDialog();
        }

        private void disciplinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDisciplinas d = new frmDisciplinas();
            d.ShowDialog();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCursos c = new frmCursos();
            c.ShowDialog();
        }

        private void cursoDisciplinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCursoDisciplina cd = new frmCursoDisciplina();
            cd.ShowDialog();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios usuarios = new frmUsuarios();
            usuarios.ShowDialog();
        }
    }
}
