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
using MapadeSala.DAO;
using MapadeSala.Formularios.Adicionar;
using MapadeSala.Formularios.Editar;

namespace MapadeSala.Formularios
{
    public partial class frmCursos : Form
    {
        DataTable dados;
        CursoDAO dao = new CursoDAO();
        int LinhaSelecionada;

        Comandos c = new Comandos();
        public frmCursos()
        {
            InitializeComponent();


            dados = new DataTable();
            foreach (var atributos in typeof(CursosEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

            dados = dao.ObterCursos();
            dtGridCursos.DataSource = dados;
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            CursoDAO dao = new CursoDAO();
            dao.ExcluirCurso(LinhaSelecionada);

            dtGridCursos.Rows.RemoveAt(LinhaSelecionada);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtGridCursos.DataSource = dao.PesquisarCursos(txtSearch.Text);
        }

        private void frmCursos_FormClosed(object sender, FormClosedEventArgs e)
        {
            dtGridCursos.DataSource = dao.ObterCursos();
            LinhaSelecionada = 0;
        }

        private void btnAdicionarDisciplina_Click(object sender, EventArgs e)
        {
            frmAdicionarCursos adicionar = new frmAdicionarCursos();

            //Inscreve-se no evento
            adicionar.FormClosed += frmCursos_FormClosed;
            adicionar.ShowDialog();
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            dtGridCursos.DataSource = dao.PesquisarCursos(txtSearch.Text);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (LinhaSelecionada >= 0)
            {
                int id = Convert.ToInt32(dtGridCursos.Rows[LinhaSelecionada].Cells[0].Value);
                frmEditarCursos editar = new frmEditarCursos(id);

                //Inscreve-se no evento
                editar.FormClosed += frmCursos_FormClosed;
                editar.ShowDialog();
            }
        }

        private void dtGridCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            LinhaSelecionada = e.RowIndex;
        }

        private void dtGridCursos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dtGridCursos.Rows[e.RowIndex].Cells[0].Value);
                frmEditarCursos editar = new frmEditarCursos(id);

                //Inscreve-se no evento
                editar.FormClosed += frmCursos_FormClosed;
                editar.ShowDialog();
            }
        }
    }
}
