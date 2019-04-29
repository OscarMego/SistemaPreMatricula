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
        public List<Estudiante> getEstudiantes(String dni)
        {
            List<Estudiante> lstEstudiante = new List<Estudiante>();
            using (SqlConnection cn = new SqlConnection(strConexion))
            {
                cn.Open();
                string sql = "SELECT [IdEstudiante],[Dni],[Anho],[Nombres],[Apellidos],[Deuda],[fechaRegistro],[IdAsociado]  FROM [dbo].[Estudiante] WHERE Dni=@dni";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.Add(new SqlParameter("@dni", dni));
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        Estudiante objEstudiante;
                        while (dr.Read())
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
                            lstEstudiante.Add(objEstudiante);
                        }
                    }
                }
            }
            return lstEstudiante;
        }
    }
}