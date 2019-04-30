using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaDePrematricula.Dominio
{
    public class Estudiante
    {
        public Int64 IdEstudiante { get; set; }
        public String Dni { get; set; }
        public int Anho { get; set; }
        public String Nombres { get; set; }
        public String Apellidos { get; set; }
        public Decimal Deuda { get; set; }
        public DateTime FechaRegistro { get; set; }
        public Int64 IdAsociado { get; set; }
    }
}