using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using termProjectLibrary;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Globalization;

namespace termProject
{
    public partial class Client_Cart : System.Web.UI.Page
    {
        List<cartItem> cartItems;
        TextBox tboxQuantity = new TextBox();
        private double cartTotal;
        private const int SUBTOTAL_COLUMN = 4;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            Label1.Text = "";
            if (Session["loginId"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }
            if (!IsPostBack)
            {
                if (Session["cart"] != null)
                {
                    cartTotal = (double)Session["cartTotal"];
                    Label1.Visible = false;
                    gvCart.DataSource = Session["cart"];
                    gvCart.Columns[SUBTOTAL_COLUMN].FooterText = Convert.ToString(cartTotal);
                    gvCart.DataBind();
                }
                else
                {
                    Label1.Visible = true;
                    Label1.Text = "It looks like your cart is empty!";
                }
            }
            
        }

        protected void gvCart_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            cartItems = new List<cartItem>();
            cartItems = (List<cartItem>)Session["cart"];
            

            int row = Convert.ToInt32(e.CommandArgument.ToString());

            if (e.CommandName == "btnDelete")
            {
                cartTotal = Convert.ToDouble(Session["cartTotal"]);
                double amount = Double.Parse(gvCart.Rows[row].Cells[2].Text, NumberStyles.Currency);
                int quan = Convert.ToInt32(gvCart.Rows[row].Cells[3].Text);
                double removeAmount = (amount * quan);
                cartTotal = cartTotal - removeAmount;
                Session["cartTotal"] = cartTotal;
                cartItems.RemoveAt(row);
               
            }
            if (e.CommandName == "btnUpdate")
            {
                int quantity = Convert.ToInt32(((TextBox)gvCart.Rows[row].FindControl("txtQuantity")).Text);
                if(quantity >= Convert.ToInt32(gvCart.Rows[row].Cells[3].Text))
                {
                    int diff = quantity - Convert.ToInt32(gvCart.Rows[row].Cells[3].Text);

                    double price = Double.Parse(gvCart.Rows[row].Cells[2].Text, NumberStyles.Currency);
                    int quan = Convert.ToInt32(((TextBox)gvCart.Rows[row].FindControl("txtQuantity")).Text);
                    cartTotal = (double)Session["cartTotal"];
                    double sub = (price * quan);
                    double addAmount = (price * diff);
                    cartTotal = cartTotal + addAmount;
                    Session["cartTotal"] = cartTotal;
                    cartItems[row].ProdQuantity = Convert.ToInt32(((TextBox)gvCart.Rows[row].FindControl("txtQuantity")).Text);
                    cartItems[row].SubTotal = sub;
                    //code to add to current cart
                }
                else
                {
                    double diff;
                    double cost;
                    cost = Double.Parse(gvCart.Rows[row].Cells[2].Text, NumberStyles.Currency);
                    double numItemsSubtracting = Convert.ToInt32(gvCart.Rows[row].Cells[3].Text) - quantity;
                    double subtractAmount = (cost * numItemsSubtracting);
                    double currentCartCost = Convert.ToDouble(Session["cartTotal"]);
                    currentCartCost = currentCartCost - subtractAmount;
                    int newAmount = Convert.ToInt32(((TextBox)gvCart.Rows[row].FindControl("txtQuantity")).Text);
                    double sub = (newAmount * cost);
                    Session["cartTotal"] = currentCartCost;
                    cartItems[row].ProdQuantity = Convert.ToInt32(((TextBox)gvCart.Rows[row].FindControl("txtQuantity")).Text);
                    cartItems[row].SubTotal = sub;

                }
            }
            gvCart.DataSource = Session["cart"];
            gvCart.Columns[SUBTOTAL_COLUMN].FooterText = Convert.ToString(Session["cartTotal"]);
            gvCart.DataBind();

            
            
        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            Response.Redirect("Clinet_CheckuoutPage.aspx");
        }

    }
}