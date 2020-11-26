using ControlDeCalidad.AccesoADatos.Servicios;
using ControlDeCalidad.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Presentacion.Interfaces
{
    public interface IOrdenProduccionABM
    {
        void MostrarLineasTrabajoNOpModelos(List<LineaTrabajo> listaLineas, int numeroOp, List<Modelo> listaModelos);
        void MostrarMensaje(string texto, bool esError);
        //void ObtenerEmpleado(Empleado empleado);
        void CerrarVentana();

        /*
        void MostrarLineasTrabajo(List<LineaTrabajo> lista);
        void MostrarNumeroOrdenProduccion(int id);
        */
    }
}
