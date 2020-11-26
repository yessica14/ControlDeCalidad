using ControlDeCalidad.AccesoADatos.Servicios;
using ControlDeCalidad.Dominio;
using ControlDeCalidad.Presentacion.Interfaces;
using ControlDeCalidad.Presentacion.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace ControlDeCalidad.Presentacion.Presentadores
{
    public class RegistrarDefectoPresentador
    {
        private IRegistrarDefecto interfaz;
        private DefectoServicio defectoServicio = new DefectoServicio();
        private Defecto defecto = new Defecto();
        private OrdenProduccionServicio ordenProduccionServicio = new OrdenProduccionServicio();

        public RegistrarDefectoPresentador(IRegistrarDefecto _interfaz)
        {
            interfaz = _interfaz;
        }

       

        public void ObtenerDefectos() {
            var lista = defectoServicio.ObtenerTodosLosDefectos() ;
            interfaz.MostrarDefectosDelPieDerecho(lista);
        }
        public void ObtenerOrdenProduccion()
        {
            var ordenProduccion = ordenProduccionServicio.ObtenerOrdenProduccionActual();
            if (ordenProduccion == null)
            {
                interfaz.MostrarMensaje("Usted no posee ninguna orden de orden de produccion", true);
                interfaz.CerrarVentana();
                return;
            }
            else
            {
                int parActual = 1;
                int indice = 0;
                for (int i = 0; i < ordenProduccion.ListaDeCalzado.Count(); i = i + 2)
                {
                    if (ordenProduccion.ListaDeCalzado[i].AprobadoDeCalzado == null && ordenProduccion.ListaDeCalzado[i].DefectoDeCalzado == null)
                    {
                        indice = i;
                        break;
                    }
                    parActual = parActual + 1;
                }

                var calzadoIzq = ordenProduccion.ListaDeCalzado[indice];
                var calzadoDer = ordenProduccion.ListaDeCalzado[indice + 1];

                interfaz.MostrarOrdenProduccion(ordenProduccion, indice, calzadoIzq, calzadoDer, parActual);
            }
            
        }
        public void RegistrarAprobadosODefectos(OrdenProduccion ordenProduccion, bool AprobadoIzq, Defecto DefectosIzq, string TipoDeDefectoIzq, bool AprobadoDer, Defecto DefectosDer, string TipoDeDefectoDer, int _indice)
        {
            if(AprobadoIzq == true)
            {
                ordenProduccion.ListaDeCalzado[_indice].AprobadoDeCalzado = TipoAprobado.ParaHermanar;
            }
            else
            {
                ordenProduccion.ListaDeCalzado[_indice].DefectoDeCalzado = DefectosIzq;
                
                if (TipoDeDefectoIzq == "Observado")
                {
                    ordenProduccion.ListaDeCalzado[_indice].DefectoDeCalzado.TipoDeDefecto = TipoDefecto.Observado;
                }
                {
                    ordenProduccion.ListaDeCalzado[_indice].DefectoDeCalzado.TipoDeDefecto = TipoDefecto.Reproceso;
                }

            }
           // -------------
            if (AprobadoDer == true)
            {
                ordenProduccion.ListaDeCalzado[_indice+1].AprobadoDeCalzado = TipoAprobado.ParaHermanar;
            }
            else
            {
                ordenProduccion.ListaDeCalzado[_indice+1].DefectoDeCalzado = DefectosDer;

                if (TipoDeDefectoDer == "Observado")
                {
                    ordenProduccion.ListaDeCalzado[_indice+1].DefectoDeCalzado.TipoDeDefecto = TipoDefecto.Observado;
                }
                {
                    ordenProduccion.ListaDeCalzado[_indice+1].DefectoDeCalzado.TipoDeDefecto = TipoDefecto.Reproceso;
                }
            }

            if(AprobadoIzq == true && AprobadoDer == true)
            {
                ordenProduccion.ListaDeCalzado[_indice].AprobadoDeCalzado = TipoAprobado.Hermanado;
                ordenProduccion.ListaDeCalzado[_indice + 1].AprobadoDeCalzado = TipoAprobado.Hermanado;
            }
            ordenProduccion.ListaDeCalzado[_indice].HoradelRevisado = DateTime.Now.TimeOfDay;
            ordenProduccion.ListaDeCalzado[_indice+1].HoradelRevisado = DateTime.Now.TimeOfDay;

            ordenProduccionServicio.ModificarOrdenProduccion(ordenProduccion);
            interfaz.RecargarVentana();

        }

    }
}
