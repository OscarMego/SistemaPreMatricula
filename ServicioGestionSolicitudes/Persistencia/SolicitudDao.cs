using ServicioGestionSolicitudes.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ServicioGestionSolicitudes.Persistencia
{
    public class SolicitudDao
    {
        private string strConexion = "Data Source=.;Initial Catalog=BdPrematriculas;Integrated Security=True";

        public Solicitud Crear(Solicitud solicitud)
        {
            Solicitud solicitudCreado = null;
            string sql = "INSERT INTO [dbo].[Prematriculas]([NroDniAlumno],[Certificado],[IdNivel],[Tipo],[Estado],[Observaciones],[FechaSolicitud],[FechaRespuesta],[FechaCita])";
            sql += " VALUES(@NroDniAlumno,@Certificado,@IdNivel,@Tipo,@Estado,@Observaciones,@FechaSolicitud,@FechaRespuesta,@FechaCita);SELECT CAST(scope_identity() AS int)";
            using (SqlConnection cn = new SqlConnection(strConexion))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    List<SqlParameter> sqlParameters = new List<SqlParameter>();
                    SqlParameter parameter = new SqlParameter("@NroDniAlumno", solicitud.NroDniAlumno);
                    sqlParameters.Add(parameter);
                    if (solicitud.Certificado == null)
                    {
                        parameter = new SqlParameter("@Certificado", DBNull.Value);
                    }
                    else
                    {
                        parameter = new SqlParameter("@Certificado", solicitud.Certificado);
                    }
                    sqlParameters.Add(parameter);
                    parameter = new SqlParameter("@IdNivel", solicitud.IdNivel);
                    sqlParameters.Add(parameter);
                    parameter = new SqlParameter("@Tipo", solicitud.Tipo);
                    sqlParameters.Add(parameter);
                    parameter = new SqlParameter("@Estado", solicitud.Estado);
                    sqlParameters.Add(parameter);
                    if (solicitud.Observaciones == null)
                    {
                        parameter = new SqlParameter("@Observaciones", DBNull.Value);
                    }
                    else
                    {
                        parameter = new SqlParameter("@Observaciones", solicitud.Observaciones);
                    }
                    sqlParameters.Add(parameter);
                    parameter = new SqlParameter("@FechaSolicitud", solicitud.FechaSolicitud);
                    sqlParameters.Add(parameter);
                    if (solicitud.FechaCita.Year == 1)
                    {
                        parameter = new SqlParameter("@FechaCita", DBNull.Value);
                    }
                    else
                    {
                        parameter = new SqlParameter("@FechaCita", solicitud.FechaCita);
                    }
                    sqlParameters.Add(parameter);

                    if (solicitud.FechaRespuesta.Year == 1)
                    {
                        parameter = new SqlParameter("@FechaRespuesta", DBNull.Value);
                    }
                    else
                    {
                        parameter = new SqlParameter("@FechaRespuesta", solicitud.FechaRespuesta);
                    }
                    sqlParameters.Add(parameter);

                    cmd.Parameters.AddRange(sqlParameters.ToArray());
                    solicitud.IdPreMatricula = (int)cmd.ExecuteScalar();
                }
            }
            solicitudCreado = Obtener(solicitud.IdPreMatricula, solicitud.NroDniAlumno);
            return solicitudCreado;
        }
        public Solicitud Obtener(int idPrematricula, string dni)
        {
            Solicitud solicitud = null;
            string sql = "SELECT pm.[IdPrematricula],pm.[NroDniAlumno],A.[DniApoderado] NroDniApoderado,pm.[Certificado],pm.[IdNivel],pm.[Tipo],pm.[Estado],pm.[Observaciones],pm.[FechaSolicitud],pm.[FechaRespuesta],pm.[FechaCita],a.Nombres+' '+A.ApellidoPaterno+' '+A.ApellidoMaterno NombreApellidoAlumno,n.Nivel,n.Grado FROM [dbo].[Prematriculas] pm INNER JOIN dbo.Alumnos A ON A.NroDni = pm.NroDniAlumno INNER JOIN dbo.Niveles n ON n.IdNivel = pm.IdNivel WHERE (@idprematricula=0 or pm.IdPrematricula=@idprematricula) and (@dni='' or NroDniAlumno=@dni)";
            using (SqlConnection cn = new SqlConnection(strConexion))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.Add(new SqlParameter("@idPrematricula", idPrematricula));
                    cmd.Parameters.Add(new SqlParameter("@dni", dni));
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            solicitud = new Solicitud()
                            {
                                IdPreMatricula = !dr.IsDBNull(dr.GetOrdinal("IdPrematricula")) ? dr.GetInt32(dr.GetOrdinal("IdPrematricula")) : 0,
                                NroDniAlumno = !dr.IsDBNull(dr.GetOrdinal("NroDniAlumno")) ? dr.GetString(dr.GetOrdinal("NroDniAlumno")) : "",
                                NroDniApoderado = !dr.IsDBNull(dr.GetOrdinal("NroDniApoderado")) ? dr.GetString(dr.GetOrdinal("NroDniApoderado")) : "",
                                Certificado = !dr.IsDBNull(dr.GetOrdinal("Certificado")) ? dr.GetString(dr.GetOrdinal("Certificado")) : "",
                                IdNivel = !dr.IsDBNull(dr.GetOrdinal("IdNivel")) ? dr.GetInt32(dr.GetOrdinal("IdNivel")) : 0,
                                Tipo = !dr.IsDBNull(dr.GetOrdinal("Tipo")) ? dr.GetString(dr.GetOrdinal("Tipo")) : "",
                                Estado = !dr.IsDBNull(dr.GetOrdinal("Estado")) ? dr.GetString(dr.GetOrdinal("Estado")) : "",
                                Observaciones = !dr.IsDBNull(dr.GetOrdinal("Observaciones")) ? dr.GetString(dr.GetOrdinal("Observaciones")) : "",
                                FechaSolicitud = !dr.IsDBNull(dr.GetOrdinal("FechaSolicitud")) ? dr.GetDateTime(dr.GetOrdinal("FechaSolicitud")) : new DateTime(),
                                FechaRespuesta = !dr.IsDBNull(dr.GetOrdinal("FechaRespuesta")) ? dr.GetDateTime(dr.GetOrdinal("FechaRespuesta")) : new DateTime(),
                                FechaCita = !dr.IsDBNull(dr.GetOrdinal("FechaCita")) ? dr.GetDateTime(dr.GetOrdinal("FechaCita")) : new DateTime(),
                                NombreApellidoAlumno = !dr.IsDBNull(dr.GetOrdinal("NombreApellidoAlumno")) ? dr.GetString(dr.GetOrdinal("NombreApellidoAlumno")) : "",
                                Nivel = !dr.IsDBNull(dr.GetOrdinal("Nivel")) ? dr.GetString(dr.GetOrdinal("Nivel")) : "",
                                Grado = !dr.IsDBNull(dr.GetOrdinal("Grado")) ? dr.GetString(dr.GetOrdinal("Grado")) : "",
                            };
                        }
                    }
                }
            }
            return solicitud;
        }

        public List<Solicitud> Listar()
        {
            List<Solicitud> solicituds = new List<Solicitud>();
            Solicitud solicitud = null;
            string sql = "SELECT pm.[IdPrematricula],pm.[NroDniAlumno],A.[DniApoderado] NroDniApoderado,pm.[Certificado],pm.[IdNivel],pm.[Tipo],pm.[Estado],pm.[Observaciones],pm.[FechaSolicitud],pm.[FechaRespuesta],pm.[FechaCita],a.Nombres+' '+A.ApellidoPaterno+' '+A.ApellidoMaterno NombreApellidoAlumno,n.Nivel,n.Grado FROM [dbo].[Prematriculas] pm INNER JOIN dbo.Alumnos A ON A.NroDni = pm.NroDniAlumno INNER JOIN dbo.Niveles n ON n.IdNivel = pm.IdNivel WHERE Estado<>'Aceptado' and estado<>'Rechazado'";
            using (SqlConnection cn = new SqlConnection(strConexion))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            solicitud = new Solicitud()
                            {
                                IdPreMatricula = !dr.IsDBNull(dr.GetOrdinal("IdPrematricula")) ? dr.GetInt32(dr.GetOrdinal("IdPrematricula")) : 0,
                                NroDniAlumno = !dr.IsDBNull(dr.GetOrdinal("NroDniAlumno")) ? dr.GetString(dr.GetOrdinal("NroDniAlumno")) : "",
                                NroDniApoderado = !dr.IsDBNull(dr.GetOrdinal("NroDniApoderado")) ? dr.GetString(dr.GetOrdinal("NroDniApoderado")) : "",
                                Certificado = !dr.IsDBNull(dr.GetOrdinal("Certificado")) ? dr.GetString(dr.GetOrdinal("Certificado")) : "",
                                IdNivel = !dr.IsDBNull(dr.GetOrdinal("IdNivel")) ? dr.GetInt32(dr.GetOrdinal("IdNivel")) : 0,
                                Tipo = !dr.IsDBNull(dr.GetOrdinal("Tipo")) ? dr.GetString(dr.GetOrdinal("Tipo")) : "",
                                Estado = !dr.IsDBNull(dr.GetOrdinal("Estado")) ? dr.GetString(dr.GetOrdinal("Estado")) : "",
                                Observaciones = !dr.IsDBNull(dr.GetOrdinal("Observaciones")) ? dr.GetString(dr.GetOrdinal("Observaciones")) : "",
                                FechaSolicitud = !dr.IsDBNull(dr.GetOrdinal("FechaSolicitud")) ? dr.GetDateTime(dr.GetOrdinal("FechaSolicitud")) : new DateTime(),
                                FechaRespuesta = !dr.IsDBNull(dr.GetOrdinal("FechaRespuesta")) ? dr.GetDateTime(dr.GetOrdinal("FechaRespuesta")) : new DateTime(),
                                FechaCita = !dr.IsDBNull(dr.GetOrdinal("FechaCita")) ? dr.GetDateTime(dr.GetOrdinal("FechaCita")) : new DateTime(),
                                NombreApellidoAlumno = !dr.IsDBNull(dr.GetOrdinal("NombreApellidoAlumno")) ? dr.GetString(dr.GetOrdinal("NombreApellidoAlumno")) : "",
                                Nivel = !dr.IsDBNull(dr.GetOrdinal("Nivel")) ? dr.GetString(dr.GetOrdinal("Nivel")) : "",
                                Grado = !dr.IsDBNull(dr.GetOrdinal("Grado")) ? dr.GetString(dr.GetOrdinal("Grado")) : "",
                            };
                            solicituds.Add(solicitud);
                        }
                    }
                }
            }
            return solicituds;
        }

        public Solicitud Modificar(Solicitud solicitud)
        {
            Solicitud solicitudModicado = null;
            string sql = "UPDATE [dbo].[Prematriculas] SET [NroDniAlumno] = @NroDniAlumno,[Certificado] = @Certificado,[IdNivel] = @IdNivel,[Tipo] = @Tipo,[Estado] = @Estado,[Observaciones] = @Observaciones,[FechaSolicitud] = @FechaSolicitud ,[FechaRespuesta] = @FechaRespuesta,[FechaCita] = @FechaCita WHERE IdPrematricula=@IdPrematricula";
            using (SqlConnection cn = new SqlConnection(strConexion))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    List<SqlParameter> sqlParameters = new List<SqlParameter>();
                    SqlParameter parameter = new SqlParameter("@NroDniAlumno", solicitud.NroDniAlumno);
                    sqlParameters.Add(parameter);
                    parameter = new SqlParameter("@Certificado", solicitud.Certificado);
                    sqlParameters.Add(parameter);
                    parameter = new SqlParameter("@IdNivel", solicitud.IdNivel);
                    sqlParameters.Add(parameter);
                    parameter = new SqlParameter("@Tipo", solicitud.Tipo);
                    sqlParameters.Add(parameter);
                    parameter = new SqlParameter("@Estado", solicitud.Estado);
                    sqlParameters.Add(parameter);
                    parameter = new SqlParameter("@Observaciones", solicitud.Observaciones);
                    sqlParameters.Add(parameter);
                    parameter = new SqlParameter("@FechaSolicitud", solicitud.FechaSolicitud);
                    sqlParameters.Add(parameter);
                    if (solicitud.FechaCita.Year == 1)
                    {
                        parameter = new SqlParameter("@FechaCita", DBNull.Value);
                    }
                    else
                    {
                        parameter = new SqlParameter("@FechaCita", solicitud.FechaCita);
                    }
                    sqlParameters.Add(parameter);
                    parameter = new SqlParameter("@FechaRespuesta", solicitud.FechaRespuesta);
                    sqlParameters.Add(parameter);
                    parameter = new SqlParameter("@IdPrematricula", solicitud.IdPreMatricula);
                    sqlParameters.Add(parameter);
                    cmd.Parameters.AddRange(sqlParameters.ToArray());
                    cmd.ExecuteNonQuery();
                }
            }
            solicitudModicado = Obtener(solicitud.IdPreMatricula, solicitud.NroDniAlumno);
            return solicitudModicado;
        }
    }
}