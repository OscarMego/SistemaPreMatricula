using ServicioSITECE.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ServicioSITECE.Persistencia
{
    public class EstudianteDao
    {

        private string strConexion = "Data Source=.;Initial Catalog=SITECE;Integrated Security=True";
        public Estudiante getEstudiante(String dni, int anho)
        {
            Estudiante objEstudiante = null;
            using (SqlConnection cn = new SqlConnection(strConexion))
            {
                cn.Open();
                string sql = "SELECT [IdEstudiante],[Dni],[Anho],[Nombres],[Apellidos],[Deuda],[fechaRegistro],[IdAsociado]  FROM [dbo].[Estudiante] WHERE Dni=@dni and Anho=@anho";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.Add(new SqlParameter("@dni", dni));
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            objEstudiante = new Estudiante()
                            {
                                IdEstudiante = dr.GetInt64(dr.GetOrdinal("IdEstudiante")),
                                Dni = dr.GetString(dr.GetOrdinal("Dni")),
                                Anho = dr.GetInt32(dr.GetOrdinal("Anho")),
                                Nombres = dr.GetString(dr.GetOrdinal("Nombres")),
                                Apellidos = dr.GetString(dr.GetOrdinal("Apellidos")),
                                Deuda = dr.GetDecimal(dr.GetOrdinal("Deuda")),
                                FechaRegistro = dr.GetDateTime(dr.GetOrdinal("fechaRegistro")),
                                IdAsociado = dr.GetInt64(dr.GetOrdinal("IdAsociado")),
                            };
                        }
                    }
                }
            }
            return objEstudiante;
        }
        public Estudiante insert(Estudiante estudiante)
        {
            using (SqlConnection cn = new SqlConnection(strConexion))
            {
                string sql = "INSERT INTO [dbo].[Estudiante]([Dni],[Anho],[Nombres],[Apellidos],[Deuda],[fechaRegistro],[IdAsociado]) ";
                sql = sql + "VALUES(@Dni,,@Anho,,@Nombres,,@Apellidos,,@Deuda, ,@fechaRegistro,,@IdAsociado)";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.Add(new SqlParameter("@Dni", estudiante.Dni));
                    cmd.Parameters.Add(new SqlParameter("@Anho", estudiante.Anho));
                    cmd.Parameters.Add(new SqlParameter("@Nombres", estudiante.Nombres));
                    cmd.Parameters.Add(new SqlParameter("@Apellidos", estudiante.Apellidos));
                    cmd.Parameters.Add(new SqlParameter("@Deuda", estudiante.Deuda));
                    cmd.Parameters.Add(new SqlParameter("@fechaRegistro", estudiante.FechaRegistro));
                    cmd.Parameters.Add(new SqlParameter("@IdAsociado", estudiante.IdAsociado));
                    cmd.ExecuteNonQuery();
                }
            }
            return getEstudiante(estudiante.Dni, estudiante.Anho);
        }
    }
}