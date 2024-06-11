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
        BindingSource dados;
        public frmCursos()
        {
            InitializeComponent();
            dados = new BindingSource();
            dtGridSalas.DataSource = dados;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CursosEntidade cursos = new CursosEntidade();
            cursos.Id = Convert.ToInt32(numId.Value);
            cursos.Nome = txtNome.Text;
            cursos.Turno = txtTurno.Text;
            cursos.Ativo = chkAtivo.Checked;

            dados.Add(cursos);

            Comandos c = new Comandos();
            List<object[]> l = new List<object[]>();
            l.Add(new object[] { numId, "num" });
            l.Add(new object[] { txtNome, "txt" });
            l.Add(new object[] { txtTurno, "txt" });
            l.Add(new object[] { chkAtivo, "chk" });

            //Comandos c = new Comandos();
            //List<object[]> l = new List<object[]>();
            //l.Add(new object[][numId, "num"]);
            //l.Add([txtNome, "txt"]);
            //l.Add([numId, "num"]);
            //l.Add([numId, "num"]);
            c.ClearInsertForm(l);
        }
    }
}
