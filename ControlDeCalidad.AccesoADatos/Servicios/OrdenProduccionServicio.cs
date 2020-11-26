using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlDeCalidad.AccesoADatos.Persistencia;
using ControlDeCalidad.Dominio;

namespace ControlDeCalidad.AccesoADatos.Servicios
{
    public class OrdenProduccionServicio
    {
        private ModeloServicio modeloServicio = new ModeloServicio();
        private LineaTrabajoServicio lineaTrabajoServicio = new LineaTrabajoServicio();
        private EmpleadoServicio empleadoServicio = new EmpleadoServicio();
        private UsuarioServicio usuarioServicio = new UsuarioServicio();
        private TurnoServicios turnoServicios = new TurnoServicios();

        public void CargarOrdenesProduccionServicio()
        {
            var empresa = Singleton.getInstancia().ObtenerDatosDeEmpresa();

            var listaCalzados = new List<Hallazgo>();
            
            listaCalzados.Add //1er par
            (
                new Hallazgo()
                {
                    //HoradelRevisado = DateTime.Now.TimeOfDay,
                    PieDeCalzado = Pie.Izquierdo,
                    AprobadoDeCalzado = TipoAprobado.Hermanado
                }
            );
            listaCalzados.Add 
            (
                new Hallazgo()
                {
                   // HoradelRevisado = DateTime.Now.TimeOfDay,
                    PieDeCalzado = Pie.Derecho,
                    AprobadoDeCalzado = TipoAprobado.Hermanado
                }
            );
            listaCalzados.Add //2do par
            (
                new Hallazgo()
                {
                   // HoradelRevisado = DateTime.Now.TimeOfDay,
                    PieDeCalzado = Pie.Izquierdo,
                    AprobadoDeCalzado = TipoAprobado.ParaHermanar
                }
            );
            listaCalzados.Add
            (
                new Hallazgo()
                {
                   // HoradelRevisado = DateTime.Now.TimeOfDay,
                    PieDeCalzado = Pie.Derecho,
                    DefectoDeCalzado = new Defecto()
                }
            );
            listaCalzados.Add //3er par
            (
                new Hallazgo()
                {
                   // HoradelRevisado = DateTime.Now.TimeOfDay,
                    PieDeCalzado = Pie.Izquierdo,
                }
            );
            listaCalzados.Add
            (
                new Hallazgo()
                {
                    // HoradelRevisado = DateTime.Now.TimeOfDay, //me indica la hora actual
                    PieDeCalzado = Pie.Derecho,
                }
            );
            listaCalzados.Add //4to par
           (
               new Hallazgo()
               {
                    //HoradelRevisado = DateTime.Now.TimeOfDay,
                    PieDeCalzado = Pie.Izquierdo,
                    // AprobadoDeCalzado = TipoAprobado.Hermanado
               }
           );
            listaCalzados.Add
            (
                new Hallazgo()
                {
                    // HoradelRevisado = DateTime.Now.TimeOfDay,
                    PieDeCalzado = Pie.Derecho,
                    // AprobadoDeCalzado = TipoAprobado.Hermanado
                }
            );
            listaCalzados.Add //5to par
           (
               new Hallazgo()
               {
                   //HoradelRevisado = DateTime.Now.TimeOfDay,
                   PieDeCalzado = Pie.Izquierdo,
                   // AprobadoDeCalzado = TipoAprobado.Hermanado
               }
           );
            listaCalzados.Add
            (
                new Hallazgo()
                {
                    // HoradelRevisado = DateTime.Now.TimeOfDay,
                    PieDeCalzado = Pie.Derecho,
                    // AprobadoDeCalzado = TipoAprobado.Hermanado
                }
            );

            empresa.ListaDeOrdenesDeProduccion.Add
            (
                new OrdenProduccion()
                {
                    Numero = 499,
                    Modelo = modeloServicio.ObtenerModeloPorSku(1401),
                    EstadoOrdenProduccion = EstadoOrdenProduccion.Finalizado,
                    LineaTrabajo = lineaTrabajoServicio.ObtenerLineaTrabajoPorId(100),
                    ListaDeCalzado = listaCalzados,
                    SupervisorCalidad = empleadoServicio.BuscarEmpleadoPorId(2)
                }
            );

            empresa.ListaDeOrdenesDeProduccion.Add
            (
                new OrdenProduccion()
                {
                    Numero = 500,
                    Modelo = modeloServicio.ObtenerModeloPorSku(1400),
                    EstadoOrdenProduccion = EstadoOrdenProduccion.Inicio,
                    LineaTrabajo = lineaTrabajoServicio.ObtenerLineaTrabajoPorId(100),
                    ListaDeCalzado = listaCalzados,
                    //SupervisorCalidad = empleadoServicio.BuscarEmpleadoPorId(2)
                }
            );
            empresa.ListaDeOrdenesDeProduccion.Add
            (
                new OrdenProduccion()
                {
                    Numero = 501,
                    Modelo = modeloServicio.ObtenerModeloPorSku(1401),
                    EstadoOrdenProduccion = EstadoOrdenProduccion.Pausado,
                    LineaTrabajo = lineaTrabajoServicio.ObtenerLineaTrabajoPorId(104),
                    ListaDeCalzado = listaCalzados
                    //EmpleadoOrdenDeProduccion = empleadoServicio.BuscarEmpleadoPorId(1)
                }
            );

            var duracionOP1 = new List<DuracionOrdenProduccion>();
            duracionOP1.Add(
                new DuracionOrdenProduccion()
                {
                    HoraInicio = 7,
                    HoraFin = 10,
                    Turno = turnoServicios.ObtenerTurnoPorId(100)
                }
            );
            duracionOP1.Add(
                new DuracionOrdenProduccion()
                {
                    HoraInicio = 11,
                    //HoraFin = 10,
                    Turno = turnoServicios.ObtenerTurnoPorId(100)
                }
            );

            empresa.ListaDeOrdenesDeProduccion.Add
            (
                new OrdenProduccion()
                {
                    Numero = 502,
                    Modelo = modeloServicio.ObtenerModeloPorSku(1402),
                    EstadoOrdenProduccion = EstadoOrdenProduccion.Inicio,
                    LineaTrabajo = lineaTrabajoServicio.ObtenerLineaTrabajoPorId(105),
                    ListaDeCalzado = listaCalzados,
                    DuracionOrdenDeProduccion = duracionOP1
                    //EmpleadoOrdenDeProduccion = empleadoServicio.BuscarEmpleadoPorId(1)
                }
            );
            //   Singleton.getInstancia().AsignarDatosAEmpresa(empresa);
        }

        public List<OrdenProduccion> ObtenerTodasLasOrdenProduccion()
        {
            var empresa = Singleton.getInstancia().ObtenerDatosDeEmpresa();
            return empresa.ListaDeOrdenesDeProduccion;
        }
        public int ObtenerUltimoId()
        {
            var empresa = Singleton.getInstancia().ObtenerDatosDeEmpresa();
            int id=empresa.ListaDeOrdenesDeProduccion.OrderByDescending(x => x.Numero).FirstOrDefault().Numero + 1;
            return id;
        }
        public void AgregarOrdenproduccion(OrdenProduccion ordenProduccion)
        {
            Singleton.getInstancia().ObtenerDatosDeEmpresa().ListaDeOrdenesDeProduccion.Add(ordenProduccion);
        }
        public OrdenProduccion BuscarOrdenDeProduccionPorId(int id)
        {
            var empresa = Singleton.getInstancia().ObtenerDatosDeEmpresa();
           
            foreach (var item in empresa.ListaDeOrdenesDeProduccion)
            {
                if (item.Numero == id)
                {
                    return item;
                }
            }

            var ordenProduccion = empresa.ListaDeOrdenesDeProduccion.Where(x => x.Numero == id).FirstOrDefault();
            return ordenProduccion;
        }
        public OrdenProduccion ObtenerOrdenProduccionActual()
        {
            var empleado = Singleton.getInstancia().SessionDeUsuario.UsuarioDeEmpleado;
            var empresa = Singleton.getInstancia().ObtenerDatosDeEmpresa();
            var ordenProduccion = empresa.ListaDeOrdenesDeProduccion.Where(x => x.SupervisorCalidad != null && x.SupervisorCalidad.Id == empleado.Id && (x.EstadoOrdenProduccion == EstadoOrdenProduccion.Inicio || x.EstadoOrdenProduccion == EstadoOrdenProduccion.Continuado)).FirstOrDefault();
            return ordenProduccion;
        }

        public List<OrdenProduccion> ObtenerOrdenesProduccionParaSupervisorCalidad()
        {
            var empleado = Singleton.getInstancia().SessionDeUsuario.UsuarioDeEmpleado;
            var empresa = Singleton.getInstancia().ObtenerDatosDeEmpresa();
            var lista = empresa.ListaDeOrdenesDeProduccion.Where(x => x.SupervisorCalidad != null && x.SupervisorCalidad.Id == empleado.Id  ).ToList();
            return lista;
        }

        public List<OrdenProduccion> ObtenerOrdenesProduccionSinSupervisorCalidad()
        {
            var empleado = Singleton.getInstancia().SessionDeUsuario.UsuarioDeEmpleado;
            var empresa = Singleton.getInstancia().ObtenerDatosDeEmpresa();
            var lista = empresa.ListaDeOrdenesDeProduccion.Where(x => x.SupervisorCalidad == null).ToList();
            return lista;
        }

        public List<OrdenProduccion> ObtenerOrdenesProduccionParaSupervisorLinea()
        {
            var empleado = Singleton.getInstancia().SessionDeUsuario.UsuarioDeEmpleado;
            var empresa = Singleton.getInstancia().ObtenerDatosDeEmpresa();
            var lista = empresa.ListaDeOrdenesDeProduccion.Where(x => x.LineaTrabajo.SupervisorDeLinea.Id == empleado.Id).ToList();
            return lista;
        }
        public void ModificarOrdenProduccion(OrdenProduccion ordenProduccion)
        {
            EliminarOrdenProduccion(ordenProduccion);
            AgregarOrdenproduccion(ordenProduccion);
        }

        public void EliminarOrdenProduccion(OrdenProduccion ordenProduccion)
        {
            Singleton.getInstancia().ObtenerDatosDeEmpresa().ListaDeOrdenesDeProduccion.RemoveAll(op => op.Numero == ordenProduccion.Numero);
        }
        //public void AsignarmUnEmpleadoYModificarEstado(List<OrdenProduccion> ordenProduccion)
        //{
        //    var empleado = Singleton.getInstancia().SessionDeUsuario.UsuarioDeEmpleado;
        //    var empresa = Singleton.getInstancia().ObtenerDatosDeEmpresa();
        //    var calzado = new OrdenProduccionServicio();

        //    foreach (var ordenProduccion1 in ordenProduccion) {
        //        empresa.ListaDeOrdenesDeProduccion.Add
        //      (
        //          new OrdenProduccion()
        //          {
        //              Numero = ordenProduccion1.Numero,
        //              Modelo = modeloServicio.ObtenerModeloPorSku(ordenProduccion1.Modelo.Sku),
        //              EstadoOrdenProduccion = EstadoOrdenProduccion.Continuado,
        //              LineaTrabajo = lineaTrabajoServicio.ObtenerLineaTrabajoPorId(ordenProduccion1.LineaTrabajo.Numero),
        //              SupervisorCalidad = empleadoServicio.BuscarEmpleadoPorId(empleado.Id)
        //          }
        //      );
        //        Singleton.getInstancia().AsignarDatosAEmpresa(empresa);
        //    }
        //}

    }


    }

