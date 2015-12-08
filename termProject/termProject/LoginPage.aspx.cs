using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using termProjectLibrary;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace termProject
{
    public partial class LoginPage : System.Web.UI.Page
    {
        cart theCart = new cart();
        double cartTotal = 0.0;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
            if (!IsPostBack)
            {
                Session.Abandon();
                
            }
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
            string role;
            if (rdbCustomer.Checked)
                role = "Customer";
            else
                role = "Merchant";
            int loginId = c.checkCustomer(name, password,role);
            if (loginId == -1)
                lblMsg.Text = "The email you entered does not exist as "+ role +". Please try again!";
            else
                if (loginId == 0)
                    lblMsg.Text = "Your password is incorrect. Please try again!";
                else
                {
                    Session["loginId"] = loginId;
                    Session["email"] = name;

                    //Check database for existing cart. If exists associate that object with session
                    
                    
                    Session["role"] = role;
                    if (role == "Customer")
                    {
                        if (theCart.cartExists(Convert.ToInt32(Session["loginID"])) == false)
                        {
                            List<cartItem> cartItems = new List<cartItem>();
                            cart newCart = new cart();
                            Session["cartTotal"] = cartTotal;
                            Session["cart"] = cartItems;
                        }
                        else
                        {
                            byte[] byteArray = (Byte[])theCart.serializedCart(Convert.ToInt32(Session["loginID"])).Tables[0].Rows[0][0];

                            BinaryFormatter deSerializer = new BinaryFormatter();
                            MemoryStream memStream = new MemoryStream(byteArray);

                            cart objCart = (cart)deSerializer.Deserialize(memStream);
                            Session["cart"] = objCart.CartList;
                            Session["cartTotal"] = objCart.CartTotal;
                        }
                        Response.Redirect("Client_StoreHome.aspx");
                    }
                    else
                    {
                        Response.Redirect("Merchant_Home.aspx");
                    }
                }
        }
        
        protected void btnCreateAccount_Click2(object sender, EventArgs e)
        {
            Response.Redirect("RegistrationCheck.aspx");
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