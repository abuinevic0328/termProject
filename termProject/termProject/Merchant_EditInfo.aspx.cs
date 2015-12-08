using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using termProjectLibrary;

namespace termProject
{
    public partial class Merchant_EditInfo : System.Web.UI.Page
    {
        string email = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
         
                

            if (Session["email"] != null)
            {
                email = Session["email"].ToString();
                int merchantId = 1;

                merchant merchantObj = new merchant(merchantId);


                txtMember1Name.Text = merchantObj.Member1;
                txtMember1Name.Enabled = false;

                txtMember2Name.Text = merchantObj.Member2;
                txtMember2Name.Enabled = true;

                txtPhone.Text = merchantObj.PhoneNum;
                txtPhone.Enabled = true;

                txtDescription.Text = merchantObj.Description;
                txtDescription.Enabled = true;

            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMember1Name.Text) || String.IsNullOrEmpty(txtMember2Name.Text) || String.IsNullOrEmpty(txtPhone.Text) || String.IsNullOrEmpty(txtDescription.Text))
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Script", "<script> alert('All fields are required.Thank you!'); </script>");
        }
    }
}

