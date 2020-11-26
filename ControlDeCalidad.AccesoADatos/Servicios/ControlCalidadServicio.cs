using ControlDeCalidad.AccesoADatos.Persistencia;
using ControlDeCalidad.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.AccesoADatos.Servicios
{
    public class ControlCalidadServicio
    {
        private ControlCalidad empresa = Singleton.getInstancia().ObtenerDatosDeEmpresa();
        private EmpleadoServicio empleadoServicio = new EmpleadoServicio();
        private UsuarioServicio usuarioServicio = new UsuarioServicio();
        private ColorServicio colorServicio = new ColorServicio();
        private ModeloServicio modeloServicio = new ModeloServicio();
        private LineaTrabajoServicio lineaTrabajoServicio = new LineaTrabajoServicio();
        private OrdenProduccionServicio ordenProduccionServicio = new OrdenProduccionServicio();
        private DefectoServicio defectoServicio = new DefectoServicio();
        private TurnoServicios turnoServicio = new TurnoServicios();
        
        public void GenerarDatosAutomaticamente()
        {
            empleadoServicio.CargarEmpleados();
            usuarioServicio.CargarUsuarios();
            colorServicio.CargarColores();
            modeloServicio.CargarModelos();
            lineaTrabajoServicio.CargarLineasDeTrabajo();
            ordenProduccionServicio.CargarOrdenesProduccionServicio();
            defectoServicio.CargarDefectos();
            turnoServicio.CargarTurnos();
           
            
            

        }
    }
}
