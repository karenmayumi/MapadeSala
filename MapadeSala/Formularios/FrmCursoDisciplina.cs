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
    public partial class frmCursoDisciplina : Form
    {
        DisciplinaDAO disciplinaDAO = new DisciplinaDAO();
        CursoDAO cursoDAO = new CursoDAO();
        CursoDisciplinaDAO cdDAO = new CursoDisciplinaDAO();
        private void AtualizarGrid(DataTable dados)
        {
            dtGridCursoDisciplina.DataSource = dados;
        }
        public frmCursoDisciplina()
        {
            InitializeComponent();

            cbDisciplina.DataSource = disciplinaDAO.PreencherComboBox();
            cbDisciplina.DisplayMember = "Nome";
            cbDisciplina.ValueMember = "Id";

            cbCursos.DataSource = cursoDAO.PreencherComboBox();
            cbCursos.DisplayMember = "Nome";
            cbCursos.ValueMember = "Id";

            AtualizarGrid(cdDAO.ObterCursoDisciplina());

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            CursoDisciplinaDAO cursoDisciplinaDao = new CursoDisciplinaDAO();

            CursoDisciplinaEntidade entidade = new CursoDisciplinaEntidade();

            entidade.CursoId = Convert.ToInt32(cbCursos.SelectedValue);
            entidade.DisciplinaId = Convert.ToInt32(cbDisciplina.SelectedValue);
            entidade.Periodo = cbPeriodo.SelectedItem.ToString();

            cursoDisciplinaDao.Inserir(entidade);
            AtualizarGrid(cdDAO.ObterCursoDisciplina());
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtGridCursoDisciplina.DataSource = cdDAO.PesquisarCursoDisciplina(txtSearch.Text);
        }
    }
}
