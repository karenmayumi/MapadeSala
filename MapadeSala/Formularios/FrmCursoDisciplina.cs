using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MapadeSala.DAO;
using MapaSala.DAO;
using Model.Entidades;

namespace MapadeSala.Formularios
{
    public partial class FrmCursoDisciplina : Form
    {
        DisciplinaDAO disciplinaDAO = new DisciplinaDAO();
        CursoDAO cursoDAO = new CursoDAO();
        public FrmCursoDisciplina()
        {
            InitializeComponent();

            cbDisciplina.DataSource = disciplinaDAO.PreencherComboBox();
            cbDisciplina.DisplayMember = "Nome";
            cbDisciplina.ValueMember = "Id";

            cbCursos.DataSource = cursoDAO.PreencherComboBox();
            cbCursos.DisplayMember = "Nome";
            cbCursos.ValueMember = "Id";
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            CursoDisciplinaDAO cursoDisciplinaDao = new CursoDisciplinaDAO();

            CursoDisciplinaEntidade entidade = new CursoDisciplinaEntidade();

            entidade.CursoId = Convert.ToInt32(cbCursos.SelectedValue);
            entidade.DisciplinaId = Convert.ToInt32(cbDisciplina.SelectedValue);
            entidade.Periodo = cbPeriodo.SelectedValue.ToString();
        }
    }
}
