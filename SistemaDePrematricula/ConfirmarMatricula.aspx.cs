using SistemaDePrematricula.AlumnoServWS;
using SistemaDePrematricula.Dominio;
using SistemaDePrematricula.Persistencia;
using SistemaDePrematricula.SolicitudServWS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaDePrematricula
{
    public partial class ConfirmarMatricula : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        public static AlumnoServWS.Alumno Login(string login, string clave)
        {
            try
            {
                AlumnoServWS.Alumno alumno = null;
                UsuarioDao dao = new UsuarioDao();
                Usuario usuario = dao.LoginAlumno(login, clave);
                if (usuario != null)
                {
                    HttpContext.Current.Session["NombreUsuario"] = usuario.Nombres;
                    HttpContext.Current.Session["DNI"] = usuario.DNI;
                    HttpContext.Current.Session["Perfil"] = usuario.Perfil;
                    AlumnoServiceClient alumnoService = new AlumnoServiceClient();
                    alumno = alumnoService.Obtener(usuario.DNI);
                }
                else
                {
                    return null;
                }
                return alumno;
            }
            catch (Exception ex)
            {
                throw new Exception("ERROR: " + ex.Message);
            }
        }
        [WebMethod]
        public static String Reservar()
        {
            try
            {
                AlumnoServiceClient alumnoService = new AlumnoServiceClient();
                AlumnoServWS.Alumno alumno = alumnoService.Obtener(HttpContext.Current.Session["DNI"].ToString());
                SolicitudServiceClient solicitudService = new SolicitudServiceClient();
                Solicitud solicitud = new Solicitud()
                {
                    NroDniAlumno = alumno.DNI,
                    NroDniApoderado = alumno.NroDniApoderado,
                    IdNivel = alumno.IdNivel,
                    Tipo = "Antiguo",
                    Estado = "Pendiente",
                    FechaSolicitud = DateTime.Now
                };
                Solicitud solicitudCreado = solicitudService.Crear(solicitud);
                return "OK";
            }
            catch (FaultException<SolicitudServWS.ManejadorException> error)
            {
                throw new Exception("ERROR: " + error.Message + ", " + error.Detail.Descripcion);
            }
        }
    }
}