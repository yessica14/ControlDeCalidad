
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
    public class ListaOrdenesProduccionPresentador
    {
        private IListaOrdenesProduccion interfaz;
        private UsuarioServicio usuarioServicio = new UsuarioServicio();
        private OrdenProduccionServicio ordenProduccionServicio = new OrdenProduccionServicio();

        public ListaOrdenesProduccionPresentador(IListaOrdenesProduccion _interfaz)
        {
            interfaz = _interfaz;
        }

        public void ObtenerOrdenesDeProduccionYHabilitarBotones()
        {
            var tipoUsuario = usuarioServicio.ObtenerTipoUsuarioDeUserSession();

            if(tipoUsuario == TipoUsuario.SupervisorDeLinea)
            {
                var lista = ordenProduccionServicio.ObtenerOrdenesProduccionParaSupervisorLinea();
                bool btNuevo = false;
                bool btModificar = false;
                
                if (lista.Count == 0)
                {
                    btNuevo = true;
                    btModificar = false;
                    interfaz.MostrarOrdenesDeProduccionYHabilitarBotones(lista, false, btNuevo, btModificar);
                    return;
                }
                
                var lista2 = lista.Where(
                    x => x.EstadoOrdenProduccion == EstadoOrdenProduccion.Inicio
                    || x.EstadoOrdenProduccion == EstadoOrdenProduccion.Pausado
                    || x.EstadoOrdenProduccion == EstadoOrdenProduccion.Continuado).ToList();
                
                if (lista2.Count > 0)
                {
                    btNuevo = false;
                    btModificar = true;
                    interfaz.MostrarOrdenesDeProduccionYHabilitarBotones(lista, false, btNuevo, btModificar);
                    return;
                }

                var lista3 = lista.Where(
                    x => x.EstadoOrdenProduccion != EstadoOrdenProduccion.Inicio
                    || x.EstadoOrdenProduccion != EstadoOrdenProduccion.Pausado
                    || x.EstadoOrdenProduccion != EstadoOrdenProduccion.Continuado).ToList();

                if (lista3.Count > 0)
                {
                    btNuevo = true;
                    btModificar = false;
                    interfaz.MostrarOrdenesDeProduccionYHabilitarBotones(lista, false, btNuevo, btModificar);
                    return;
                }
            }
            else
            {
                if (tipoUsuario == TipoUsuario.SupervisorDeCalidad)
                {
                    var btnTrabajar = false;

                    var lista = ordenProduccionServicio.ObtenerOrdenesProduccionParaSupervisorCalidad();
                    var lista2 = lista.Where(x => x.EstadoOrdenProduccion == EstadoOrdenProduccion.Inicio
                        || x.EstadoOrdenProduccion == EstadoOrdenProduccion.Continuado).ToList();

                    if (lista2.Count > 0)
                    {
                        btnTrabajar = false;
                        interfaz.MostrarOrdenesDeProduccionYHabilitarBotones(lista, btnTrabajar, false, false);
                    }

                    else
                    {

                        var lista3 = new List<OrdenProduccion>();
                        lista3 = ordenProduccionServicio.ObtenerOrdenesProduccionSinSupervisorCalidad();
                        if (lista3.Count > 0)
                        {
                            lista.AddRange(lista3);
                            btnTrabajar = true;
                            interfaz.MostrarOrdenesDeProduccionYHabilitarBotones(lista, btnTrabajar, false, false);
                        }
                        else 
                        {
                            interfaz.MostrarOrdenesDeProduccionYHabilitarBotones(null, false, false, false);
                        }
                    }
                }
            }
        }
        public Empleado ObtenerEmpleadoSupervisorCaidad()
        {
            var usuarioSesion = usuarioServicio.ObtenerUsuarioDeSession();
            var empleado = usuarioSesion.UsuarioDeEmpleado;
            return empleado;
        }
        public void ActualizarOrdenProduccion(OrdenProduccion ordenProduccion) {
            if(ordenProduccion.SupervisorCalidad == null)
            {
                if(ordenProduccion.EstadoOrdenProduccion == EstadoOrdenProduccion.Pausado)
                {
                    ordenProduccion.EstadoOrdenProduccion = EstadoOrdenProduccion.Continuado;
                }
                var usuarioSession = usuarioServicio.ObtenerUsuarioDeSession();
                ordenProduccion.SupervisorCalidad = usuarioSession.UsuarioDeEmpleado;
                ordenProduccionServicio.ModificarOrdenProduccion(ordenProduccion);
                interfaz.MostrarMensaje("Comenzaste a trabajar en la OP", false);
            }
            else
            {
                interfaz.MostrarMensaje("No se puede trabajar sobre la OP seleccionada", true);
            }
            
        }
           
        //public void AsignarmeUnEmpleado(OrdenProduccion ordenProduccion)
        //{
        //   var lista = ordenProduccionServicio.ObtenerOrdenesProduccionSinSupervisorCalidad();
        //    var lista2 = lista.Where(x => x.Numero == ordenProduccion.Numero).ToList();
        //    ordenProduccionServicio.AsignarmUnEmpleadoYModificarEstado(lista2);

        //}
    }
}
