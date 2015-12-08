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
    public partial class Client_Reset_Password : System.Web.UI.Page
    {
        string email = string.Empty;
        string role = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["email"] != null)
                email = Session["email"].ToString();
            role = Session["role"].ToString();
        }

        protected void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCurrentEmail.Text) || String.IsNullOrEmpty(txtCurrentPassword.Text) || String.IsNullOrEmpty(txtNewPassword.Text))
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Script", "<script> alert('All fields are required.Thank you!'); </script>");
           
            SqlCommand pass = new SqlCommand();
            DBConnect objDB = new DBConnect();

           

            //string currentPassword = (string)pass.ExecuteScalar();
            //if (currentPassword == txtCurrentPassword.Text)
            //     { }

            //else
            //    lblMsg.Text = "Please enter your current password again!";
            Salt salt = new Salt();
            string currentEmail = txtCurrentEmail.Text;
            string currentPassword = txtCurrentPassword.Text;
            string newPassword1 = txtNewPassword.Text;
            customer customerObj=new customer();
            int result = customerObj.ResetPassword(currentEmail, currentPassword, newPassword1, salt.ToString(),role);
            if (result == 0)
                lblMsg.Text = "The password you entered is incorrect!";

            else if (result == 1)
                lblMsg.Text = "The password was changed successfully.";
            //  Response.Redirect("LoginPage.aspx");
        }
    }
}