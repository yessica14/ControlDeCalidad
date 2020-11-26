using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Dominio
{
    public class LineaTrabajo
    {
        public int Numero { get; set; }
        public string Nombre { get; set; }
        public Empleado SupervisorDeLinea { get; set; }

        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
