using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServicioSITECE.Dominio
{
    [DataContract]
    public class Asociado
    {
        [DataMember]
        public Int64 IdAsociado { get; set; }
        [DataMember]
        public String CodigoModular { get; set; }
        [DataMember]
        public String NombreColegio { get; set; }
        [DataMember]
        public String Email { get; set; }
        [DataMember]
        public String Token { get; set; }

    }
}