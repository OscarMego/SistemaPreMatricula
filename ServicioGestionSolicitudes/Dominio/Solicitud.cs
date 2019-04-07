using ServicioAlumnos.Dominio;
using System;
using System.Runtime.Serialization;

namespace ServicioGestionSolicitudes.Dominio
{
    [DataContract]
    public class Solicitud
    {
        [DataMember]
        public int IdPreMatricula { get; set; }
        [DataMember]
        public string NroDniAlumno { get; set; }
        [DataMember]
        public string NombreApellidoAlumno { get; set; }
        [DataMember]
        public Alumno Alumno { get; set; }
        [DataMember]
        public string NroDniApoderado { get; set; }
        [DataMember]
        public Apoderado apoderado { get; set; }
        [DataMember]
        public string Certificado { get; set; }
        [DataMember]
        public int IdNivel { get; set; }
        [DataMember]
        public string Nivel { get; set; }
        [DataMember]
        public string Grado { get; set; }
        [DataMember]
        public string Tipo { get; set; }
        [DataMember]
        public string Estado { get; set; }
        [DataMember]
        public string Observaciones { get; set; }
        [DataMember]
        public DateTime FechaSolicitud { get; set; }
        [DataMember]
        public DateTime FechaRespuesta { get; set; }
        [DataMember]
        public DateTime FechaCita { get; set; }
    }
}