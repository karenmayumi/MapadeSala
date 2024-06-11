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
        public string campos;
        

        public void ClearInsertForm(List<object[]> Inputs)
        {

            foreach(object[] Item in Inputs)
            {
                if (Convert.ToString(Item[1]) == "txt")
                {
                    ((TextBox)Input[0]).Text = "";
                }else if(Convert.ToString(Item[1]) == "chk")
                {
                    ((CheckBox)Input[0]).Checked = false;
                }else if(Convert.ToString(Item[1]) == "num")
                {
                    ((NumericUpDown)Item[0]).Value = 0;
                }
                else
                {
                    MessageBox.Show("Erro!! Tem um inset diferente das opções. Ajeite no código!!");
                }
            }

            //for(int i = 0; i = Inputs.Length; i++)
            //{

            //}

        }
    }
}
