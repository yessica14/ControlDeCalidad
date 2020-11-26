using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlDeCalidad.AccesoADatos.Servicios;
using ControlDeCalidad.Dominio;
using ControlDeCalidad.Presentacion.Interfaces;
using ControlDeCalidad.Presentacion.Vistas;

namespace ControlDeCalidad.Presentacion.Presentadores
{
    public class ColorABMPresentador
    {
        private IColorABM interfaz;
        private ColorServicio colorServicio = new ColorServicio();

        public ColorABMPresentador(IColorABM _interfaz)
        {
            interfaz = _interfaz;
        }

        public void ObtenerUltimoId()
        {
            var id = colorServicio.ObtenerUltimoId();
            interfaz.MostrarUltimoId(id);
        }

        public void AgregarModificarEliminarColor(ColorCalzado color, TipoOperacionForm tipoOperacion)
        {
            if (color.Descripcion == "")
            {
                interfaz.MostrarMensaje("Datos requeridos: Descripcion.", true);
            }
            else
            {
                switch (tipoOperacion)
                {
                    case TipoOperacionForm.ALTA:
                        color.Codigo = colorServicio.ObtenerUltimoId();
                        colorServicio.AgregarColor(color);
                        break;
                    case TipoOperacionForm.MODIFICACION:
                        colorServicio.ModificarColor(color);
                        break;
                    case TipoOperacionForm.BAJA:
                        colorServicio.EliminarColor(color);
                        break;
                }
                interfaz.CerrarVentana();
            }
        }
    }
}
