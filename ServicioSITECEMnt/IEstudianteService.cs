using ServicioSITECE.Dominio;
using ServicioSITECE.Errores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServicioSITECE
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IEstudianteService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IEstudianteService
    {
        [FaultContract(typeof(ManejadorException))]
        [OperationContract]
        List<Estudiante> ObtenerEstudiante(String dniEstudiante);
    }
}
