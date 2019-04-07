using ServicioAlumnos.Dominio;
using ServicioGestionSolicitudes.Errores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioGestionSolicitudes
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IAlumnoService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IAlumnoService
    {
        [FaultContract(typeof(ManejadorException))]
        [OperationContract]
        Alumno Obtener(string dni);
    }
}
