using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlDeCalidad.AccesoADatos.Persistencia;
using ControlDeCalidad.Dominio;

namespace ControlDeCalidad.AccesoADatos.Servicios
{
    public class LineaTrabajoServicio
    {
        private EmpleadoServicio empleadoServicio=new EmpleadoServicio();
        public void CargarLineasDeTrabajo()
        {   


            var empresa = Singleton.getInstancia().ObtenerDatosDeEmpresa();
            empresa.ListaDeLineasDeTrabajo.Add
            (
                new LineaTrabajo()
                {
                    Numero = 100,
                    Nombre = "Linea Trabajo 100",
                    SupervisorDeLinea = empleadoServicio.BuscarEmpleadoPorId(1)
                }
            );
            empresa.ListaDeLineasDeTrabajo.Add
            (
                new LineaTrabajo()
                {
                    Numero = 101,
                    Nombre = "Linea Trabajo 101"
                    
                }
            );
            empresa.ListaDeLineasDeTrabajo.Add
            (
                new LineaTrabajo()
                {
                    Numero = 102,
                    Nombre = "Linea Trabajo 102"
                }
            );
            empresa.ListaDeLineasDeTrabajo.Add
            (
                new LineaTrabajo()
                {
                    Numero = 103,
                    Nombre = "Linea Trabajo 103"
                }
            );
            empresa.ListaDeLineasDeTrabajo.Add
            (
                new LineaTrabajo()
                {
                    Numero = 104,
                    Nombre = "Linea Trabajo 104",
                    SupervisorDeLinea = empleadoServicio.BuscarEmpleadoPorId(4)
                }
            );
            empresa.ListaDeLineasDeTrabajo.Add
            (
                new LineaTrabajo()
                {
                    Numero = 105,
                    Nombre = "Linea Trabajo 105",
                    SupervisorDeLinea = empleadoServicio.BuscarEmpleadoPorId(4)
                }
            );
            Singleton.getInstancia().AsignarDatosAEmpresa(empresa);
        }

        public LineaTrabajo ObtenerLineaTrabajoPorId(int numero)
        {
            var empresa = Singleton.getInstancia().ObtenerDatosDeEmpresa();
            return empresa.ListaDeLineasDeTrabajo.Where(x => x.Numero == numero).FirstOrDefault();
        }
        public List<LineaTrabajo> ObtenerLineasTrabajoSinEmpleado()
        {
            var empresa = Singleton.getInstancia().ObtenerDatosDeEmpresa();
            return empresa.ListaDeLineasDeTrabajo.Where(y => y.SupervisorDeLinea == null).ToList();// no lo hace 
            
            //return empresa.ListaDeLineasDeTrabajo.Where(y => y.Empleado == null).OrderBy(x => x.Numero).ToList();
        }
        public void AgregarLineaTrabajo(LineaTrabajo lineaTrabajo)
        {
            Singleton.getInstancia().ObtenerDatosDeEmpresa().ListaDeLineasDeTrabajo.Add(lineaTrabajo);
        }
        public void ModificarLineaTrabajo(LineaTrabajo lineaTrabajo)
        {
            EliminarLineaTrabajo(lineaTrabajo);
            AgregarLineaTrabajo(lineaTrabajo);
        }

        public void EliminarLineaTrabajo(LineaTrabajo lineaTrabajo)
        {
            Singleton.getInstancia().ObtenerDatosDeEmpresa().ListaDeLineasDeTrabajo.RemoveAll(x => x.Numero == lineaTrabajo.Numero);
        }
    }
}
