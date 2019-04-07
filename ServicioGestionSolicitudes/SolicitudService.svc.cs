using System.Collections.Generic;
using System.ServiceModel;
using ServicioAlumnos.Persistencia;
using ServicioGestionSolicitudes.Dominio;
using ServicioGestionSolicitudes.Errores;
using ServicioGestionSolicitudes.Persistencia;

namespace ServicioGestionSolicitudes
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "SolicitudService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione SolicitudService.svc o SolicitudService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class SolicitudService : ISolicitudService
    {
        private SolicitudDao solicitudDao = new SolicitudDao();
        private AlumnoDao alumnoDao = new AlumnoDao();
        private ApoderadoDao apoderadoDao = new ApoderadoDao();
        public Solicitud Crear(Solicitud solicitud)
        {
            if (string.IsNullOrEmpty(solicitud.NroDniAlumno))
            {
                throw new FaultException<ManejadorException>(new ManejadorException()
                {
                    Codigo = "100",
                    Descripcion = "DNI no puede ser vacío"
                }, new FaultReason("Error al intentar crear solicitud"));
            }
            if (solicitudDao.Obtener(0, solicitud.NroDniAlumno) != null)
            {
                throw new FaultException<ManejadorException>(new ManejadorException()
                {
                    Codigo = "101",
                    Descripcion = "DNI del alumno ya se encuentra registrado"
                }, new FaultReason("Error al intentar crear solicitud"));
            }
            return solicitudDao.Crear(solicitud);
        }

        public List<Solicitud> Listar()
        {
            return solicitudDao.Listar();
        }

        public Solicitud Modificar(Solicitud solicitud)
        {
            if (string.IsNullOrEmpty(solicitud.NroDniAlumno) || string.IsNullOrEmpty(solicitud.NroDniApoderado))
            {
                throw new FaultException<ManejadorException>(new ManejadorException()
                {
                    Codigo = "100",
                    Descripcion = "DNI no puede ser vacío"
                }, new FaultReason("Error al intentar modificar solicitud"));
            }
            return solicitudDao.Modificar(solicitud);
        }

        public Solicitud Obtener(int idPrematricula, string dni)
        {
            if (idPrematricula == 0 && string.IsNullOrEmpty(dni))
            {
                throw new FaultException<ManejadorException>(new ManejadorException()
                {
                    Codigo = "102",
                    Descripcion = "Ingresar al menos un criterio de búsqueda"
                }, new FaultReason("Error al intentar obtener solicitud"));
            }
            Solicitud solicitud = solicitudDao.Obtener(idPrematricula, dni);
            solicitud.Alumno = alumnoDao.GetAlumno(dni);
            solicitud.apoderado = apoderadoDao.GetApoderado(solicitud.NroDniApoderado);
            return solicitud;
        }
     
    }
}
