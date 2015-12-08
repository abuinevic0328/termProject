using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace termProject
{
    public partial class ResetMerchantName : System.Web.UI.Page
    {
        string email = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["loginId"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }

            Response.Buffer = true;
            Response.ExpiresAbsolute = DateTime.Now.AddDays(-1d);
            Response.Expires = -1500;
            Response.CacheControl = "no-cache";

            if (Session["email"] != null)
                email = Session["email"].ToString();
        }

        protected void btnSaveChanges_Click(object sender, EventArgs e)
        {

        }
    }
}