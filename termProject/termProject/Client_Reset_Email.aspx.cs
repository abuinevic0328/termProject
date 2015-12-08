using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;

namespace termProject
{
    public partial class Client_Reset_Email : System.Web.UI.Page
    {

        string email = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["loginId"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }



            if (Session["email"] != null)
                email = Session["email"].ToString();
        }
        protected void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCurrentEmail.Text) || String.IsNullOrEmpty(txtPassword.Text) || String.IsNullOrEmpty(txtNewEmail2.Text))
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Script", "<script> alert('All fields are required.Thank you!'); </script>");
          
            {
                string currentEmail = txtCurrentEmail.Text;
                string passord = txtPassword.Text;
                string newEmail2 = txtNewEmail2.Text;


                SqlCommand emailCmd = new SqlCommand();
                DBConnect objDB = new DBConnect();

                emailCmd.CommandType = CommandType.StoredProcedure;
                emailCmd.CommandText = "dbo.TP_ResetEmail";

                SqlParameter inputEmail = new SqlParameter("@currentEmail", currentEmail);

                inputEmail.Direction = ParameterDirection.Input;
                inputEmail.SqlDbType = SqlDbType.NVarChar;
                inputEmail.Size = 50;
                emailCmd.Parameters.Add(inputEmail);

                SqlParameter inputPassword = new SqlParameter("@password", passord);

                inputPassword.Direction = ParameterDirection.Input;
                inputPassword.SqlDbType = SqlDbType.NVarChar;
                inputPassword.Size = 50;
                emailCmd.Parameters.Add(inputPassword);

                SqlParameter inputEmail2 = new SqlParameter("@newEmail", newEmail2);

                inputEmail2.Direction = ParameterDirection.Input;
                inputEmail2.SqlDbType = SqlDbType.NVarChar;
                inputEmail2.Size = 50;
                emailCmd.Parameters.Add(inputEmail2);

                emailCmd.Parameters.Add("@result", SqlDbType.Int).Direction = ParameterDirection.Output;

                objDB.DoUpdateUsingCmdObj(emailCmd);
                int result = Convert.ToInt32(emailCmd.Parameters["@result"].Value);

                if (result == -1)
                    lblMsg.Text = "The password you entered is incorrect!";

                else if (result == 0)
                {
                    lblMsg.Text = "The new email you entered already exists.";
                }
                else
                {
                    lblMsg.Text = "The email was changed succesfully.";
                }
            }
        }
    }
}
