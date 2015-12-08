using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using termProjectLibrary;

namespace termProject
{
    public partial class registrationPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            double numbers;
            string value;
            string value1;
            int value2;
            string value3;
            int value4;
            int value5;

            
            if (Regex.IsMatch(txtFirstName.Text, @"^[\p{L}]+$"))
            {
                value = Convert.ToString(txtFirstName.Text);
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Script", "<script> alert('Please enter your name correctly! This is a letter field only'); </script>");
                return;

            }
            if (Regex.IsMatch(txtLastName.Text, @"^[\p{L}]+$"))
            {
                value1 = Convert.ToString(txtLastName.Text);
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Script", "<script> alert('Please enter your lastname correctly! This is a letter field only'); </script>");
                return;

            }
            if (double.TryParse(txtPhone.Text, out numbers))
            {
                value5 = int.Parse(txtPhone.Text);
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Script", "<script> alert('Please enter your phone number again. No letters are allowed!'); </script>");
                return;
            }
            
            if (double.TryParse(txtZip.Text, out numbers))
            {
                value2 = int.Parse(txtZip.Text);
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Script", "<script> alert('Please enter a 5 digit number for you zip code!'); </script>");
                return;
            }
            
            if (Regex.IsMatch(txtBillingCity.Text, @"^[\p{L}]+$"))
            {
                value3 = Convert.ToString(txtBillingCity.Text);
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Script", "<script> alert('Please enter the city correctly. Only letters are accepted.'); </script>");
                return;
            }

            if (double.TryParse(txtBillingZip.Text, out numbers))
            {
                value4 =int.Parse(txtBillingZip.Text);
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Script", "<script> alert('Please enter the zip code correctly. Only numbers are accepted.'); </script>");
                return;
            }

            if (String.IsNullOrEmpty(txtFirstName.Text) || String.IsNullOrEmpty(txtLastName.Text) || String.IsNullOrEmpty(txtEmail.Text)
                || String.IsNullOrEmpty(txtBillingAdr.Text) || String.IsNullOrEmpty(txtBillingCity.Text) ||
                    String.IsNullOrEmpty(txtPassword.Text) || String.IsNullOrEmpty(txtAddress.Text) ||
                    String.IsNullOrEmpty(txtCity.Text) || String.IsNullOrEmpty(txtCity.Text) ||
                    String.IsNullOrEmpty(txtBillingZip.Text) || String.IsNullOrEmpty(txtZip.Text))
           Page.ClientScript.RegisterStartupScript(this.GetType(), "Script", "<script> alert('Please fill all the required fields. Thank you!'); </script>");
          
            
            string fName = txtFirstName.Text;
            string lName = txtLastName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string shipAddress = txtAddress.Text;
            string cityShipping = txtCity.Text;
            string stateShipping = ddlState1.SelectedValue;
            int zipShipping = Convert.ToInt32(txtZip.Text);
            string phoneNo = txtPhone.Text;
            string billAddress = txtBillingAdr.Text;
            string cityBilling = txtBillingCity.Text;
            string stateBilling = ddlState2.SelectedValue;
            int zipBilling = Convert.ToInt32(txtBillingZip.Text);
           
            customer c = new customer();

            int customerId = c.registerCustomer(email, password, fName, lName, shipAddress, billAddress,
                                     phoneNo, cityBilling, cityShipping, stateShipping,
                                     stateBilling, Convert.ToString(zipShipping), Convert.ToString(zipBilling));
            if (customerId < 1)
                lblMsg.Text = "Registration is not succesful, try again!";
            else

            { lblMsg.Text = "--Registration is succesful";
            Session["loginId"] = customerId;
            Button1.Visible = true;
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = " ";
            txtLastName.Text = " ";
            txtEmail.Text = " ";
            txtPassword.Text = " ";
            txtAddress.Text = " ";
            txtCity.Text = " ";
            txtZip.Text = " ";
            txtPhone.Text = " ";
            txtBillingAdr.Text = " ";
            txtBillingCity.Text = " ";
            txtBillingZip.Text = " ";

        }

        protected void btnChecked(object sender, EventArgs e)
        {
            if (chkSameBilling.Checked == true)
            {
                txtBillingAdr.Enabled = false;
                txtBillingAdr.Text = txtAddress.Text;
                txtBillingCity.Enabled = false;
                txtBillingCity.Text = txtCity.Text;
                txtBillingZip.Enabled = false;
                txtBillingZip.Text = txtZip.Text;
                ddlState2.Enabled = false;
                ddlState2.SelectedValue = ddlState1.SelectedValue;
            }
            else
            {
                txtBillingAdr.Enabled = true;
                txtBillingAdr.Text = "";
                txtBillingCity.Enabled = true;
                txtBillingCity.Text = "";
                txtBillingZip.Enabled = true;
                txtBillingZip.Text = "";
                ddlState2.Enabled = true;
               

            }
        }

        protected void chkRemember_CheckedChanged(object sender, EventArgs e)
        {
            HttpCookie myCookie = new HttpCookie("CIS3342");
            if (txtEmail.Text != "")
            {
               myCookie.Values["LoginId"] = txtEmail.Text;
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("storeHome.aspx");
        }
    }
}