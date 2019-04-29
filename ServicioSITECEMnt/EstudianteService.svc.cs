using ServicioSITECE.Dominio;
using ServicioSITECE.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioSITECE
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "EstudianteService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione EstudianteService.svc o EstudianteService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class EstudianteService : IEstudianteService
    {
        private readonly EstudianteDao dao = new EstudianteDao();
        public List<Estudiante> ObtenerEstudiante(string dniEstudiante)
        {
            return dao.getEstudiantes(dniEstudiante);
        }
    }
}
