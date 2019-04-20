using ServicioGestionSolicitudes.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ServicioGestionSolicitudes.Persistencia
{
    public class NivelesDAO
    {
        private string strConexion = "Data Source=.;Initial Catalog=BdPrematriculas;Integrated Security=True";

        public Niveles GetNivel(string Nivel, string Grado)
        {
            Niveles nivel = null;
            using (SqlConnection cn = new SqlConnection(strConexion))
            {
                cn.Open();
                string sql = "SELECT [IdNivel],[Año],[Nivel],[Grado],[Seccion],[Turno],[VacantesTotal],[VacastesDisponible] FROM [Niveles] where Nivel=@Nivel and Grado=@Grado";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    SqlParameter sqlParameter = new SqlParameter("@Nivel", Nivel);
                    cmd.Parameters.Add(sqlParameter);
                    sqlParameter = new SqlParameter("@Grado", Grado);
                    cmd.Parameters.Add(sqlParameter);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            nivel = new Niveles()
                            {
                                IdNivel = dr.GetInt32(dr.GetOrdinal("IdNivel")),
                                Anho = dr.GetInt32(dr.GetOrdinal("Año")),
                                Nivel = dr.GetString(dr.GetOrdinal("Nivel")),
                                Grado = dr.GetString(dr.GetOrdinal("Grado")),
                                Seccion = dr.GetString(dr.GetOrdinal("Seccion")),
                                Turno = dr.GetString(dr.GetOrdinal("Turno")),
                                TotalVacantes = dr.GetInt32(dr.GetOrdinal("VacantesTotal")),
                                DisponibleVacantes = dr.GetInt32(dr.GetOrdinal("VacastesDisponible")),
                            };
                        }
                    }
                }
            }
            return nivel;
        }
    }
}