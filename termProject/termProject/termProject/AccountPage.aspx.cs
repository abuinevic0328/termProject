using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace termProject
{
    public partial class AccountPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDone_Click(object sender, EventArgs e)
        {
            Response.Redirect("MyCart.aspx");
        }

        protected void btnEditPassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("PasswordChange.aspx");

        }

        protected void btnEditName_Click(object sender, EventArgs e)
        {
            Response.Redirect("ResetName.aspx");
        }
    }
}