using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlDeCalidad.AccesoADatos.Servicios;
using ControlDeCalidad.Dominio;
using ControlDeCalidad.Presentacion.Interfaces;

namespace ControlDeCalidad.Presentacion.Presentadores
{
    class LogueoFormPresentador
    {
        private UsuarioServicio usuarioServicio = new UsuarioServicio();
        private ILogueoForm _iLogueoForm;

        public LogueoFormPresentador(ILogueoForm interfazLogueForm)
        {
            _iLogueoForm = interfazLogueForm;
        }

        public void ComprobarLogueo(string nombre, string contrasena)
        {
            var condicion = usuarioServicio.ComprobarLogueo(nombre, contrasena);
            if (condicion == true)
            {
                _iLogueoForm.MostrarMensaje("Bienvenido: " + nombre, false);
            }
            else
            {
                _iLogueoForm.MostrarMensaje("Usuario o contraseña incorrecta. Intente nuevamente.", true);
            }
        }
    }
}
