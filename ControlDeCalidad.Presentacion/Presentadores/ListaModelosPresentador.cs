using ControlDeCalidad.AccesoADatos.Servicios;
using ControlDeCalidad.Presentacion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Presentacion.Presentadores
{
    public class ListaModelosPresentador
    {
        private IListaModelos interfaz;
        private ModeloServicio modeloServicio = new ModeloServicio();


        public ListaModelosPresentador(IListaModelos _interfaz)
        {
            interfaz = _interfaz;
        }

        public void ObtenerListaModelos()
        {
            var lista =  modeloServicio.ObtenerTodosLosModelos();
            interfaz.MostrarTodosLosModelos(lista);

        }
    }
}
