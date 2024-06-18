using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entidades
{
    public class DiadaSemanaEntidade
    {
        public string Dia { get; set; }
        public object[] Linha()
        {
            return new object[] { Dia };
        }
    }
}
