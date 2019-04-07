using ServicioAlumnos.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ServicioAlumnos.Persistencia
{
    public class AlumnoDao
    {
        private string strConexion = "Data Source=.; Database=BdPrematriculas; uid=sa; pwd=1234";
        public Alumno GetAlumno(string dni)
        {
            Alumno alumno = null;
            using (SqlConnection cn = new SqlConnection(strConexion))
            {
                cn.Open();
                string sql = "SELECT A.[NroDni],A.[Nombres],A.[ApellidoPaterno],A.[ApellidoMaterno],A.[Sexo],A.[FechaNacimiento],A.[IdNivel],N.Nivel,N.Grado,A.[DniApoderado]  FROM [Alumnos] A INNER JOIN dbo.Niveles N ON A.IdNivel=N.IdNivel WHERE A.NroDni=@DNI";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    SqlParameter sqlParameter = new SqlParameter("@DNI", dni);
                    cmd.Parameters.Add(sqlParameter);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            alumno = new Alumno()
                            {
                                DNI = dr.GetString(dr.GetOrdinal("NroDni")),
                                Nombres = dr.GetString(dr.GetOrdinal("Nombres")),
                                ApellidoPaterno = dr.GetString(dr.GetOrdinal("ApellidoPaterno")),
                                ApellidoMaterno = dr.GetString(dr.GetOrdinal("ApellidoMaterno")),
                                Sexo = dr.GetString(dr.GetOrdinal("Sexo")),
                                FechaNacimiento = dr.GetDateTime(dr.GetOrdinal("FechaNacimiento")),
                                IdNivel = dr.GetInt32(dr.GetOrdinal("IdNivel")),
                                Nivel = dr.GetString(dr.GetOrdinal("Nivel")),
                                Grado = dr.GetString(dr.GetOrdinal("Grado")),
                                NroDniApoderado = dr.GetString(dr.GetOrdinal("DniApoderado"))
                            };
                        }
                    }
                }
            }
            return alumno;
        }
    }
}