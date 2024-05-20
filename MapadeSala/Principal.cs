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
    }
}
