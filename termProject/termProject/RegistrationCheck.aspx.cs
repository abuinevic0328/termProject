using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace termProject
{
    public partial class RegistrationCheck : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCustomer_Click(object sender, EventArgs e)
        {
            Response.Redirect("registrationPage.aspx");
        }

        protected void btnMerchant_Click(object sender, EventArgs e)
        {
            Response.Redirect("merchantRegistrationPage.aspx");

        }
    }
}