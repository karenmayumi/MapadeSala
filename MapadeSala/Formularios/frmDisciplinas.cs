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
using MapadeSala.DAO.Editar;
using MapadeSala.Formularios.Adicionar;

namespace MapadeSala.Formularios
{
    public partial class frmDisciplinas : Form
    {
        DataTable dados;
        DisciplinaDAO dao = new DisciplinaDAO();
        int LinhaSelecionada;

        List<object[]> Inputs = new List<object[]>();
        Comandos c = new Comandos();
        public frmDisciplinas()
        {
            InitializeComponent();
                        dados = new DataTable();

            foreach (var atributos in typeof(DisciplinaEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

            dtGridDisciplina.DataSource = dados;
            dtGridDisciplina.DataSource = dao.ObterDisciplina();
        }

        private void dtGridDisciplina_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            c.ClearInsertForm(Inputs);
        }

        private void btnEditar_Click(object sender, EventArgs e) //salvar alteracoes
        {
            if (LinhaSelecionada >= 0)
            {
                int id = Convert.ToInt32(dtGridDisciplina.Rows[LinhaSelecionada].Cells[0].Value);
                frmEditarDisciplina editar = new frmEditarDisciplina(id);

                //Inscreve-se no evento
                editar.FormClosed += frmDisciplinas_FormClosed;
                editar.ShowDialog();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtGridDisciplina.DataSource = dao.PesquisarDisciplina(txtSearch.Text);
        }

        private void dtGridDisciplina_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dtGridDisciplina.Rows[e.RowIndex].Cells[0].Value);
                frmEditarDisciplina editar = new frmEditarDisciplina(id);

                //Inscreve-se no evento
                editar.FormClosed += frmDisciplinas_FormClosed;
                editar.ShowDialog();
                LinhaSelecionada = e.RowIndex;
            }
        }

        private void frmDisciplinas_FormClosed(object sender, FormClosedEventArgs e)
        {
            dtGridDisciplina.DataSource = dao.ObterDisciplina();
        }

        private void btnAdicionarDisciplina_Click(object sender, EventArgs e)
        {
            frmAdicionarDisciplina adicionar = new frmAdicionarDisciplina();

            //Inscreve-se no evento
            adicionar.FormClosed += frmDisciplinas_FormClosed;
            adicionar.ShowDialog();
        }
    }
}
