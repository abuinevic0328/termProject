using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using termProjectLibrary;
using Utilities;

namespace termProject
{
    public partial class Client_Reset_Name : System.Web.UI.Page
    {
        string email = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["email"] != null)
                email = Session["email"].ToString();
        }
        //if (String.IsNullOrEmpty(input_name.Text))
        //        Page.ClientScript.RegisterStartupScript(this.GetType(), "Script", "<script> alert('All fields are required.Thank you!'); </script>");
          
       
    }
}