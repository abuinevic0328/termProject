using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using termProjectLibrary;
using Utilities;

namespace termProject
{
    public partial class Client_PurchasePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int loginId = 1;
            if (Session["email"] != null)
            {
                string email = Session["email"].ToString();
                customer customer = new customer(email);
                loginId = customer.LoginId;
                DataSet customerTransaction = customer.customerTransaction(loginId);
                gvPurchases.DataSource = customerTransaction;
                gvPurchases.DataBind();
            }
            else
                Response.Redirect("LoginPage.aspx");  
        }

          
        public void transactionHistory( int transactionID)
        {
            int loginId = Convert.ToInt32(Session["loginId"].ToString());
            customer customerObj = new customer();
            customerObj.transactionHistory(loginId, transactionID);
        }

   
        protected void gvPurchases_SelectedIndexChanged(object sender, EventArgs e)
        {
            int transactionId = Convert.ToInt32(gvPurchases.SelectedRow.Cells[0].Text);
            transactionHistory(transactionId);
        }
            
        } //e ka
    }
