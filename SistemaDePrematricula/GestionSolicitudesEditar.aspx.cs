using SistemaDePrematricula.Dominio;
using SistemaDePrematricula.SolicitudServWS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.Text;
using System.Web;
using System.Web.Configuration;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaDePrematricula
{
    public partial class GestionSolicitudesEditar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                txtIdPreMatricula.Value = Request.QueryString["id"];
                txtDNI.Value = Request.QueryString["dni"];

                obtener();
            }
        }

        private void obtener()
        {
            string ls_token = WebConfigurationManager.AppSettings["token"];
            SolicitudServWS.Solicitud solicitud = null;
            
            SolicitudServWS.SolicitudServiceClient solicitudService = new SolicitudServWS.SolicitudServiceClient();
            solicitud = solicitudService.Obtener(int.Parse(txtIdPreMatricula.Value), txtDNI.Value);

            if (solicitud != null)
            {
                txtDNIApoderado.Value = solicitud.NroDniApoderado;
                txtNombres.Value = solicitud.NombreApellidoAlumno;
                txtNivel.Value = solicitud.Nivel;
                txtGrado.Value = solicitud.Grado;
                txtTipo.Value = solicitud.Tipo;
                txtEstado.Value = solicitud.Estado;
                txtSolicitud.Value = solicitud.FechaSolicitud.ToString("dd/MM/yyyy");
                if (solicitud.FechaCita != DateTime.MinValue)
                    txtCita.Value = solicitud.FechaCita.ToString("dd/MM/yyyy");
                txtObservaciones.Value = solicitud.Observaciones;
                txtCertificado.Value = solicitud.Certificado;
                txtIdNivel.Value = solicitud.IdNivel.ToString();
                txtNombreApoderado.Value = solicitud.apoderado.Nombres + " " + solicitud.apoderado.ApellidoPaterno;
                txtCorreoApoderado.Value = solicitud.apoderado.Correo;
            }


            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:50925/EstudianteService.svc/Estudiante/" + ls_token  + "/" + txtDNI.Value);
            request.Method = "GET";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string tramaJson = reader.ReadToEnd();

            JavaScriptSerializer js = new JavaScriptSerializer();
            List<Estudiante> estudiantesObtenidos = js.Deserialize<List<Estudiante>>(tramaJson);

            if (estudiantesObtenidos.Count > 0)
            {
                for (int i = 0; i < estudiantesObtenidos.Count; i++)
                {
                    if (estudiantesObtenidos[i].Deuda > 0)
                    {
                        txtAlertas.Value = txtAlertas.Value + "- El alumno debe " + estudiantesObtenidos[i].Deuda.ToString("#,###.00") + " del año " + estudiantesObtenidos[i].Anho.ToString() + Environment.NewLine;
                    }
                }                
            }

        }

        [WebMethod]
        public static String Grabar(SolicitudServWS.Solicitud solicitud, ApoderadoServWS.Apoderado apoderado)
        {
            try
            {
                SolicitudServiceClient solicitudService = new SolicitudServiceClient();
                //Solicitud solicitud = new Solicitud()
                //{
                //    NroDniAlumno = txtDNI.Value,
                //    NroDniApoderado = txtDNIApoderado.Value,
                //    Certificado = txtCertificado.Value,
                //    IdNivel = int.Parse(txtIdNivel.Value),
                //    Tipo = txtTipo.Value,
                //    Estado = txtEstado.Value,
                //    Observaciones = txtObservaciones.Value,
                //    FechaSolicitud = DateTime.ParseExact(txtSolicitud.Value, "dd/MM/yyyy", null),
                //    FechaCita = DateTime.Now,
                //    FechaRespuesta = DateTime.Now,
                //    IdPreMatricula = int.Parse(txtIdPreMatricula.Value)
                //};

                Solicitud solicitudModificado = solicitudService.Modificar(solicitud);
                string ls_serviciocorreo = WebConfigurationManager.AppSettings["servicioCorreo"];

                if (ls_serviciocorreo == null)
                    ls_serviciocorreo = "";

                if (solicitud.Estado == "Citado" && ls_serviciocorreo != "")
                {
                    JavaScriptSerializer js = new JavaScriptSerializer();
                    MensajeCorreoRequest solicitudCorreo = new MensajeCorreoRequest()
                    {
                        emisor = "sitece.notificaciones@gmail.com",
                        clave = "sitece$2019",
                        destinatario = apoderado.Correo,
                        asunto = "Citación del Colegio Maranguita",
                        mensaje = "Sr(a) " + apoderado.Nombres + ", Ud está citado al colegio el día " + solicitud.FechaCita.ToString("dd/MM/yyyy")
                    };

                    string jsonSolicitud = js.Serialize(solicitudCorreo);
                    byte[] ByteCorreo = Encoding.UTF8.GetBytes(jsonSolicitud);
                    HttpWebRequest request = WebRequest.Create(ls_serviciocorreo) as HttpWebRequest;
                    request.Method = "POST";
                    request.ContentLength = ByteCorreo.Length;
                    request.ContentType = "application/json";
                    var rqt = request.GetRequestStream();

                    rqt.Write(ByteCorreo, 0, ByteCorreo.Length);
                    HttpWebResponse rsp = (HttpWebResponse)request.GetResponse();
                    StreamReader reader = new StreamReader(rsp.GetResponseStream());
                    string tramaJson = reader.ReadToEnd();
                    MensajeCorreoResponse respuestaCorreo = js.Deserialize<MensajeCorreoResponse>(tramaJson);
                }
                return "OK";
            }
            catch (FaultException<SolicitudServWS.ManejadorException> error)
            {
                throw new Exception("ERROR: " + error.Message + ", " + error.Detail.Descripcion);
            }
        }

    }
}