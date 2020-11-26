using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Dominio
{
    public class Empleado
    {
        public int Id { get; set; }
        public int Documento { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string CorreoElectronico { get; set; }
        public Usuario Usario { get; set; }

        public override string ToString()
        {
            return this.Apellido + " " + this.Nombre;
        }
    }
}
