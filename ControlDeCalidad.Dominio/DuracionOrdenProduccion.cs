using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Dominio
{
    public class DuracionOrdenProduccion
    {
        public int HoraInicio { get; set; }
        public int HoraFin { get; set; }
        public Turno Turno  { get; set; }

       
    }
}
