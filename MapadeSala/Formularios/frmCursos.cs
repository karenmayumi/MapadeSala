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
    public partial class frmCursos : Form
    {
        DataTable dados;
        int LinhaSelecionada;
        public frmCursos()
        {
            InitializeComponent();
            dados = new DataTable();
            foreach (var atributos in typeof(CursosEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

            dtGridCursos.DataSource = dados;
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dtGridCursos.Rows.RemoveAt(LinhaSelecionada);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //limpar campos
            Comandos c = new Comandos();
            List<object[]> Inputs = new List<object[]>();
            Inputs.Add(new object[] { numId, "num" });
            Inputs.Add(new object[] { txtNome, "txt" });
            Inputs.Add(new object[] { txtTurno, "txt" });
            Inputs.Add(new object[] { chkAtivo, "chk" });
            c.ClearInsertForm(Inputs);
        }

        private void dtGridCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            numId.Value = Convert.ToInt32(dtGridCursos.Rows[LinhaSelecionada].Cells[0].Value.ToString());
            txtNome.Text = dtGridCursos.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            txtTurno.Text = dtGridCursos.Rows[LinhaSelecionada].Cells[2].Value.ToString();
            chkAtivo.Checked = Convert.ToBoolean(dtGridCursos.Rows[LinhaSelecionada].Cells[3].Value.ToString());
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow linha = dtGridCursos.Rows[LinhaSelecionada];

            linha.Cells[0].Value = numId.Value;
            linha.Cells[1].Value = txtNome.Text;
            linha.Cells[2].Value = txtTurno.Text;
            linha.Cells[3].Value = chkAtivo.Checked;
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            CursosEntidade cursos = new CursosEntidade();
            cursos.Id = Convert.ToInt32(numId.Value);
            cursos.Nome = txtNome.Text;
            cursos.Turno = txtTurno.Text;
            cursos.Ativo = chkAtivo.Checked;

            dados.Rows.Add(cursos.Linha());

            Comandos c = new Comandos();
            List<object[]> Inputs = new List<object[]>();
            Inputs.Add(new object[] { numId, "num" });
            Inputs.Add(new object[] { txtNome, "txt" });
            Inputs.Add(new object[] { txtTurno, "txt" });
            Inputs.Add(new object[] { chkAtivo, "chk" });

            c.ClearInsertForm(Inputs);
        }
    }
}
