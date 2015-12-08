using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using termProjectLibrary;

namespace termProject
{
    public partial class ForgetPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnContinue_Click(object sender, EventArgs e)
        {
            string message = string.Empty;
            if (txtForgetEmail.Text != null)
            {
                string email = txtForgetEmail.Text;
                customer customerObj = new customer();

                if (customerObj.existCustomerByEmail(email))
                {
                    Salt generatedCode = new Salt();
                    Session["email"] = email;
                    Session["role"] = "customer";
                    customerObj.insertGeneratedCode(generatedCode.ToString(), email);
                    string emailFrom = "abcsupport@gmail.com";
                    string emailTo = email;
                    string subject = "Reset password";

                    message = "You have requested to change your password. Click <a href='Client_ResetPassword.aspx?code='"+generatedCode+"''> here</a> to reset you password.";
                  
                    Email objEmail = new Email();
                    objEmail.SendMail(emailTo, emailFrom, subject, message);
                    lblMsg1.Text = "The email was sent.";
                }
                else
                    lblMsg1.Text = "This email is not connected to any account!";
            }
            else
            {
                lblMsg1.Text = "Please fill the form with the new password";
                
 
            }
        }
    }
}