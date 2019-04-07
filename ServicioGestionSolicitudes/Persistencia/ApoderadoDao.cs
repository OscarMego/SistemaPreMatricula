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
        private string strConexion = "Data Source=.; Database=BdPrematriculas; uid=sa; pwd=1234";
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