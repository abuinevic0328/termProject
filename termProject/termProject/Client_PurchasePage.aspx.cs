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
            if (!IsPostBack)
            {
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
        }


        public DataSet transactionHistory(int transactionID)
        {
            int loginId = Convert.ToInt32(Session["loginId"].ToString());
            customer customerObj = new customer();
          DataSet dsHistory=  customerObj.transactionHistory(loginId, transactionID);
          return dsHistory; 
        }
        
        protected void gvPurchases_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gvPurchases.SelectedRow;
            int transactionId = Convert.ToInt32(row.Cells[1].Text);
           DataSet dsHistory= transactionHistory(transactionId);
           if (dsHistory != null)
           {
               yourCurrentCart.DataSource = dsHistory;
               yourCurrentCart.DataBind();
               yourCurrentCart.Visible = true;
               gvPurchases.Visible = false;
           }
        }

    }
    }
