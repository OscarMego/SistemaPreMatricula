
using SistemaDePrematricula.AsociadoWSMnt;
using System;
using System.ServiceModel;
using System.Web;
using System.Web.Services;

namespace SistemaDePrematricula
{
    public partial class Asociado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        public static String CrearAsociado(AsociadoWSMnt.Asociado asociado)
        {
            String mesanje = "";
            try
            {
                try
                {
                    AsociadoWSMnt.RegistroServiceClient client = new AsociadoWSMnt.RegistroServiceClient();
                    AsociadoWSMnt.Asociado asociadoCreado = client.CrearAsociado(asociado);
                    if (asociadoCreado != null)
                    {
                        mesanje = "OK|" + asociadoCreado.Token;
                    }
                    else
                    {
                        mesanje = "Hubo probelmas al crear asociado";
                    }
                }
                catch (FaultException<ManejadorException> error)
                {
                    mesanje = error.Reason.ToString() + " " + error.Detail.Descripcion;
                }
            }
            catch (Exception ex)
            {
                mesanje = ex.ToString() + " " + ex.Message;
            }
            return mesanje;
        }
    }
}