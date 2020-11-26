using ControlDeCalidad.AccesoADatos.Persistencia;
using ControlDeCalidad.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.AccesoADatos.Servicios
{
    public class TurnoServicios
    {
        public void CargarTurnos()
        {
            var empresa = Singleton.getInstancia().ObtenerDatosDeEmpresa();

            empresa.ListaDeTurnos.Add
            ( 
                new Turno()
                {
                    Codigo = 100,
                    Nombre = "Mañana",
                    HoraInicio = new TimeSpan(6,0,0),
                    HoraFin = new TimeSpan(12,59,59)
                }
            );
            empresa.ListaDeTurnos.Add
           (
               new Turno()
               {
                   Codigo = 101,
                   Nombre = "Tarde",
                   HoraInicio = new TimeSpan(13, 0, 0),
                   HoraFin = new TimeSpan(18, 59, 59)
               }
           );
            empresa.ListaDeTurnos.Add
           (
               new Turno()
               {
                   Codigo = 102,
                   Nombre = "Noche",
                   HoraInicio = new TimeSpan(19, 0, 0),
                   HoraFin = new TimeSpan(23, 59, 59)
               }
           );
 
        }

        public Turno ObtenerTurnoPorId(int codigo)
        {
            return Singleton.getInstancia().ObtenerDatosDeEmpresa().ListaDeTurnos.Where(x => x.Codigo == codigo).FirstOrDefault();
        }

        public Turno ObtenerTurnoSegunUnaHoraEspecifica(int hora)
        {
            var empresa = Singleton.getInstancia().ObtenerDatosDeEmpresa();
            var turno =empresa.ListaDeTurnos.Where(x => x.HoraInicio.Hours <= hora && x.HoraFin.Hours >= hora).FirstOrDefault();
            return turno;
        }
    }
}
