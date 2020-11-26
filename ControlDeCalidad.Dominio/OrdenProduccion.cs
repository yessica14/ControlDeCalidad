using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Dominio
{
    public class OrdenProduccion
    {
        public int Numero { get; set; }
        public LineaTrabajo LineaTrabajo{ get; set; }
        public EstadoOrdenProduccion EstadoOrdenProduccion{ get; set; }
        public Modelo Modelo { get; set; }
        public List<Hallazgo> ListaDeCalzado { get; set; }
        public List<DuracionOrdenProduccion> DuracionOrdenDeProduccion { get; set; }
        public Empleado SupervisorCalidad { get; set; }

    }
}
