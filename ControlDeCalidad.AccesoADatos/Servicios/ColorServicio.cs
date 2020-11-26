using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlDeCalidad.AccesoADatos.Persistencia;
using ControlDeCalidad.Dominio;

namespace ControlDeCalidad.AccesoADatos.Servicios
{
    public class ColorServicio
    {
        public void CargarColores()
        {
            var empresa = Singleton.getInstancia().ObtenerDatosDeEmpresa();

            empresa.ListaDeColores.Add
            (
                new ColorCalzado()
                {
                    Codigo = 800,
                    Descripcion = "Azul"
                }
            );
            empresa.ListaDeColores.Add
            (
                new ColorCalzado()
                {
                    Codigo = 801,
                    Descripcion = "Rojo"
                }
            );
            empresa.ListaDeColores.Add
            (
                new ColorCalzado()
                {
                    Codigo = 802,
                    Descripcion = "Verde"
                }
            );
            Singleton.getInstancia().AsignarDatosAEmpresa(empresa);
        }

        public int ObtenerUltimoId()
        {

            return Singleton.getInstancia().ObtenerDatosDeEmpresa().ListaDeColores.OrderBy(x => x.Codigo).FirstOrDefault().Codigo + 1;
        }

        public ColorCalzado ObtenerColorPorId(int id)
        {
            return Singleton.getInstancia().ObtenerDatosDeEmpresa().ListaDeColores.Where(x => x.Codigo == id).FirstOrDefault();
        }

        public List<ColorCalzado> ObtenerTodosLosColores()
        {
            var empresa = Singleton.getInstancia().ObtenerDatosDeEmpresa();
            return empresa.ListaDeColores.OrderBy(x => x.Descripcion).ToList();
        }

        public void AgregarColor(ColorCalzado color)
        {
            Singleton.getInstancia().ObtenerDatosDeEmpresa().ListaDeColores.Add(color);
        }

        public void ModificarColor(ColorCalzado color)
        {
            EliminarColor(color);
            AgregarColor(color);
        }

        public void EliminarColor(ColorCalzado color)
        {
            Singleton.getInstancia().ObtenerDatosDeEmpresa().ListaDeColores.RemoveAll(_color => _color.Codigo == color.Codigo);
        }
    }
}
