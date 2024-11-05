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
    public partial class frmProfessores : Form
    {
        DataTable dados;
        ProfessorDAO dao = new ProfessorDAO();
        int LinhaSelecionada;

        List<object[]> Inputs = new List<object[]>();
        Comandos c = new Comandos();

        public frmProfessores()
        {
            InitializeComponent();

            dados = new DataTable();
            foreach (var atributos in typeof(ProfessoresEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

            dados = dao.ObterProfessores();
            dtGridProfessores.DataSource = dados;
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ProfessorDAO dao = new ProfessorDAO();
            dao.ExcluirProfessor(LinhaSelecionada);

            dtGridProfessores.Rows.RemoveAt(LinhaSelecionada);
            c.ClearInsertForm(Inputs);
        }

        private void dtGridProfessores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            c.ClearInsertForm(Inputs);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtGridProfessores.DataSource = dao.PesquisarProfessor(txtSearch.Text);
        }

        private void btnAdicionarProfessor_Click(object sender, EventArgs e)
        {
            frmAdicionarProfessor adicionar = new frmAdicionarProfessor();

            //Inscreve-se no evento
            adicionar.FormClosed += frmProfessores_FormClosed;
            adicionar.ShowDialog();
        }
        private void frmProfessores_FormClosed(object sender, FormClosedEventArgs e)
        {
            dtGridProfessores.DataSource = dao.ObterProfessores();
            LinhaSelecionada = 0;
        }

        private void dtGridProfessores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dtGridProfessores.Rows[e.RowIndex].Cells[0].Value);
                frmEditarProfessor editar = new frmEditarProfessor(id);

                //Inscreve-se no evento
                editar.FormClosed += frmProfessores_FormClosed;
                editar.ShowDialog();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (LinhaSelecionada >= 0)
            {
                int id = Convert.ToInt32(dtGridProfessores.Rows[LinhaSelecionada].Cells[0].Value);
                frmEditarCursos editar = new frmEditarCursos(id);

                //Inscreve-se no evento
                editar.FormClosed += frmProfessores_FormClosed;
                editar.ShowDialog();
            }
        }
    }
}
