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
        public void delete(string Dni, string anho)
        {
            using (SqlConnection cn = new SqlConnection(strConexion))
            {
                cn.Open();
                string sql = "DELETE FROM [dbo].[Estudiante] WHERE Dni=@Dni and anho=@anho";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.Add(new SqlParameter("@Dni", Dni));
                    cmd.Parameters.Add(new SqlParameter("@anho", anho));
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}