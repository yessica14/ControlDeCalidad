using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlDeCalidad.AccesoADatos.Servicios;
using ControlDeCalidad.Dominio;
using ControlDeCalidad.Presentacion.Interfaces;

namespace ControlDeCalidad.Presentacion.Presentadores
{
    public class OrdenProduccionABMPresentador
    {
        private IOrdenProduccionABM interfaz;
        private LineaTrabajoServicio lineaTrabajoServicio = new LineaTrabajoServicio();
        private OrdenProduccionServicio ordenProduccionServicio = new OrdenProduccionServicio();
        private ModeloServicio modeloServicio = new ModeloServicio();
        private EmpleadoServicio empleadoServicio = new EmpleadoServicio();
        private UsuarioServicio usuarioServicio = new UsuarioServicio();
        private TurnoServicios turnoServicios = new TurnoServicios();

        public OrdenProduccionABMPresentador(IOrdenProduccionABM _interfaz)
        {
            interfaz = _interfaz;
        }

        public void ObtenerLineasTrabajoNOpModelos()
        {
            var listaLineas = lineaTrabajoServicio.ObtenerLineasTrabajoSinEmpleado();
            var numeroOP = ordenProduccionServicio.ObtenerUltimoId();
            var listaModelos = modeloServicio.ObtenerTodosLosModelos();
            interfaz.MostrarLineasTrabajoNOpModelos(listaLineas, numeroOP, listaModelos);
        }
        /*
        public void ObtenerLineasTrabajo()
        {
            var lista = lineaTrabajoServicio.ObtenerTodosLasLineasTrabajo();
            interfaz.MostrarLineasTrabajo(lista);

        }
        public void ObtenerIdOrdenProduccion()
        {
            var id= ordenProduccionServicio.ObtenerUltimoId();
            interfaz.MostrarNumeroOrdenProduccion(id);
        }
        */
        public void CrearOrdenProduccionyActualizarLineaTrabajo(string pares, LineaTrabajo lineaTrabajo, Modelo modelo)
        {
            if (!int.TryParse(pares, out int number))  // pregunta si no se puede convertir a int. tryparse trata de convertir//esto es en caso de quie el usuario tipee letras en vez de numeros
            {
                interfaz.MostrarMensaje("Indique la cantidad de pares", true);
                return;
            }

            if (int.Parse(pares) <= 0)  // pregunta si no se puede convertir a int. tryparse trata de pasar
            {
                interfaz.MostrarMensaje("la cantidad de pares tienen que ser mayores que cero", true);
                return;
            }

            var usuarioSesion = usuarioServicio.ObtenerUsuarioDeSession();
            lineaTrabajo.SupervisorDeLinea = usuarioSesion.UsuarioDeEmpleado;
            lineaTrabajoServicio.ModificarLineaTrabajo(lineaTrabajo);

            var ordenProduccion = new OrdenProduccion();
            ordenProduccion.LineaTrabajo = lineaTrabajo;
            ordenProduccion.Numero = ordenProduccionServicio.ObtenerUltimoId();
            ordenProduccion.EstadoOrdenProduccion = EstadoOrdenProduccion.Inicio;
            ordenProduccion.Modelo = modelo;
            
            int cantPares = int.Parse(pares);   //2
            ordenProduccion.ListaDeCalzado = new List<Hallazgo>();

            for (int i = 1; i <= cantPares; i++)
            {
                var CalzadoIzq = new Hallazgo()
                {
                    PieDeCalzado = Pie.Izquierdo
                };
                ordenProduccion.ListaDeCalzado.Add(CalzadoIzq);

                var CalzadoDer = new Hallazgo()
                {
                    PieDeCalzado = Pie.Derecho
                };
                ordenProduccion.ListaDeCalzado.Add(CalzadoDer);
            }

            var listaDOP = new List<DuracionOrdenProduccion>();

            listaDOP.Add
            (
                new DuracionOrdenProduccion()
                {
                    HoraInicio = DateTime.Now.Hour,
                    Turno = turnoServicios.ObtenerTurnoSegunUnaHoraEspecifica(DateTime.Now.Hour)                   
                }
            );

            ordenProduccion.DuracionOrdenDeProduccion = listaDOP;
            ordenProduccion.EstadoOrdenProduccion = EstadoOrdenProduccion.Inicio;

            ordenProduccionServicio.AgregarOrdenproduccion(ordenProduccion);
            interfaz.CerrarVentana();
        }
        public void ActualizarEstadoOrdenProduccion(string txtEstado, OrdenProduccion ordenProduccion)
        {
            switch (txtEstado)
            {
                case "Pausado":
                    ordenProduccion.EstadoOrdenProduccion = EstadoOrdenProduccion.Pausado;
                    break;
                case "Continuado":
                    ordenProduccion.EstadoOrdenProduccion = EstadoOrdenProduccion.Continuado;
                    break;
                case "Finalizado":
                    ordenProduccion.EstadoOrdenProduccion = EstadoOrdenProduccion.Finalizado;
                    break;
            }
            ordenProduccionServicio.ModificarOrdenProduccion(ordenProduccion);
            interfaz.CerrarVentana();
            
        }



    }
}
