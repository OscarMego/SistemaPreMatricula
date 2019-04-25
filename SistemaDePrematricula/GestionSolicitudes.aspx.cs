using SistemaDePrematricula.Dominio;
using SistemaDePrematricula.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaDePrematricula
{
    public partial class GestionSolicitudes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        public static List<SolicitudServWS.Solicitud> Login(string login, string clave)
        {
            try
            {
                List<SolicitudServWS.Solicitud> solicitudes = null;
                UsuarioDao dao = new UsuarioDao();
                Usuario usuario = dao.LoginSecretaria(login, clave);
                if (usuario != null)
                {
                    HttpContext.Current.Session["NombreUsuario"] = usuario.Nombres;
                    HttpContext.Current.Session["DNI"] = usuario.DNI;
                    HttpContext.Current.Session["Perfil"] = usuario.Perfil;
                    SolicitudServWS.SolicitudServiceClient solicitudService = new SolicitudServWS.SolicitudServiceClient();
                    solicitudes = solicitudService.Listar().ToList();
                }
                else
                {
                    return null;
                }
                return solicitudes;
            }
            catch (Exception ex)
            {
                throw new Exception("ERROR: " + ex.Message);
            }
        }

        [WebMethod]
        public static List<SolicitudServWS.Solicitud> ActualizarLista()
        {
            try
            {
                List<SolicitudServWS.Solicitud> solicitudes = null;
                SolicitudServWS.SolicitudServiceClient solicitudService = new SolicitudServWS.SolicitudServiceClient();
                solicitudes = solicitudService.Listar().ToList();

                return solicitudes;
            }
            catch (Exception ex)
            {
                throw new Exception("ERROR: " + ex.Message);
            }
        }
    }
}