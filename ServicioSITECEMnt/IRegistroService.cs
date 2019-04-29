
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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IRegistroService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IRegistroService
    {
        [FaultContract(typeof(ManejadorException))]
        [OperationContract]
        Asociado CrearAsociado(Asociado asociado);
        [OperationContract]
        Asociado ObtenerAsociado(String token,String codigoModular);
        [OperationContract]
        Asociado ObtenerAsociadoToken(String token);
    }
}
