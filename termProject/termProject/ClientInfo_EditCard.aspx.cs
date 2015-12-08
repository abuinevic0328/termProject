using System;
using System.Collections.Generic;
using System.Linq;
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
                string email = Session["email"].ToString();
                customer customerObj = new customer(email);
                string cardNo = customerObj.getCardCreditNumber();
                card cardObj = new card(cardNo);
                txtCardNumber.Text = cardNo;
                txtCardNumber.Enabled = false;

                txtLname.Text=cardObj.LNAME;
                txtLname.Enabled=true;

                txtCvv.Text = Convert.ToString(cardObj.CVV);
                txtCvv.Enabled = true;

                txtExpDate.Text=cardObj.EXPDATE;
                txtExpDate.Enabled=true;

                txtFirstname.Text = cardObj.FNAME;
                txtFirstname.Enabled = true;

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