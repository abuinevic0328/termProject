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
    public partial class ResetName : System.Web.UI.Page
    {
        string email = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
                if (Session["email"] != null)
                email = Session["email"].ToString();
        }

        protected void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string email = txtCurrentEmail.Text;
            string newName = txtNewName.Text;

            SqlCommand name = new SqlCommand();
            DBConnect objDB = new DBConnect();

            name.CommandType = CommandType.StoredProcedure;
            name.CommandText = "dbo.TP_ResetName";

            SqlParameter inputEmail = new SqlParameter("@email", email);
            inputEmail.Direction = ParameterDirection.Input;
            inputEmail.SqlDbType = SqlDbType.NVarChar;
            inputEmail.Size = 50;
            name.Parameters.Add(inputEmail);
            
            SqlParameter inputName = new SqlParameter("@newName", newName);
            inputName.Direction = ParameterDirection.Input;
            inputName.SqlDbType = SqlDbType.NVarChar;
            inputName.Size = 50;
            name.Parameters.Add(inputName);

           name.Parameters.Add("@result", SqlDbType.Int).Direction = ParameterDirection.Output;
           objDB.DoUpdateUsingCmdObj(name);
                int result = Convert.ToInt32(name.Parameters["@result"].Value);

            if (result == 1)
                  lblMsg.Text = "Your name was changed succesfully!";
            else if (result==0)
                  lblMsg.Text = "Your name was not changed!";


            
        }
    }
}