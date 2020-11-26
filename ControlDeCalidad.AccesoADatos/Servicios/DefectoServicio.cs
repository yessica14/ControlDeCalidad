using ControlDeCalidad.AccesoADatos.Persistencia;
using ControlDeCalidad.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ControlDeCalidad.AccesoADatos.Servicios
{
    public class DefectoServicio
    {
       
        public void CargarDefectos()
        {
            var empresa = Singleton.getInstancia().ObtenerDatosDeEmpresa();
            empresa.ListaDeDefectos.Add
            (
                new Defecto()
                { 
                    Numero = 1,
                    Descripcion = "Mal pegado",
                   

                }
            );
          
          
            empresa.ListaDeDefectos.Add
          (
              new Defecto()
              {
                  Numero = 4,
                  Descripcion = "Suciedad",
                 

              }
          );
         
            empresa.ListaDeDefectos.Add
         (
             new Defecto()
             {
                 Numero = 6,
                 Descripcion = "Altura de Talon",
               

             }
         );
          
            empresa.ListaDeDefectos.Add
         (
             new Defecto()
             {
                 Numero = 8,
                 Descripcion = "Falla de Costura",
               

             }
         );
           
            empresa.ListaDeDefectos.Add
        (
            new Defecto()
            {
                Numero = 10,
                Descripcion = "Serigrafia",
              

            }
            
        );
            Singleton.getInstancia().AsignarDatosAEmpresa(empresa);
        }
       
        public List<Defecto> ObtenerTodosLosDefectos()
        {
            var empresa = Singleton.getInstancia().ObtenerDatosDeEmpresa();
            return empresa.ListaDeDefectos.OrderBy(x => x.Descripcion).ToList();
        }
        
    }
}
