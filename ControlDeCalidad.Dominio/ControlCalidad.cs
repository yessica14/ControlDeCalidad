using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Dominio
{
    public class ControlCalidad
    {
        public int CUIT{ get; set; }
        public string RazonSocial { get; set; }
        public int Telefono { get; set; }
        public Marca Marca { get; set; }
        public object ListaDuracionOrdenProduccion { get; set; }

        public List<Empleado> ListaDeEmpleados = new List<Empleado>();
        public List<Usuario> ListaDeUsuarios = new List<Usuario>();

        /*genericos*/
        public List<ColorCalzado> ListaDeColores = new List<ColorCalzado>();
        public List<Modelo> ListaDeModelos = new List<Modelo>();
        public List<LineaTrabajo> ListaDeLineasDeTrabajo = new List<LineaTrabajo>();
        public List<OrdenProduccion> ListaDeOrdenesDeProduccion = new List<OrdenProduccion>();
        public List<Defecto> ListaDeDefectos = new List<Defecto>();
        public List<Turno> ListaDeTurnos = new List<Turno>();

    }
}
