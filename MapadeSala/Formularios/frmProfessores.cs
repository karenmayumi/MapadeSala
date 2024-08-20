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

            //Inserindo os campos do input para limpá-los
            Inputs.Add(new object[] { numId, "num" });
            Inputs.Add(new object[] { txtNome, "txt" });
            Inputs.Add(new object[] { txtApelido, "txt" });

            dados = new DataTable();
            foreach (var atributos in typeof(ProfessoresEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

            dados = dao.ObterProfessores();
            dtGridProfessores.DataSource = dados;
        }

        private void btnSalvar_Click(object sender, EventArgs e) //criar
        {
            ProfessoresEntidade prof = new ProfessoresEntidade();
            prof.Id = Convert.ToInt32(numId.Value);
            prof.Nome = txtNome.Text;
            prof.Apelido = txtApelido.Text;

            dados.Rows.Add(prof.Linha());

            ProfessorDAO dao = new ProfessorDAO();
            dao.Inserir(prof);

            dtGridProfessores.DataSource = dao.ObterProfessores();

            c.ClearInsertForm(Inputs);
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
            numId.Value = Convert.ToInt32(dtGridProfessores.Rows[LinhaSelecionada].Cells[0].Value.ToString());
            txtNome.Text = dtGridProfessores.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            txtApelido.Text = dtGridProfessores.Rows[LinhaSelecionada].Cells[2].Value.ToString();
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow linha = dtGridProfessores.Rows[LinhaSelecionada];

            linha.Cells[0].Value = numId.Value;
            linha.Cells[1].Value = txtNome.Text;
            linha.Cells[2].Value = txtApelido.Text;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            c.ClearInsertForm(Inputs);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtGridProfessores.DataSource = dao.PesquisarProfessor(txtSearch.Text);
        }
    }
}
