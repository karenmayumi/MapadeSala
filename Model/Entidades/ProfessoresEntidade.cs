using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model.Entidades
{
    public class ProfessoresEntidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public object[] Linha()
        {
            return new object[] { Id, Nome, Apelido };
        }
        public void LimparCampos(List<object[]> Inputs)
        {

                foreach (object[] Item in Inputs)
                {
                switch (Item[1].ToString())
                {
                    case "txt":
                        ((TextBox)Item[0]).Text = "";
                        break;
                    case "chk":
                        ((CheckBox)Item[0]).Checked = false;
                        break;
                    case "num":
                        ((NumericUpDown)Item[0]).Value = 0;
                        break;
                    default:
                        MessageBox.Show("Erro!! Tem um inset diferente das opções. Ajeite no código!!");
                        break;
                }
            }
        }
    }
}
