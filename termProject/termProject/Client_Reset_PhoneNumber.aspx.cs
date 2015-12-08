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
    public partial class Client_Reset_PhoneNumber : System.Web.UI.Page
    {

        string email = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["loginId"] == null)
            //{
            //    Response.Redirect("LoginPage.aspx");
            //}



            if (Session["email"] != null)
                email = Session["email"].ToString();
        }

        protected void btnSaveChanges_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtPhonenumber.Text) || String.IsNullOrEmpty(txtCurrentEmail.Text))
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Script", "<script> alert('All fields are required.Thank you!'); </script>");
           
            string email = txtCurrentEmail.Text;
            string newPhone = txtPhonenumber.Text;
            SqlCommand phoneCmd = new SqlCommand();
            DBConnect objDB = new DBConnect();

            phoneCmd.CommandType = CommandType.StoredProcedure;
            phoneCmd.CommandText = "dbo.TP_ResetPhonenumber";

            SqlParameter inputEmail = new SqlParameter("@email", email);
            inputEmail.Direction = ParameterDirection.Input;
            inputEmail.SqlDbType = SqlDbType.NVarChar;
            inputEmail.Size = 50;
            phoneCmd.Parameters.Add(inputEmail);

            SqlParameter inputPhone = new SqlParameter("@newPhone", newPhone);
            inputPhone.Direction = ParameterDirection.Input;
            inputPhone.SqlDbType = SqlDbType.NVarChar;
            inputPhone.Size = 50;
            phoneCmd.Parameters.Add(inputPhone);

            phoneCmd.Parameters.Add("@results", SqlDbType.Int).Direction = ParameterDirection.Output;
            objDB.DoUpdateUsingCmdObj(phoneCmd);
            int result = Convert.ToInt32(phoneCmd.Parameters["@results"].Value);

            if (result == 1)
                lblMsg.Text = "Your phone number was changed succesfully!";
            else if (result == 0)
                lblMsg.Text = "Your phone number was not changed!Please try again";


        }
    }
}