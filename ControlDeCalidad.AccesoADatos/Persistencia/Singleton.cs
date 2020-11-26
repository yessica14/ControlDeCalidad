using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlDeCalidad.Dominio;

namespace ControlDeCalidad.AccesoADatos.Persistencia
{
    public class Singleton
    {
        public static Singleton unicaInstancia;
        private ControlCalidad Empresa = null; //123123123
        
        
        private Usuario sessionDeUsuario;

        private Singleton()
        {
            if (Empresa == null)
            {
                Empresa = new ControlCalidad();
            }
        }
        public static Singleton getInstancia()
        {
            if (unicaInstancia == null)
                unicaInstancia = new Singleton();
            return unicaInstancia;
        }
        public ControlCalidad ObtenerDatosDeEmpresa() // hace un getter
        {
            return Empresa;
        }
        public void AsignarDatosAEmpresa(ControlCalidad controlCalidad) // hace un setter
        {
            Empresa = controlCalidad;
        }

        public Usuario SessionDeUsuario
        {
            get { return sessionDeUsuario; }
            set { sessionDeUsuario = value; }
        }

    }
}
