﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using ControlDeCalidad.AccesoADatos.Persistencia;
using ControlDeCalidad.Dominio;

namespace ControlDeCalidad.AccesoADatos.Servicios
{
    public class EmpleadoServicio
    {
        public void CargarEmpleados()
        {
            var empresa = Singleton.getInstancia().ObtenerDatosDeEmpresa();
            empresa.ListaDeEmpleados.Add(
                new Empleado()
                {
                    Id = 1,
                    Apellido = "Gimenez",
                    Nombre = "Yessica",
                    Documento = 33000111,
                    CorreoElectronico = "gy@gmail.com"
                }
            );
            empresa.ListaDeEmpleados.Add(
                new Empleado()
                {
                    Id = 2,
                    Apellido = "Gramajo",
                    Nombre = "Jessica",
                    Documento = 30111222,
                    CorreoElectronico = "gnj@gmail.com"
                }
            );
            empresa.ListaDeEmpleados.Add(
                new Empleado()
                {
                    Id = 3,
                    Apellido = "Zampa",
                    Nombre = "Cristina",
                    Documento = 37333444,
                    CorreoElectronico = "zgc@gmail.com"
                }
            );
            empresa.ListaDeEmpleados.Add(
                new Empleado()
                {
                    Id = 4,
                    Apellido = "Aguilar",
                    Nombre = "David",
                    Documento = 5487655,
                    CorreoElectronico = "gy@gmail.com"
                }
            );
            Singleton.getInstancia().AsignarDatosAEmpresa(empresa);
        }

        public Empleado BuscarEmpleadoPorId(int id)
        {
            var empresa = Singleton.getInstancia().ObtenerDatosDeEmpresa();

            foreach (var item in empresa.ListaDeEmpleados)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            
            var empleado = empresa.ListaDeEmpleados.Where(x => x.Id == id).FirstOrDefault();
            return (empleado);
        }

        public List<Empleado> BuscarEmpleadosPorApellido(string ape)
        {
            var empresa = Singleton.getInstancia().ObtenerDatosDeEmpresa();
            var empleado = empresa.ListaDeEmpleados.Where(x => x.Apellido == ape).ToList();
            return (empleado);
        }
    }
}
