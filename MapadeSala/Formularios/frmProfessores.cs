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
        public frmProfessores()
        {
            InitializeComponent();
            dados = new DataTable();
            foreach (var atributos in typeof(ProfessoresEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

            dtGridProfessores.DataSource = dados;
            dados = dao.ObterProfessores();
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

            Comandos c = new Comandos();
            List<object[]> Inputs = new List<object[]>();
            Inputs.Add(new object[] { numId, "num" });
            Inputs.Add(new object[] { txtNome, "txt" });
            Inputs.Add(new object[] { txtApelido, "txt" });

            c.ClearInsertForm(Inputs);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dtGridProfessores.Rows.RemoveAt(LinhaSelecionada);
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
            //limpar campos
            Comandos c = new Comandos();
            List<object[]> Inputs = new List<object[]>();
            Inputs.Add(new object[] { numId, "num" });
            Inputs.Add(new object[] { txtNome, "txt" });
            Inputs.Add(new object[] { txtApelido, "txt" });
            c.ClearInsertForm(Inputs);
        }
    }
}
