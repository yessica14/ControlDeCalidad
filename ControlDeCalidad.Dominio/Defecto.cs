using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Dominio
{
    public class Defecto
    {
        public int Numero { get; set; }
        public string Descripcion { get; set; }
        public TipoDefecto TipoDeDefecto { get; set; }
        public override string ToString()
        {
            return this.Descripcion;
        }

    }
}
