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
    public partial class ClientInfo_EditCard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["email"] = "inastela@gmail.com";
            if (Session["email"] != null)
            {

                double numbers;
                int value1;
                string value2;
                string value3;
                int value4;
                string value5;

                if (double.TryParse(txtCardNumber.Text, out numbers))
                {
                    value1 = int.Parse(txtCardNumber.Text);
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Script", "<script> alert('Please enter your phone number again. No letters are allowed!'); </script>");
                    return;
                }

                if (Regex.IsMatch(txtLname.Text, @"^[\p{L}]+$"))
                {
                    value2 = Convert.ToString(txtLname.Text);
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Script", "<script> alert('Please enter your last name correctly! This is a letter field only'); </script>");
                    return;

                }
                if (Regex.IsMatch(txtFirstname.Text, @"^[\p{L}]+$"))
                {
                    value3 = Convert.ToString(txtFirstname.Text);
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Script", "<script> alert('Please enter your first name correctly! This is a letter field only'); </script>");
                    return;

                }


                if (double.TryParse(txtCvv.Text, out numbers))
                {
                    value4 = int.Parse(txtCvv.Text);
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Script", "<script> alert('Please enter a 5 digit number for you zip code!'); </script>");
                    return;
                }

                if (Regex.IsMatch(txtExpDate.Text, @"^[\p{L}]+$"))
                {
                    value5 = Convert.ToString(txtExpDate.Text);
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Script", "<script> alert('Please enter the city correctly. Only letters are accepted.'); </script>");
                    return;
                }

                if (String.IsNullOrEmpty(txtCardNumber.Text) || String.IsNullOrEmpty(txtLname.Text) || String.IsNullOrEmpty(txtFirstname.Text)
                    || String.IsNullOrEmpty(txtCvv.Text) || String.IsNullOrEmpty(txtExpDate.Text))
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Script", "<script> alert('Please fill all the required fields. Thank you!'); </script>");
          
                string email = Session["email"].ToString();
                customer customerObj = new customer(email);
                string cardNo = customerObj.getCardCreditNumber();
                card cardObj = new card(cardNo);
                txtCardNumber.Text = cardNo;
                txtCardNumber.Enabled = false;

                txtLname.Text=cardObj.LNAME;
                txtLname.Enabled=true;

                txtFirstname.Text = cardObj.FNAME;
                txtFirstname.Enabled = true;

                txtCvv.Text = Convert.ToString(cardObj.CVV);
                txtCvv.Enabled = true;

                txtExpDate.Text=cardObj.EXPDATE;
                txtExpDate.Enabled=true;

            
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtCardNumber.Text = "";
            txtFirstname.Text = "";
            txtLname.Text = "";
            txtCvv.Text = "";
            txtExpDate.Text = "";

        }
    }
}