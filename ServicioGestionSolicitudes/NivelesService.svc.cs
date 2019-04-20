using ServicioGestionSolicitudes.Dominio;
using ServicioGestionSolicitudes.Errores;
using ServicioGestionSolicitudes.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioGestionSolicitudes
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "NivelesService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione NivelesService.svc o NivelesService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class NivelesService : INivelesService
    {
        private NivelesDAO dao = new NivelesDAO();
        public Niveles Obtener(string Nivel, string Grado)
        {
            if (String.IsNullOrEmpty(Nivel))
            {
                throw new FaultException<ManejadorException>(new ManejadorException()
                {
                    Codigo = "100",
                    Descripcion = "El nivel está vacío"
                }, new FaultReason("Error al intentar obtener nivel"));
            }

            if (String.IsNullOrEmpty(Grado))
            {
                throw new FaultException<ManejadorException>(new ManejadorException()
                {
                    Codigo = "100",
                    Descripcion = "El grado está vacío"
                }, new FaultReason("Error al intentar obtener nivel"));
            }
            return dao.GetNivel(Nivel, Grado);
        }
    }
}
