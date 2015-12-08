using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using termProjectLibrary;

namespace termProject
{
    public partial class Merchant_Home : System.Web.UI.Page
    { int loginId = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (Session["loginId"] != null)
            {
                loginId = Convert.ToInt32(Session["loginId"].ToString());

                merchant merchant = new merchant(loginId);
                string apiKey = merchant.key;
                string siteId = merchant.merchURL;
                DataSet dataSetMerchantTransaction = merchant.MerchantTransaction(siteId, apiKey);
                gvTransaction.DataSource = dataSetMerchantTransaction;
                gvTransaction.DataBind();
            }
            else
                Response.Redirect("LoginPage.aspx");  
            

        }

        protected void gvTransaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            int transactionId = Convert.ToInt32(gvTransaction.SelectedRow.Cells[0].Text);
             loginId = Convert.ToInt32(Session["loginId"].ToString());
             merchant merchantObj = new merchant(loginId);
             DataSet merchantTransactionDetail = merchantObj.MerchantTransactionDetails(transactionId);
             gvTransactionDetails.DataSource = merchantTransactionDetail;
             gvTransactionDetails.DataBind();
        
        }
    }
}
