using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServicioGestionSolicitudes.Dominio
{
    public class Niveles
    {
        [DataMember]
        public int IdNivel { get; set; }
        [DataMember]
        public int Anho { get; set; }
        [DataMember]
        public string Nivel { get; set; }
        [DataMember]
        public string Grado { get; set; }
        [DataMember]
        public string Seccion { get; set; }
        [DataMember]
        public string Turno { get; set; }
        [DataMember]
        public int TotalVacantes { get; set; }
        [DataMember]
        public int DisponibleVacantes { get; set; }
    }
}