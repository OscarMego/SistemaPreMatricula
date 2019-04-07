using SistemaDePrematricula.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SistemaDePrematricula.Persistencia
{
    public class UsuarioDao
    {
        private string strConexion = "Data Source=.; Database=BdPrematriculas; uid=sa; pwd=1234";
        public Usuario LoginAlumno(string login, string clave)
        {
            Usuario usuario = null;
            string sql = "SELECT[NroDni] DNI,[Nombres]+' '+[ApellidoPaterno]+' '+ [ApellidoMaterno] Nombres  FROM [Alumnos] WHERE [Usuario]=@login AND Password=@clave";
            using (SqlConnection cn=new SqlConnection(strConexion))
            {
                cn.Open();
                using (SqlCommand cmd=new SqlCommand(sql, cn))
                {
                    cmd.Parameters.Add(new SqlParameter("@login", login));
                    cmd.Parameters.Add(new SqlParameter("@clave", clave));
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            usuario = new Usuario()
                            {
                                DNI = dr.GetString(dr.GetOrdinal("DNI")),
                                Nombres=dr.GetString(dr.GetOrdinal("Nombres")),
                                Perfil="Alumno"
                            };
                        }
                    }
                }
            }
                return usuario;
        }
        public Usuario LoginSecretaria(string login, string clave)
        {
            Usuario usuario = null;
            string sql = "SELECT Login, Clave, Nombres+' '+Apellidos Nombres, DNI FROM Usuarios where Login=@login and Clave=@clave";
            using (SqlConnection cn = new SqlConnection(strConexion))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.Add(new SqlParameter("@login", login));
                    cmd.Parameters.Add(new SqlParameter("@clave", clave));
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            usuario = new Usuario()
                            {
                                DNI = dr.GetString(dr.GetOrdinal("DNI")),
                                Nombres = dr.GetString(dr.GetOrdinal("Nombres")),
                                Perfil = "Secretaria"
                            };
                        }
                    }
                }
            }
            return usuario;
        }
    }
}