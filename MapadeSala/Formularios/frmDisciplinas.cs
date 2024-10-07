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

            //Inserindo os campos do input para limpá-los
            Inputs.Add(new object[] { numId, "num" });
            Inputs.Add(new object[] { txtNome, "txt" });
            Inputs.Add(new object[] { txtSigla, "txt" });
            Inputs.Add(new object[] { chkAtivo, "chk" });

            dados = new DataTable();

            foreach (var atributos in typeof(DisciplinaEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

            dtGridDisciplina.DataSource = dados;
            dtGridDisciplina.DataSource = dao.ObterDisciplina();
        }

        private void btnSalvar_Click(object sender, EventArgs e) //criar
        {
            DisciplinaEntidade disciplina = new DisciplinaEntidade();
            disciplina.Id = Convert.ToInt32(numId.Value);
            disciplina.Nome = txtNome.Text;
            disciplina.Sigla = txtSigla.Text;
            disciplina.Ativo = chkAtivo.Checked;

            dados.Rows.Add(disciplina.Linha());

            DisciplinaDAO dao = new DisciplinaDAO();
            dao.InserirDisciplina(disciplina);

            c.ClearInsertForm(Inputs);


            dtGridDisciplina.DataSource = dao.ObterDisciplina();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dtGridDisciplina.Rows.RemoveAt(LinhaSelecionada);

            DisciplinaDAO dao = new DisciplinaDAO();
            dao.ExcluirDisciplina(LinhaSelecionada);

            dtGridDisciplina.Rows.RemoveAt(LinhaSelecionada);
            c.ClearInsertForm(Inputs);
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
            c.ClearInsertForm(Inputs);
        }

        private void btnEditar_Click(object sender, EventArgs e) //salvar alteracoes
        {
            DataGridViewRow linha = dtGridDisciplina.Rows[LinhaSelecionada];

            linha.Cells[0].Value = numId.Value;
            linha.Cells[1].Value = txtNome.Text;
            linha.Cells[2].Value = txtSigla.Text;
            linha.Cells[3].Value = chkAtivo.Checked;
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
                editar.FormClosed += Fechou_Editar_FormClosed;
                editar.ShowDialog();
            }
        }
    }
}
