using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapadeSala.Ferramentas
{
    public class Comandos
    {
        public void ClearInsertForm(List<object[]> Inputs)
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
