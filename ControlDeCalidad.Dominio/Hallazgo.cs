using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Dominio
{
    public class Hallazgo
    {
        public TimeSpan? HoraHallazgo { get; set; }
        public Pie PieDeCalzado { get; set; }
        public Defecto DefectoDeCalzado { get; set; }
        public TipoAprobado? AprobadoDeCalzado {get; set; }

    }
}
