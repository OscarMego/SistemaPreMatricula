using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestServicioGestionSolicitudes.ApoderadoWS;
using System.ServiceModel;

namespace TestServicioGestionSolicitudes
{
    /// Descripción resumida de UnitTestApoderado
    [TestClass]
    public class UnitTestApoderado
    {
        [TestMethod]
        public void TestMethodObtenerApoderado()
        {
            ApoderadoWS.ApoderadoServiceClient apoderadoService = new ApoderadoWS.ApoderadoServiceClient();
            ApoderadoWS.Apoderado apoderado = apoderadoService.Obtener("12345679");
            Assert.AreEqual("12345679", apoderado.NroDni);
            Assert.AreEqual("Maria", apoderado.Nombres);
            Assert.AreEqual("Gomez", apoderado.ApellidoPaterno);
            Assert.AreEqual("Corrales", apoderado.ApellidoMaterno);
            Assert.AreEqual("Av. Sucre", apoderado.Direccion);
            Assert.AreEqual("987654321", apoderado.NroCelular);
            Assert.AreEqual("mariagomez@gmail.com", apoderado.Correo);
            Assert.AreEqual("Mamá", apoderado.Parentesco);
        }

        [TestMethod]
        public void TestMethodObtenerApoderadoDNIVacio()
        {
            try
            {
                ApoderadoWS.ApoderadoServiceClient apoderadoService = new ApoderadoWS.ApoderadoServiceClient();
                ApoderadoWS.Apoderado apoderado= apoderadoService.Obtener("");
            }
            catch (FaultException<ManejadorException> error)
            {
                Assert.AreEqual("Error al intentar obtener apoderado", error.Reason.ToString());
                Assert.AreEqual("100", error.Detail.Codigo);
                Assert.AreEqual("DNI no puede ser vacío", error.Detail.Descripcion);
            }
        }


        
    }
}
