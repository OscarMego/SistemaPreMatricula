using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServicioAlumnos.Dominio
{
    [DataContract]
    public class Alumno
    {
        [DataMember]
        public string DNI { get; set; }
        [DataMember]
        public string Nombres { get; set; }
        [DataMember]
        public string ApellidoPaterno { get; set; }
        [DataMember]
        public string ApellidoMaterno { get; set; }
        [DataMember]
        public string Sexo { get; set; }
        [DataMember]
        public string NroDniApoderado { get; set; }
        [DataMember]
        public DateTime FechaNacimiento { get; set; }
        [DataMember]
        public int IdNivel { get; set; }
        [DataMember]
        public string Nivel { get; set; }
        [DataMember]
        public string Grado { get; set; }

    }
}