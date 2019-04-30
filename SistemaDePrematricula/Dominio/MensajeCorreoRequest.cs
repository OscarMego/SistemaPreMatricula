using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaDePrematricula.Dominio
{
    public class MensajeCorreoRequest
    {
        public string emisor { get; set; }
        public string clave { get; set; }
        public string destinatario { get; set; }
        public string asunto { get; set; }
        public string mensaje { get; set; }

    }
}