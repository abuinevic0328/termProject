using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using Project3WS;
using termProjectLibrary;
using Utilities;

namespace termProject
{
    public partial class Clinet_CheckuoutPage : System.Web.UI.Page
    {
        
        cardProcessing.verifyCard pxy = new cardProcessing.verifyCard();
        protected void Page_Load(object sender, EventArgs e)
        {
            int loginID = (int)Session["loginId"];
            if (Session["loginId"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }

            if (!IsPostBack)
            {
                DataSet customerCards = new DataSet();
                
                customerCards = pxy.showCards(loginID);
                ddlCreditCardNums.DataSource = customerCards;
                ddlCreditCardNums.DataTextField = "cardNum";
                ddlCreditCardNums.DataValueField = "cardNum";
                ddlCreditCardNums.DataBind();

                lblOrderTotal.Text = lblOrderTotal.Text + Session["cartTotal"].ToString();

            }
        }

        protected void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            List<cartItem> cartItems = new List<cartItem>();
            cartItems = (List<cartItem>)Session["cart"];

            DBConnect objDB = new DBConnect();
            SqlCommand addPurchase = new SqlCommand();

            addPurchase.CommandType = CommandType.StoredProcedure;
            addPurchase.CommandText = "TP_CustomerTransactions";

            SqlCommand updateProdQuan = new SqlCommand();

            updateProdQuan.CommandType = CommandType.StoredProcedure;
            updateProdQuan.CommandText = "TP_subtractProducts";

            foreach(cartItem obj in cartItems)
            {
                SqlParameter prodID = new SqlParameter("@prodNum", obj.ProdNum);
                prodID.Direction = ParameterDirection.Input;
                prodID.SqlDbType = SqlDbType.Int;
                prodID.Size = 4;
                addPurchase.Parameters.Add(prodID);

                SqlParameter quantity = new SqlParameter("@quantity", obj.ProdQuantity);
                quantity.Direction = ParameterDirection.Input;
                prodID.SqlDbType = SqlDbType.Int;
                prodID.Size = 4;
                addPurchase.Parameters.Add(quantity);

                SqlParameter loginiD = new SqlParameter("@loginID", Convert.ToInt32(Session["loginId"]));
                loginiD.Direction = ParameterDirection.Input;
                loginiD.SqlDbType = SqlDbType.Int;
                loginiD.Size = 4;
                addPurchase.Parameters.Add(loginiD);

                SqlParameter quan = new SqlParameter("@prodNum", obj.ProdNum);
                quan.Direction = ParameterDirection.Input;
                quan.SqlDbType = SqlDbType.Int;
                quan.Size = 4;
                updateProdQuan.Parameters.Add(quan);
                objDB.DoUpdateUsingCmdObj(updateProdQuan);
                
            }
            //SqlCommand removeCart = new SqlCommand();

            //updateProdQuan.CommandType = CommandType.StoredProcedure;
            //updateProdQuan.CommandText = "TP_removeCart";

            //SqlParameter id = new SqlParameter("@custID", Convert.ToInt32(Session["loginId"]));
            //id.Direction = ParameterDirection.Input;
            //id.SqlDbType = SqlDbType.Int;
            //id.Size = 4;
            //objDB.DoUpdateUsingCmdObj(removeCart);

            //List<cartItem> emptyCart = new List<cartItem>();
            //Session["cart"] = emptyCart;
        }
    }
}