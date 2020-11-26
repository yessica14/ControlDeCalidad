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
    class ModeloABMPresentador
    {
        private IModeloABM interfaz;
        private ModeloServicio modeloServicio = new ModeloServicio();
        private ColorServicio colorServicio = new ColorServicio();

        public ModeloABMPresentador(IModeloABM _interfaz)
        {
            interfaz = _interfaz;
        }

        public void ObtenerColores()
        {
            var lista = colorServicio.ObtenerTodosLosColores();
            interfaz.MostrarColores(lista);
        }

        public void ObtenerUltimoSku()
        {
            var id = modeloServicio.ObtenerUltimoSku();
            interfaz.MostrarUltimoSku(id);
        }

        public void AgregarModificarEliminarModelo(Modelo modelo, TipoOperacionForm tipoOperacion)
        {
            switch(tipoOperacion)
            {
                case TipoOperacionForm.ALTA:
                    modeloServicio.AgregarModelo(modelo);
                    break;
                case TipoOperacionForm.BAJA:
                    modeloServicio.EliminarModelo(modelo);
                    break;
                case TipoOperacionForm.MODIFICACION:
                    modeloServicio.ModificarModelo(modelo);
                    break;
            }

        } 
       

    }
}
