using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServicioGestionSolicitudes.Errores
{
    [DataContract]
    public class ManejadorException
    {
        [DataMember]
        public String Codigo { get; set; }
        [DataMember]
        public String Descripcion { get; set; }

    }
}