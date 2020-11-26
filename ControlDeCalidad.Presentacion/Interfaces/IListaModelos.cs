using ControlDeCalidad.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Presentacion.Interfaces
{
    public interface IListaModelos
    {
        void MostrarTodosLosModelos(List<Modelo> lista);
    }
}
