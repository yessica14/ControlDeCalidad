using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlDeCalidad.Dominio;

namespace ControlDeCalidad.Presentacion.Interfaces
{
    public interface IListaColores
    {
        void MostrarListaDeColores(List<ColorCalzado> lista);
    }
}
