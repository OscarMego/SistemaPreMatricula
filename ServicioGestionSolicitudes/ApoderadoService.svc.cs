using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ServicioAlumnos.Dominio;
using ServicioAlumnos.Persistencia;
using ServicioGestionSolicitudes.Dominio;
using ServicioGestionSolicitudes.Errores;
using ServicioGestionSolicitudes.Persistencia;

namespace ServicioGestionSolicitudes
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ApoderadoService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ApoderadoService.svc o ApoderadoService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ApoderadoService : IApoderadoService
    {
        private ApoderadoDao dao = new ApoderadoDao();

        public Apoderado Crear(Apoderado Crear)
        {
            throw new NotImplementedException();
        }

        public Apoderado Obtener(string dni)
        {
            if (String.IsNullOrEmpty(dni))
            {
                throw new FaultException<ManejadorException>(new ManejadorException()
                {
                    Codigo = "103",
                    Descripcion = "DNI no puede ser vacío"
                }, new FaultReason("Error al intentar obtener apoderado"));
            }
            return dao.GetApoderado(dni);
        }
    }
}
