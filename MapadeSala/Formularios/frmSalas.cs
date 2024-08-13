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
    public partial class frmSalas : Form
    {
        DataTable dados;
        int LinhaSelecionada;
        Comandos c = new Comandos();
        public frmSalas()
        {
            InitializeComponent();
            dados = new DataTable();
            foreach (var atributos in typeof(SalasEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

            dtGridSalas.DataSource = dados;
        }
        private void btnSalvar_Click(object sender, EventArgs e) //criar
        {
            SalasEntidade sala = new SalasEntidade();
            sala.Id = Convert.ToInt32(numId.Value);
            sala.Nome = txtNome.Text;
            sala.IsLab = chkIsLab.Checked;
            sala.NumCadeiras = Convert.ToInt32(numChair.Text);
            sala.NumComputadores = Convert.ToInt32(numNumPc.Value);
            sala.Disponivel = chkDisponivel.Checked;

            dados.Rows.Add(sala.Linha());

            List<object[]> Inputs = new List<object[]>();
            Inputs.Add(new object[] { numId, "num" });
            Inputs.Add(new object[] { txtNome, "txt" });
            Inputs.Add(new object[] { chkIsLab, "chk" });
            Inputs.Add(new object[] { numChair, "num" });
            Inputs.Add(new object[] { numNumPc, "num" });
            Inputs.Add(new object[] { chkDisponivel, "chk" });

            c.ClearInsertForm(Inputs);

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dtGridSalas.Rows.RemoveAt(LinhaSelecionada);
        }

        private void dtGridSalas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            numId.Value = Convert.ToInt32(dtGridSalas.Rows[LinhaSelecionada].Cells[0].Value.ToString());
            txtNome.Text = dtGridSalas.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            numNumPc.Value = Convert.ToInt32(dtGridSalas.Rows[LinhaSelecionada].Cells[2].Value.ToString());
            numChair.Value = Convert.ToInt32(dtGridSalas.Rows[LinhaSelecionada].Cells[3].Value.ToString());
            chkDisponivel.Checked = Convert.ToBoolean(dtGridSalas.Rows[LinhaSelecionada].Cells[4].Value.ToString());
            chkIsLab.Checked = Convert.ToBoolean(dtGridSalas.Rows[LinhaSelecionada].Cells[5].Value.ToString());
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow linha = dtGridSalas.Rows[LinhaSelecionada];

            linha.Cells[0].Value = numId.Value;
            linha.Cells[1].Value = txtNome.Text;
            linha.Cells[2].Value = numNumPc.Value;
            linha.Cells[3].Value = numChair.Value;
            linha.Cells[4].Value = chkDisponivel.Checked;
            linha.Cells[5].Value = chkIsLab.Checked;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //limpar campos
            Comandos c = new Comandos();
            List<object[]> Inputs = new List<object[]>();
            Inputs.Add(new object[] { numId, "num" });
            Inputs.Add(new object[] { txtNome, "txt" });
            Inputs.Add(new object[] { numNumPc, "num" });
            Inputs.Add(new object[] { numChair, "num" });
            Inputs.Add(new object[] { chkDisponivel, "chk" });
            Inputs.Add(new object[] { chkIsLab, "chk" });

            c.ClearInsertForm(Inputs);
        }
    }
}
