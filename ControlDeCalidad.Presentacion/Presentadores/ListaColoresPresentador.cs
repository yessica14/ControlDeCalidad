using ControlDeCalidad.AccesoADatos.Servicios;
using ControlDeCalidad.Presentacion.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Presentacion.Presentadores
{
    public class ListaColoresPresentador
    {
        private IListaColores interfaz;

        private ColorServicio colorServicio = new ColorServicio();

        public ListaColoresPresentador(IListaColores _interfaz)
        {
            interfaz = _interfaz;
        }

        public void ObtenerListadoColores()
        {
            var listaDeColores = colorServicio.ObtenerTodosLosColores();
            interfaz.MostrarListaDeColores(listaDeColores);
        }

    }
}
