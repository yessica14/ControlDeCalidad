using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Presentacion.Interfaces
{
    interface ILogueoForm
    {
        void MostrarMensaje(string mensaje, bool conError);
    }
}
