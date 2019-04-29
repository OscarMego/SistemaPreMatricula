using ServicioSITECE.Dominio;
using ServicioSITECE.Errores;
using ServicioSITECE.Persistencia;
using System.ServiceModel;

namespace ServicioSITECE
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "EstudianteService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione EstudianteService.svc o EstudianteService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class EstudianteService : IEstudianteService
    {
        private readonly EstudianteDao dao = new EstudianteDao();

        public Estudiante InsertEstudiante(string token, Estudiante estudiante)
        {


            ServicioSITECEInsert.AsociadoWSIns.RegistroServiceClient asociado = new ServicioSITECEInsert.AsociadoWSIns.RegistroServiceClient();
            if (asociado.ObtenerAsociadoToken(token) != null)
            {
                throw new FaultException<ManejadorException>(new ManejadorException() //de existir generamos una excepcion indicando lo sucedido
                {
                    Codigo = "400",
                    Descripcion = "Token invalido"
                }, new FaultReason("Error al intentar crear"));
            }
            return dao.insert(estudiante);
        }        
    }
}
