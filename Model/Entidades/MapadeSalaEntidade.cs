using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entidades
{
    class MapadeSalaEntidade
    {
        public int Id { get; set; }
        public string Sala { get; set; }
        public string Horario { get; set; }
        public string DiaDaSemana { get; set; }
        public string CursoPeriodoDisciplina { get; set; }
        public string Professor { get; set; }
        public object[] Linha()
        {
            return new object[] { Id, Sala, Horario, DiaDaSemana, CursoPeriodoDisciplina, Professor};
        }
    }
}
