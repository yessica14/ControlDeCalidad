using System;
using ControlDeCalidad.AccesoADatos.Servicios;
using ControlDeCalidad.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestControlCalidad
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ComprobarLogueoDeUsuarioExitoso()
        {  
            //Planeamiento 
            var control = new ControlCalidadServicio();
            control.GenerarDatosAutomaticamente();
            var usuarioServicio = new UsuarioServicio();

            //Prueba
            bool valorEsperado = true;
            var valorDevuelto = usuarioServicio.ComprobarLogueo("aguilard","587");

            //Afirmacion
            Assert.AreEqual(valorEsperado, valorDevuelto);
        }

        [TestMethod]
        public void ComprobarUltimoIdColor()
        {
            //Planeamiento 
            var control = new ControlCalidadServicio();
            control.GenerarDatosAutomaticamente();
            var colorServicio = new ColorServicio();

            //Prueba
            var valorEsperado = 801;
            var valorDevuelto = colorServicio.ObtenerUltimoId();

            //Afirmacion
            Assert.AreEqual(valorEsperado, valorDevuelto);
        }
        [TestMethod]
        
        public void ComprobarDelModeloUltimoIDPorSku()
        {
            //Planeamiento 
            var control = new ControlCalidadServicio();
            control.GenerarDatosAutomaticamente();
            var modeloServicio = new ModeloServicio();

            //Prueba
            var valorEsperado = 1403;
            var valorDevuelto = modeloServicio.ObtenerUltimoSku();

            //Afirmacion
            Assert.AreEqual(valorEsperado, valorDevuelto);

        }
        [TestMethod]

        public void ComprobarAlmacenadoDeLineaDeTrabajo()
        {
            //Planeamiento 
            var control = new ControlCalidadServicio();
            control.GenerarDatosAutomaticamente();
            var empleadoServicio = new EmpleadoServicio();

            //Prueba
            var lineaNueva = new LineaTrabajo()
            {
                Numero = 105,
                Nombre = "Linea Trabajo 105",
                SupervisorDeLinea = empleadoServicio.BuscarEmpleadoPorId(4)
            };

            var lineaServicio = new LineaTrabajoServicio();
            lineaServicio.AgregarLineaTrabajo(lineaNueva);
            var _linea = lineaServicio.ObtenerLineaTrabajoPorId(105);

            //Afirmacion
            Assert.AreEqual($"En la {lineaNueva.Nombre} trabaja: {lineaNueva.SupervisorDeLinea.Apellido}, {lineaNueva.SupervisorDeLinea.Nombre}",
                $"En la {_linea.Nombre} trabaja: {_linea.SupervisorDeLinea.Apellido}, {_linea.SupervisorDeLinea.Nombre}");

        }
        [TestMethod]
        public void ComprobarTurnoSegunHoraEspecifica()
        {
            //Planeamiento
            var control = new ControlCalidadServicio();
            control.GenerarDatosAutomaticamente();

            //Prueba
            var Nuevoturno = new Turno()
            {
                Codigo = 102,
                Nombre = "Noche",
                HoraInicio = new TimeSpan(19, 0, 0),
                HoraFin = new TimeSpan(23, 59, 59)
            };
            
            TurnoServicios turnoServicio = new TurnoServicios();
            var HoraNueva =19;
            var _turno=turnoServicio.ObtenerTurnoSegunUnaHoraEspecifica(HoraNueva);

            Assert.AreEqual($"En el turno {Nuevoturno.Nombre} con hora {Nuevoturno.HoraInicio}", $"En el turno {_turno.Nombre} con hora {_turno.HoraInicio}" );

        }



    }
}
