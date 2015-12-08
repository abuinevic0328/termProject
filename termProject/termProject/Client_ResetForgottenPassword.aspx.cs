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
    public partial class Client_ResetForgottenPassword : System.Web.UI.Page
    { 
        bool canChangePass;
        string email="";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["email"] != null)
            {
                 email = Session["email"].ToString();
                string generatedCode = Request.QueryString["code"].ToString();
                customer customerObj = new customer(email);
                if (generatedCode == customerObj.GenerateCode)
                {
                    canChangePass = true;
                }
                else
                    canChangePass = false;
            }
            else
                canChangePass = false;
        }
       
        protected void btnReset_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNewPassword1.Text) || String.IsNullOrEmpty(txtNewPassword2.Text))
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Script", "<script> alert('All fields are required.Thank you!'); </script>");
          
            if (canChangePass)
            {

                Salt salt = new Salt();
                string password1 = txtNewPassword1.Text;
                string password2 = txtNewPassword2.Text;
                if (txtNewPassword1.Text == txtNewPassword2.Text)
                {
                    customer customerObj = new customer();
                    string role = "customer";
                    int result = customerObj.ResetPassword(email, null, password1, salt.ToString(),role);


                    if (result == 0)
                        lblMsg.Text = "The password you entered is incorrect!";

                    else if (result == 1)
                        lblMsg.Text = "The password was changed successfully.";


                }

            }
            else
                lblMsg.Text = "You do not have authorization to access this email address.";
           
        }
    }
}