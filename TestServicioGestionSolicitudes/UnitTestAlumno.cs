using System;
using System.ServiceModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestServicioGestionSolicitudes.AlumnoWS;

namespace TestServicioGestionSolicitudes
{
    [TestClass]
    public class UnitTestAlumno
    {
        [TestMethod]
        public void TestMethodObtenerAlumno()
        {
            AlumnoWS.AlumnoServiceClient alumnoService = new AlumnoWS.AlumnoServiceClient();
            AlumnoWS.Alumno alumno = alumnoService.Obtener("44553322");
            Assert.AreEqual("44553322", alumno.DNI);
            Assert.AreEqual("66553322", alumno.NroDniApoderado);
            Assert.AreEqual("Juan", alumno.Nombres);
            Assert.AreEqual("Perez", alumno.ApellidoPaterno);
            Assert.AreEqual("Lopez", alumno.ApellidoMaterno);
            Assert.AreEqual("Masculino ", alumno.Sexo);
            DateTime date = new DateTime(2010, 2, 1);
            Assert.AreEqual(date, alumno.FechaNacimiento);
        }
        [TestMethod]
        public void TestMethodObtenerAlumnoDNIVacio()
        {
            try
            {
                AlumnoWS.AlumnoServiceClient alumnoService = new AlumnoWS.AlumnoServiceClient();
                AlumnoWS.Alumno alumno = alumnoService.Obtener("");
            }
            catch (FaultException<ManejadorException> error)
            {
                Assert.AreEqual("Error al intentar obtener alumno", error.Reason.ToString());
                Assert.AreEqual("100", error.Detail.Codigo);
                Assert.AreEqual("DNI no puede ser vacío", error.Detail.Descripcion);
            }
        }
    }
}
