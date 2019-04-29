using ServicioSITECE.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ServicioSITECE.Persistencia
{
    public class AsociadoDao
    {
        private string strConexion = "Data Source=.;Initial Catalog=SITECE;Integrated Security=True";
        public Asociado getAsociado(string codigoModular, string token)
        {
            Asociado asociado = null;
            using (SqlConnection cn = new SqlConnection(strConexion))
            {
                cn.Open();
                string sql = "SELECT [IdAsociado],[CodigoModular],[NombreColegio],[Email],[Token] FROM [Asociado] WHERE (@CodigoModular='' OR CodigoModular=@CodigoModular) AND (@token='' OR Token=@Token)";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.Add(new SqlParameter("@CodigoModular", codigoModular));
                    cmd.Parameters.Add(new SqlParameter("@token", token));
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            asociado = new Asociado()
                            {
                                IdAsociado = dr.GetInt64(dr.GetOrdinal("IdAsociado")),
                                CodigoModular = dr.GetString(dr.GetOrdinal("CodigoModular")),
                                NombreColegio = dr.GetString(dr.GetOrdinal("NombreColegio")),
                                Email = dr.GetString(dr.GetOrdinal("Email")),
                                Token = dr.GetString(dr.GetOrdinal("Token")),
                            };
                        }
                    }
                }
            }
            return asociado;
        }
        public Asociado insert(Asociado asociado)
        {
            using (SqlConnection cn = new SqlConnection(strConexion))
            {
                cn.Open();
                string sql = "INSERT INTO [dbo].[Asociado] ([CodigoModular] ,[NombreColegio] ,[Email] ,[Token])  VALUES (@CodigoModular, @NombreColegio,@Email,@Token)";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.Add(new SqlParameter("@CodigoModular", asociado.CodigoModular));
                    cmd.Parameters.Add(new SqlParameter("@NombreColegio", asociado.NombreColegio));
                    cmd.Parameters.Add(new SqlParameter("@Email", asociado.Email));
                    cmd.Parameters.Add(new SqlParameter("@Token", asociado.Token));
                    cmd.ExecuteNonQuery();
                }
            }
            return getAsociado(asociado.CodigoModular, asociado.Token);
        }
    }
}