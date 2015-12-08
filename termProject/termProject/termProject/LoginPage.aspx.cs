using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using termProjectLibrary;
namespace termProject
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }


        protected void btnLogin_Click2(object sender, EventArgs e)
        {
            if (!IsPostBack && Request.Cookies["CIS3342"] != null)
            {
                HttpCookie cookie = Request.Cookies["CIS3342"];
                txtUserName.Text = cookie.Values["LoginId"].ToString();
                lblMsg.Text = "You last visited " + cookie.Values["LastVisited"].ToString();
            }
            string name = txtUserName.Text;
            string password = txtPassword.Text;
            customer c = new customer();
            int loginId = c.checkCustomer(name, password);
            if (loginId == -1)
                lblMsg.Text = "The email you entered does not exist. Please try again!";
            else
                if (loginId == 0)
                    lblMsg.Text = "Your password is incorrect. Please try again!";
                else
                {
                    Session["loginId"] = loginId;
                    Session["email"] = name;
                       
                    Response.Redirect("storeHome.aspx");
                }
        }

        protected void btnCreateAccount_Click2(object sender, EventArgs e)
        {
            Response.Redirect("registrationPage.aspx");
        }

        protected void chkRemember_CheckedChanged(object sender, EventArgs e)
        {
            HttpCookie myCookie = new HttpCookie("CIS3342");
            if (txtUserName.Text != "")
            {
                myCookie.Values["LoginId"] = txtUserName.Text;
                myCookie.Values["LastVisited"] = DateTime.Now.ToString();
                myCookie.Expires = new DateTime(2025, 1, 1);

                Response.Cookies.Add(myCookie);
            }
            else
            {
                lblMsg.Text = "You should write your username first!";
                chkRemember.Checked = false;
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            LinkButton btnPassword = (LinkButton)(sender);
            string yourValue = btnPassword.CommandArgument;
            Response.Redirect("ForgetPassword.aspx");
         
        }


    }
}