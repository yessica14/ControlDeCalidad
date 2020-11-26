using ControlDeCalidad.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Presentacion.Interfaces
{
    interface IModeloABM
    {
        void MostrarUltimoSku(int id);
        void MostrarColores(List<ColorCalzado> lista);
    }
}
