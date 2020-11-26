using ControlDeCalidad.Presentacion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Presentacion.Presentadores
{

    class ListaLineaTrabajoPresentador
    {
        private IListaLineaTrabajo interfaz;

        public ListaLineaTrabajoPresentador(IListaLineaTrabajo _interfaz)
        {
            interfaz = _interfaz;
        }

        
    }

}
