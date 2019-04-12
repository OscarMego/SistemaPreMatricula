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
        protected void Page_LoadConsultarCursos(object sender, EventArgs e)
        {

        }
        [WebMethod]
        public static AlumnoServWS.Alumno Mostrar(string login, string clave)
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
    }
}