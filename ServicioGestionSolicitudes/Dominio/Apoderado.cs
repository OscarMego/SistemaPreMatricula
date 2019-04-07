using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServicioGestionSolicitudes.Dominio
{
    [DataContract]
    public class Apoderado
    {
        [DataMember]
        public string NroDni { get; set; }
        [DataMember]
        public string Nombres { get; set; }
        [DataMember]
        public string ApellidoPaterno { get; set; }
        [DataMember]
        public string ApellidoMaterno { get; set; }
        [DataMember]
        public string Direccion { get; set; }
        [DataMember]
        public string NroCelular { get; set; }
        [DataMember]
        public string Correo { get; set; }
        [DataMember]
        public string Parentesco { get; set; }
    }
}