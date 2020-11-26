using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Presentacion.Interfaces
{
    public interface IColorABM
    {
        void MostrarMensaje(string mensaje, bool conError);
        void MostrarUltimoId(int id);
        void CerrarVentana();
    }
}
