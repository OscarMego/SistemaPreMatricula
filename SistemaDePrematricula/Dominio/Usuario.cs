using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaDePrematricula.Dominio
{
    public class Usuario
    {
        public string DNI { get; set; }
        public string Nombres { get; set; }
        public string Login { get; set; }
        public string Clave { get; set; }
        public string Perfil { get; set; }
    }
}