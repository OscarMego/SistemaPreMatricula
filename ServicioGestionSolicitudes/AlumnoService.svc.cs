using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ServicioAlumnos.Dominio;
using ServicioAlumnos.Persistencia;
using ServicioGestionSolicitudes.Errores;

namespace ServicioGestionSolicitudes
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "AlumnoService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione AlumnoService.svc o AlumnoService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class AlumnoService : IAlumnoService
    {
        private AlumnoDao dao = new AlumnoDao();
        public Alumno Obtener(string dni)
        {
            if (String.IsNullOrEmpty(dni))
            {
                throw new FaultException<ManejadorException>(new ManejadorException() {
                    Codigo = "100",
                    Descripcion = "DNI no puede ser vacío"
                }, new FaultReason("Error al intentar obtener alumno"));
            }
            return dao.GetAlumno(dni);
        }
    }
}
