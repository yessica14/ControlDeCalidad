using ControlDeCalidad.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Presentacion.Interfaces
{
    public interface IRegistrarDefecto
    {
       
        void MostrarDefectosDelPieDerecho(List<Defecto>lista);
        void MostrarOrdenProduccion(OrdenProduccion ordenProduccion, int indice, Hallazgo calzadoIzquierdo, Hallazgo calzadoDerecho, int parActual);
        void MostrarMensaje(string mensaje, bool esError);

        void CerrarVentana();
        void RecargarVentana();




    }
}
