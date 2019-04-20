using ServicioGestionSolicitudes.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ServicioGestionSolicitudes.Persistencia
{
    public class ApoderadoDao
    {
        private string strConexion = "Data Source=.;Initial Catalog=BdPrematriculas;Integrated Security=True";

        public Apoderado PostApoderado(Apoderado Crear)
        {
            using (SqlConnection cn = new SqlConnection(strConexion))
            {
                cn.Open();
                string sql1 = "INSERT INTO[dbo].[Apoderados]([NroDni], [Nombres], [ApellidoPaterno], [ApellidoMaterno], [Direccion], [NroCelular], [Correo], [Parentesco]) VALUES(@NroDni, @Nombres, @ApellidoPaterno, @ApellidoMaterno, @Direccion, @NroCelular, @Correo, @Parentesco)";
                using (SqlCommand Comando = new SqlCommand(sql1, cn))
                {
                    Comando.Parameters.Add(new SqlParameter("@NroDni", Crear.NroDni));
                    Comando.Parameters.Add(new SqlParameter("@Nombres", Crear.Nombres));
                    Comando.Parameters.Add(new SqlParameter("@ApellidoPaterno", Crear.ApellidoPaterno));
                    Comando.Parameters.Add(new SqlParameter("@ApellidoMaterno", Crear.ApellidoMaterno));
                    Comando.Parameters.Add(new SqlParameter("@Direccion", Crear.Direccion));
                    Comando.Parameters.Add(new SqlParameter("@NroCelular", Crear.NroCelular));
                    Comando.Parameters.Add(new SqlParameter("@Correo", Crear.Correo));
                    Comando.Parameters.Add(new SqlParameter("@Parentesco", Crear.Parentesco));
                    Comando.ExecuteNonQuery();
                }
                return GetApoderado(Crear.NroDni);
            }
        }

        public Apoderado PutApoderado(Apoderado Modificar)
        {
            using (SqlConnection cn = new SqlConnection(strConexion))
            {
                cn.Open();
                string sql1 = "UPDATE [dbo].[Apoderados] SET[Nombres] = @Nombres, [ApellidoPaterno] = @ApellidoPaterno, [ApellidoMaterno] =@ApellidoMaterno, [Direccion] = @Direccion, [NroCelular] =@NroCelular, [Correo] = @Correo, [Parentesco] = @Parentesco";
                using (SqlCommand Comando = new SqlCommand(sql1, cn))
                {
                    Comando.Parameters.Add(new SqlParameter("@Nombres", Modificar.Nombres));
                    Comando.Parameters.Add(new SqlParameter("@ApellidoPaterno", Modificar.ApellidoPaterno));
                    Comando.Parameters.Add(new SqlParameter("@ApellidoMaterno", Modificar.ApellidoMaterno));
                    Comando.Parameters.Add(new SqlParameter("@Direccion", Modificar.Direccion));
                    Comando.Parameters.Add(new SqlParameter("@NroCelular", Modificar.NroCelular));
                    Comando.Parameters.Add(new SqlParameter("@Correo", Modificar.Correo));
                    Comando.Parameters.Add(new SqlParameter("@Parentesco", Modificar.Parentesco));
                    Comando.ExecuteNonQuery();
                }
                return GetApoderado(Modificar.NroDni);
            }
        }

        public Apoderado GetApoderado(string dni)
        {
            Apoderado apoderado = null;
            string sql = "SELECT [NroDni],[Nombres],[ApellidoPaterno],[ApellidoMaterno],[Direccion],[NroCelular],[Correo],[Parentesco] FROM [Apoderados] where NroDni=@NroDni";
            using (SqlConnection cn = new SqlConnection(strConexion))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.Add(new SqlParameter("@NroDni", dni));
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            apoderado = new Apoderado()
                            {
                                NroDni = dr.GetString(dr.GetOrdinal("NroDni")),
                                Nombres = dr.GetString(dr.GetOrdinal("Nombres")),
                                ApellidoPaterno = dr.GetString(dr.GetOrdinal("ApellidoPaterno")),
                                ApellidoMaterno = dr.GetString(dr.GetOrdinal("ApellidoMaterno")),
                                Direccion = dr.GetString(dr.GetOrdinal("Direccion")),
                                NroCelular = dr.GetString(dr.GetOrdinal("NroCelular")),
                                Correo = dr.GetString(dr.GetOrdinal("Correo")),
                                Parentesco = dr.GetString(dr.GetOrdinal("Parentesco"))
                            };
                        }
                    }
                }
            }
            return apoderado;
        }
    }
}