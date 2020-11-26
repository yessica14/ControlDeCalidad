using ControlDeCalidad.AccesoADatos.Persistencia;
using ControlDeCalidad.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.AccesoADatos.Servicios
{
    public class UsuarioServicio
    {
        EmpleadoServicio empleadoServicio = new EmpleadoServicio();
        public void CargarUsuarios()
        {
            var empresa = Singleton.getInstancia().ObtenerDatosDeEmpresa();
            empresa.ListaDeUsuarios.Add
            (
                new Usuario()
                {
                    Nombre = "gimenezy",
                    Contrasena = "123",
                    UsuarioDeEmpleado = empleadoServicio.BuscarEmpleadoPorId(1),
                    TipoUsuario=TipoUsuario.SupervisorDeLinea
                }
            );
            empresa.ListaDeUsuarios.Add
            (
                new Usuario()
                {
                    Nombre = "gramajoj",
                    Contrasena = "456",
                    UsuarioDeEmpleado = empleadoServicio.BuscarEmpleadoPorId(2),
                    TipoUsuario=TipoUsuario.SupervisorDeCalidad
                }
            );
            empresa.ListaDeUsuarios.Add
            (
                new Usuario()
                {
                    Nombre = "zampa",
                    Contrasena = "789",
                    UsuarioDeEmpleado = empleadoServicio.BuscarEmpleadoPorId(3),
                    TipoUsuario = TipoUsuario.Administrador
                }
            );
            empresa.ListaDeUsuarios.Add
            (
                new Usuario()
                {
                    Nombre = "aguilard",
                    Contrasena = "587",
                    UsuarioDeEmpleado = empleadoServicio.BuscarEmpleadoPorId(4),
                    TipoUsuario = TipoUsuario.SupervisorDeLinea
                }
            );
            Singleton.getInstancia().AsignarDatosAEmpresa(empresa);
        }

        public bool ComprobarLogueo(string nombre, string contrasena)
        {
            var empresa = Singleton.getInstancia().ObtenerDatosDeEmpresa();

            var usuarioLogueado = empresa.ListaDeUsuarios.Where(x => x.Nombre == nombre && x.Contrasena == contrasena).FirstOrDefault();
            
            if (usuarioLogueado != null)
            {
                Singleton.getInstancia().SessionDeUsuario = usuarioLogueado;
                return true;
            }
            
            return false;
        }

        public Usuario ObtenerUsuarioDeSession()
        {
            return Singleton.getInstancia().SessionDeUsuario;
        }

        public TipoUsuario ObtenerTipoUsuarioDeUserSession()
        {
            return Singleton.getInstancia().SessionDeUsuario.TipoUsuario;
        }

    }
}
