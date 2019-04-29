using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ServicioSITECE.Dominio;
using ServicioSITECE.Persistencia;
using System.Web.Security;
using System.Net.Mail;
using ServicioSITECE.Errores;

namespace ServicioSITECE
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "RegistroService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione RegistroService.svc o RegistroService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class RegistroService : IRegistroService
    {
        private readonly AsociadoDao dao = new AsociadoDao();
        public Asociado CrearAsociado(Asociado asociado)
        {
            bool existe = true;
            Asociado creado = dao.getAsociado(asociado.CodigoModular, "");
            if (creado == null)
            {
                var token = Guid.NewGuid().ToString();
                asociado.Token = token;
                creado = dao.insert(asociado);
                existe = false;
            }
            if (creado != null)
            {
                try
                {
                    SmtpClient client = new SmtpClient();
                    client.Port = 587;
                    client.Host = "smtp.gmail.com";
                    client.EnableSsl = true;
                    client.Timeout = 10000;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new System.Net.NetworkCredential("sitece.notificaciones@gmail.com", "sitece$2019");
                    MailMessage mm = new MailMessage("sitece.notificaciones@gmail.com", asociado.Email, "Registro CITECE", "Su cuenta fue activada correctamente, su token es: <b>" + creado.Token + "</b>");
                    mm.BodyEncoding = UTF8Encoding.UTF8;
                    mm.IsBodyHtml = true;
                    mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure; client.Send(mm);
                }
                catch { }
                if (existe)
                {
                    throw new FaultException<ManejadorException>(new ManejadorException()
                    {
                        Codigo = "200",
                        Descripcion = "Código modular ya existe, se reenvió el token al correo " + creado.Email
                    }, new FaultReason("Error al intentar crea asociado"));
                }
            }
            return creado;
        }

        public Asociado ObtenerAsociado(string token, string codigoModular)
        {
            return dao.getAsociado(codigoModular, token);
        }

        public Asociado ObtenerAsociadoToken(string token)
        {
            return dao.getAsociado("", token);
        }
    }
}
