using ControlDeCalidad.AccesoADatos.Persistencia;
using ControlDeCalidad.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.AccesoADatos.Servicios
{
    public class ModeloServicio
    {
        private ColorServicio colorServicio = new ColorServicio();
        public void CargarModelos()
        {
            var empresa= Singleton.getInstancia().ObtenerDatosDeEmpresa();
            empresa.ListaDeModelos.Add(
                new Modelo()
                {
                   Sku = 1400,
                   Denominacion = "zapatilla nine",
                   Objetivo = 30,
                    ColorDeModelo = colorServicio.ObtenerColorPorId(800)
                }
            );
            empresa.ListaDeModelos.Add(
               new Modelo()
               {
                   Sku = 1401,
                   Denominacion = "zapato nine",
                   Objetivo = 40,
                   ColorDeModelo = colorServicio.ObtenerColorPorId(801)
               }
           );
            empresa.ListaDeModelos.Add(
               new Modelo()
               {
                   Sku = 1402,
                   Denominacion = "zapatilla adidas",
                   Objetivo = 50,
                   ColorDeModelo = colorServicio.ObtenerColorPorId(802)
               }
           );
           Singleton.getInstancia().AsignarDatosAEmpresa(empresa);
        }

        public int ObtenerUltimoSku()
        {
            var empresa = Singleton.getInstancia().ObtenerDatosDeEmpresa();

            Modelo modelo = empresa.ListaDeModelos.OrderByDescending(x => x.Sku).FirstOrDefault();
            int sku = modelo.Sku;
            return sku + 1;
        }

        public Modelo ObtenerModeloPorSku(int sku)
        {
            var empresa = Singleton.getInstancia().ObtenerDatosDeEmpresa();
            var modelo = empresa.ListaDeModelos.Where(x => x.Sku == sku).FirstOrDefault();
            return modelo;
        }

        public List<Modelo> ObtenerTodosLosModelos()
        {
            var empresa = Singleton.getInstancia().ObtenerDatosDeEmpresa();
            return empresa.ListaDeModelos.OrderBy(x => x.Denominacion).ToList();
        }

        public void AgregarModelo(Modelo modelo)
        {
            Singleton.getInstancia().ObtenerDatosDeEmpresa().ListaDeModelos.Add(modelo);
        }

        public void ModificarModelo(Modelo modelo)
        {
            EliminarModelo(modelo);
            AgregarModelo(modelo);
        }

        public void EliminarModelo(Modelo modelo)
        {
            var empresa = Singleton.getInstancia().ObtenerDatosDeEmpresa();
            empresa.ListaDeModelos.RemoveAll(x => x.Sku == modelo.Sku);
        }

    }
}
