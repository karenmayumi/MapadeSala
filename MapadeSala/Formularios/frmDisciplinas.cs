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

namespace MapadeSala.Formularios
{
    public partial class frmDisciplinas : Form
    {
        DataTable dados;
        int LinhaSelecionada;
        public frmDisciplinas()
        {
            InitializeComponent();
            dados = new DataTable();
            foreach (var atributos in typeof(DisciplinaEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

            dtGridDisciplina.DataSource = dados;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DisciplinaEntidade disciplina = new DisciplinaEntidade();
            disciplina.Id = Convert.ToInt32(numId.Value);
            disciplina.Nome = txtNome.Text;
            disciplina.Sigla = txtSigla.Text;
            disciplina.Ativo = chkAtivo.Checked;

            dados.Rows.Add(disciplina.Linha());

            //limpar campos
            Comandos c = new Comandos();
            List<object[]> Inputs = new List<object[]>();
            Inputs.Add(new object[] { numId, "num" });
            Inputs.Add(new object[] { txtNome, "txt" });
            Inputs.Add(new object[] { txtSigla, "txt" });
            Inputs.Add(new object[] { chkAtivo, "chk" });
            c.ClearInsertForm(Inputs);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dtGridDisciplina.Rows.RemoveAt(LinhaSelecionada);
        }

        private void dtGridDisciplina_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            numId.Value = Convert.ToInt32(dtGridDisciplina.Rows[LinhaSelecionada].Cells[0].Value.ToString());
            txtNome.Text = dtGridDisciplina.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            txtSigla.Text = dtGridDisciplina.Rows[LinhaSelecionada].Cells[2].Value.ToString();
            chkAtivo.Checked = Convert.ToBoolean(dtGridDisciplina.Rows[LinhaSelecionada].Cells[3].Value.ToString());
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //limpar campos
            Comandos c = new Comandos();
            List<object[]> Inputs = new List<object[]>();
            Inputs.Add(new object[] { numId, "num" });
            Inputs.Add(new object[] { txtNome, "txt" });
            Inputs.Add(new object[] { txtSigla, "txt" });
            Inputs.Add(new object[] { chkAtivo, "chk" });
            c.ClearInsertForm(Inputs);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow linha = dtGridDisciplina.Rows[LinhaSelecionada];

            linha.Cells[0].Value = numId.Value;
            linha.Cells[1].Value = txtNome.Text;
            linha.Cells[2].Value = txtSigla.Text;
            linha.Cells[3].Value = chkAtivo.Checked;

            // dtGridDisciplina.Rows[LinhaSelecionada] = linha;
        }
    }
}
