using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using termProjectLibrary;

namespace termProject
{
    public partial class ClientInfo_CreditCard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Session["email"] = "inastela@gmail.com";
            if (Session["email"] != null)
            {
                string email = Session["email"].ToString();
                customer customerObj = new customer(email);
                string cardNo = customerObj.getCardCreditNumber();
                if (cardNo == "0")
                {
                    noCard_div.Visible = true;
                    Card_div.Visible = false;
                    lblMsg.Text = "There is no credit card connected to this account. You can create one by clicking add button!";
                }
                else
                {
                    noCard_div.Visible = false;
                    Card_div.Visible = true;
                    card cardObj = new card(cardNo);
                    lblName.Text = cardObj.FNAME + " " + cardObj.LNAME;
                    lblCard.Text = cardNo;
                    lblCvv2.Text = Convert.ToString(cardObj.CVV);
                    lblExp.Text = cardObj.EXPDATE;
                }

            }
        }
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            Response.Redirect("ClientInfo_EditCard.aspx");
        }

        protected void btnAddCard_Click(object sender, EventArgs e)
        {
            Response.Redirect("cardManager.aspx");

        }
    }
    }

                