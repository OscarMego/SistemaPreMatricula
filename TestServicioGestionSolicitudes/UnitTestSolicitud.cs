using System;
using System.ServiceModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestServicioGestionSolicitudes.SolicitudWS;

namespace TestServicioGestionSolicitudes
{
    [TestClass]
    public class UnitTestSolicitud
    {
        [TestMethod]
        public void TestMethodCrearSolicitud()
        {
            DateTime fecSolicitud = new DateTime(2019, 4, 7);
            SolicitudServiceClient solicitudService = new SolicitudServiceClient();
            Solicitud solicitud = new Solicitud()
            {
                NroDniAlumno = "44553322",
                IdNivel = 3,
                Tipo = "Antiguo",
                Estado = "Pendiente",
                FechaSolicitud = fecSolicitud
            };
            Solicitud solicitudCreado = solicitudService.Crear(solicitud);
            Assert.AreEqual("44553322", solicitudCreado.NroDniAlumno);
            Assert.AreEqual("66553322", solicitudCreado.NroDniApoderado);
            Assert.AreEqual(3, solicitudCreado.IdNivel);
            Assert.AreEqual("Antiguo", solicitudCreado.Tipo);
            Assert.AreEqual("Pendiente", solicitudCreado.Estado);
            Assert.AreEqual(fecSolicitud.Date, solicitud.FechaSolicitud.Date);
        }
        [TestMethod]
        public void TestMethodObtenerSolicitud()
        {
            DateTime fecSolicitud = new DateTime(2019, 4, 7);
            SolicitudServiceClient solicitudService = new SolicitudServiceClient();
            Solicitud solicitud = solicitudService.Obtener(0, "44553322");
            Assert.AreEqual("44553322", solicitud.NroDniAlumno);
            Assert.AreEqual("66553322", solicitud.NroDniApoderado);
            Assert.AreEqual(3, solicitud.IdNivel);
            Assert.AreEqual("Antiguo", solicitud.Tipo);
            Assert.AreEqual("Pendiente", solicitud.Estado);
            Assert.AreEqual(fecSolicitud.Date, solicitud.FechaSolicitud.Date);
        }
        [TestMethod]
        public void TestMethodCrearSolicitudDniReptido()
        {
            try
            {
                DateTime fecSolicitud = DateTime.Now.Date;
                SolicitudServiceClient solicitudService = new SolicitudServiceClient();
                Solicitud solicitud = new Solicitud()
                {
                    NroDniAlumno = "44553322",
                    NroDniApoderado = "66553322",
                    IdNivel = 3,
                    Tipo = "Antiguo",
                    Estado = "Pendiente",
                    FechaSolicitud = fecSolicitud
                };
                Solicitud solicitudCreado = solicitudService.Crear(solicitud);
            }
            catch (FaultException<ManejadorException> error)
            {
                Assert.AreEqual("Error al intentar crear solicitud", error.Reason.ToString());
                Assert.AreEqual("101", error.Detail.Codigo);
                Assert.AreEqual("DNI del alumno ya se encuentra registrado", error.Detail.Descripcion);
            }
        }
        [TestMethod]
        public void TestMethodModificarSolicitud()
        {
            DateTime fecSolicitud = new DateTime(2019, 4, 7);
            DateTime fecRpta = new DateTime(2019, 4, 7);
            DateTime fecCita = new DateTime(2019, 4, 10);
            SolicitudServiceClient solicitudService = new SolicitudServiceClient();
            Solicitud solicitud = solicitudService.Obtener(0, "44553322");
            solicitud.Estado = "Citado";
            solicitud.FechaCita = fecCita;
            solicitud.FechaRespuesta = fecRpta;
            solicitud.Observaciones = "Ninguno";
            Solicitud solicitudCreado = solicitudService.Modificar(solicitud);
            Assert.AreEqual("44553322", solicitudCreado.NroDniAlumno);
            Assert.AreEqual("66553322", solicitudCreado.NroDniApoderado);
            Assert.AreEqual(3, solicitudCreado.IdNivel);
            Assert.AreEqual("Antiguo", solicitudCreado.Tipo);
            Assert.AreEqual("Citado", solicitudCreado.Estado);
            Assert.AreEqual(fecSolicitud.Date, solicitud.FechaSolicitud.Date);
            Assert.AreEqual(fecRpta.Date, solicitud.FechaRespuesta.Date);
            Assert.AreEqual(fecCita.Date, solicitud.FechaCita.Date);
            Assert.AreEqual("Ninguno", solicitudCreado.Observaciones);
        }
    }
}
