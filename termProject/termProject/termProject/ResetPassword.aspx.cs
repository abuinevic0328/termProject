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
    public partial class PasswordChange : System.Web.UI.Page
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
                SqlCommand pass = new SqlCommand();
                DBConnect objDB = new DBConnect();

                pass.CommandType = CommandType.StoredProcedure;
                pass.CommandText = "dbo.TP_ResetPassword";
            
            //string currentPassword = (string)pass.ExecuteScalar();
            //if (currentPassword == txtCurrentPassword.Text)
            //     { }

            //else
            //    lblMsg.Text = "Please enter your current password again!";
  
                string currentEmail = txtCurrentEmail.Text;
                string currentPassword = txtCurrentPassword.Text;
                string newPassword1 = txtNewPassword.Text;
               
              SqlParameter inputEmail = new SqlParameter("@email", currentEmail);

                inputEmail.Direction = ParameterDirection.Input;
                inputEmail.SqlDbType = SqlDbType.NVarChar;
                inputEmail.Size = 50;
                pass.Parameters.Add(inputEmail);

                SqlParameter inputPassword = new SqlParameter("@currentPass", currentPassword);

                inputPassword.Direction = ParameterDirection.Input;
                inputPassword.SqlDbType = SqlDbType.NVarChar;
                inputPassword.Size = 50;
                pass.Parameters.Add(inputPassword);

                SqlParameter inputPassword1 = new SqlParameter("@newPass", newPassword1);

                inputPassword1.Direction = ParameterDirection.Input;
                inputPassword1.SqlDbType = SqlDbType.NVarChar;
                inputPassword1.Size = 50;
                pass.Parameters.Add(inputPassword1);

                pass.Parameters.Add("@returnId", SqlDbType.Int).Direction = ParameterDirection.Output;

                objDB.DoUpdateUsingCmdObj(pass);
                int result = Convert.ToInt32(pass.Parameters["@returnId"].Value);

                if (result == 1)
                    lblMsg.Text = "The password you entered is incorrect!";

                else if (result == 0)
                    lblMsg.Text = "The password was not changed.";
                //  Response.Redirect("LoginPage.aspx");
        }
    }
}