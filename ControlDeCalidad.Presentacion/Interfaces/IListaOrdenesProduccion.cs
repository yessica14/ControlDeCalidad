using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlDeCalidad.Dominio;

namespace ControlDeCalidad.Presentacion.Interfaces
{
    public interface IListaOrdenesProduccion
    {
        void MostrarOrdenesDeProduccionYHabilitarBotones(List<OrdenProduccion> lista, bool condicionTrabajar, bool condicionNuevaOP, bool condicionModificar);
        void MostrarMensaje(string texto, bool esError);
    }
}
