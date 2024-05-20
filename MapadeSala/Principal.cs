using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapadeSala
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnHelloWorld_click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world!");
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void btnHelloWorld_enter(object sender, EventArgs e)
        {
            MessageBox.Show("Entrando com o mouse no botão");

        }

        private void btn_ViewName(object sender, EventArgs e)
        {
            string nome = txt_n1.Text;
            MessageBox.Show(nome);
        }
        
        private void btn_Sum_Somar(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(txt_n1.Text);
            int n2 = Convert.ToInt32(txt_n2.Text);
            int soma = n1 + n2;
            MessageBox.Show(Convert.ToString(soma));
        }

        private void btn_Sub_Subtrair(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(txt_n1.Text);
            int n2 = Convert.ToInt32(txt_n2.Text);
            int subtracao = n1 - n2;
            MessageBox.Show(Convert.ToString(subtracao));

        }

        private void btn_Multi_Multiplicar(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(txt_n1.Text);
            int n2 = Convert.ToInt32(txt_n2.Text);
            int multiplicacao = n1 * n2;
            MessageBox.Show(Convert.ToString(multiplicacao));
        }

        private void btn_Div_Dividir(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(txt_n1.Text);
            int n2 = Convert.ToInt32(txt_n2.Text);
            int divisao = n1 / n2;
            MessageBox.Show(Convert.ToString(divisao));

        }
    }
}
