using SistemaDePrematricula.SolicitudServWS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace SistemaDePrematricula
{
    public partial class ReservaNuevo : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static ApoderadoServWS.Apoderado ObtenerPoderado(string dniApoderado)
        {
            try
            {
                ApoderadoServWS.ApoderadoServiceClient servicioApoderado = new ApoderadoServWS.ApoderadoServiceClient();
                return servicioApoderado.Obtener(dniApoderado);
            }
            catch (Exception ex)
            {
                throw new Exception("ERROR: " + ex.Message);
            }
        }
        [WebMethod]
        public static NivelesServWS.Niveles ObtenerNivel(string nivel, string grado)
        {
            try
            {
                NivelesServWS.NivelesServiceClient nivelClient = new NivelesServWS.NivelesServiceClient();
                return nivelClient.Obtener(nivel, grado);

            }
            catch (Exception ex)
            {
                throw new Exception("ERROR: " + ex.Message);
            }
        }
        [WebMethod]
        public static string CrearSolicitud(AlumnoServWS.Alumno alumno, ApoderadoServWS.Apoderado apoderado)
        {
            try
            {
                NivelesServWS.NivelesServiceClient nivelClient = new NivelesServWS.NivelesServiceClient();
                NivelesServWS.Niveles niveles = nivelClient.Obtener(alumno.Nivel, alumno.Grado);
                if (niveles != null)
                {
                    ApoderadoServWS.ApoderadoServiceClient servicioApoderado = new ApoderadoServWS.ApoderadoServiceClient();
                    servicioApoderado.Crear(apoderado);
                    alumno.IdNivel = niveles.IdNivel;
                    AlumnoServWS.AlumnoServiceClient alumnoServiceClient = new AlumnoServWS.AlumnoServiceClient();
                    alumnoServiceClient.Crear(alumno);

                    SolicitudServiceClient solicitudService = new SolicitudServiceClient();
                    Solicitud solicitud = new Solicitud()
                    {
                        NroDniAlumno = alumno.DNI,
                        NroDniApoderado = alumno.NroDniApoderado,
                        IdNivel = alumno.IdNivel,
                        Tipo = "Nuevo",
                        Estado = "Pendiente",
                        FechaSolicitud = DateTime.Now
                    };
                    Solicitud solicitudCreado = solicitudService.Crear(solicitud);
                    return "OK";
                }
                return "ERROR";

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}