using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace SistemaDePrematricula
{
    public partial class ReservaNuevo : System.Web.UI.Page
    {
       

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void datepicker_SelectionChanged(object sender, EventArgs e)
        {
            txtdtp.Text = datepicker.SelectedDate.ToShortDateString();
            datepicker.Visible = false;
        }

        protected void lnkpickdate_Click(object sender, EventArgs e)
        {
            datepicker.Visible = true;
        }

        protected void btnRRegistro_Click(object sender, EventArgs e)
        {
            

        }
    }
}