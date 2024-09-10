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
    public partial class frmCursos : Form
    {
        DataTable dados;
        CursoDAO dao = new CursoDAO();
        int LinhaSelecionada;

        List<object[]> Inputs = new List<object[]>();
        Comandos c = new Comandos();
        public frmCursos()
        {
            InitializeComponent();

            //Inserindo os campos do input para limpá-los
            Inputs.Add(new object[] { numId, "num" });
            Inputs.Add(new object[] { txtNome, "txt" });
            Inputs.Add(new object[] { txtTurno, "txt" });
            Inputs.Add(new object[] { txtSigla, "txt" });
            Inputs.Add(new object[] { chkAtivo, "chk" });

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
            c.ClearInsertForm(Inputs);
        }

        private void dtGridCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            numId.Value = Convert.ToInt32(dtGridCursos.Rows[LinhaSelecionada].Cells[0].Value.ToString());
            txtNome.Text = dtGridCursos.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            txtTurno.Text = dtGridCursos.Rows[LinhaSelecionada].Cells[2].Value.ToString();
            txtSigla.Text = dtGridCursos.Rows[LinhaSelecionada].Cells[3].Value.ToString();
            chkAtivo.Checked = Convert.ToBoolean(dtGridCursos.Rows[LinhaSelecionada].Cells[4].Value.ToString());
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow linha = dtGridCursos.Rows[LinhaSelecionada];

            linha.Cells[0].Value = numId.Value;
            linha.Cells[1].Value = txtNome.Text;
            linha.Cells[2].Value = txtTurno.Text;
            linha.Cells[3].Value = txtTurno.Text;
            linha.Cells[4].Value = chkAtivo.Checked;
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            CursosEntidade cursos = new CursosEntidade();
            cursos.Id = Convert.ToInt32(numId.Value);
            cursos.Nome = txtNome.Text;
            cursos.Turno = txtTurno.Text;
            cursos.Sigla = txtSigla.Text;
            cursos.Ativo = chkAtivo.Checked;

            dados.Rows.Add(cursos.Linha());

            CursoDAO dao = new CursoDAO();
            dao.Inserir(cursos);

            dtGridCursos.DataSource = dao.ObterCursos();

            c.ClearInsertForm(Inputs);
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            c.ClearInsertForm(Inputs);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtGridCursos.DataSource = dao.PesquisarCursos(txtSearch.Text);
        }
    }
}
