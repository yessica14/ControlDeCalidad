using ControlDeCalidad.AccesoADatos.Servicios;
using ControlDeCalidad.Presentacion.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDeCalidad.Presentacion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            ControlCalidadServicio controlCalidadServicio = new ControlCalidadServicio();
            
            controlCalidadServicio.GenerarDatosAutomaticamente();
            Application.Run(new LogueoForm()); 

            UsuarioServicio usuarioServicio = new UsuarioServicio();
            var usuarioActual = usuarioServicio.ObtenerUsuarioDeSession();
            if (usuarioActual != null)
            {
                //Application.Run(new ListaOrdenesProduccionForm());
                Application.Run(new MenuForm());
            }
            else
            {

            }
        }
    }
}
