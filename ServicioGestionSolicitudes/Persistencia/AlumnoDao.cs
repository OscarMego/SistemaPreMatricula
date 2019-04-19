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
        private string strConexion = "Data Source=.;Initial Catalog=BdPrematriculas;Integrated Security=True";

        public Alumno PostAlumno(Alumno Crear)
        {
            using (SqlConnection cn = new SqlConnection(strConexion))
            {
                cn.Open();
                string sql1 = "INSERT INTO [dbo].[Alumno]([NroDni], [Nombres], [ApellidoPaterno], [ApellidoMaterno], [Sexo], [FechaNacimiento], [IdNivel], [DniApoderado]) VALUES(@NroDni, @Nombres, @ApellidoPaterno, @ApellidoMaterno, @Sexo, ,@FechaNacimiento, @NroDniApoderado)";
                using (SqlCommand Comando = new SqlCommand(sql1, cn))
                {
                    Comando.Parameters.Add(new SqlParameter("@NroDni", Crear.DNI));
                    Comando.Parameters.Add(new SqlParameter("@Nombres", Crear.Nombres));
                    Comando.Parameters.Add(new SqlParameter("@ApellidoPaterno", Crear.ApellidoPaterno));
                    Comando.Parameters.Add(new SqlParameter("@ApellidoMaterno", Crear.ApellidoMaterno));
                    Comando.Parameters.Add(new SqlParameter("@Sexo", Crear.Sexo));
                    Comando.Parameters.Add(new SqlParameter("@FechaNacimiento", Crear.FechaNacimiento));
                    Comando.Parameters.Add(new SqlParameter("@IdNivel", Crear.IdNivel));
                    Comando.Parameters.Add(new SqlParameter("@DniApoderado", Crear.NroDniApoderado));
                    Comando.ExecuteNonQuery();
                }
                return GetAlumno(Crear.DNI);
            }
        }

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