using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Dominio
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
        public Empleado UsuarioDeEmpleado { get; set; }

        public TipoUsuario TipoUsuario { get; set; }
    }
}
