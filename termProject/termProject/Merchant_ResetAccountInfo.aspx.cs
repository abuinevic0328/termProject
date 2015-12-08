using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using termProjectLibrary;

namespace termProject
{
    public partial class Merchant_ResetAccountInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           int merchantId = 1;
           if (Session["email"] != null)
           {
               string email = Session["email"].ToString();

               merchant merchantObj = new merchant(merchantId);

               lblMember1.Text = merchantObj.Member1;
               lblMmb2.Text = merchantObj.Member2;
               lblPhone.Text = merchantObj.PhoneNum;
               lblDescription.Text = merchantObj.Description;
               lblApiKey.Text = merchantObj.key;

           }


        }

    }
}
    
