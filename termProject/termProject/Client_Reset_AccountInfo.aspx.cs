using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using termProjectLibrary;

namespace termProject
{
    public partial class Reset_Account_Info : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (Session["email"] != null)
            {
                string email = Session["email"].ToString();
                customer customerObj = new customer(email);
                lblName.Text = customerObj.FName + " " + customerObj.LName;
                lblEmail.Text = customerObj.Email;
                lblPassword.Text = "Not shown for security reason";
                lblPhone.Text = customerObj.PhoneNumber;
            }
            else
                Response.Redirect("ErrorPage.aspx");

        }
            protected void btnDone_Click(object sender, EventArgs e)
        {
            Response.Redirect("MyCart.aspx");
        }

        protected void btnEditPassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("Client_Reset_Password.aspx");

        }

        protected void btnEditName_Click(object sender, EventArgs e)
        {
            Response.Redirect("Client_Reset_Name.aspx");
        }

        protected void btnEditEmail_Click(object sender, EventArgs e)
        {
            Response.Redirect("Client_Reset_Email.aspx");

        }

        protected void btnEditPhone_Click(object sender, EventArgs e)
        {
            Response.Redirect("Client_Reset_PhoneNumber.aspx");

        }

        protected void btnEditPassword_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Client_Reset_Password.aspx");

        }
        }
    }

