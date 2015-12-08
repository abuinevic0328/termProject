using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using termProjectLibrary;
using System.Globalization;

namespace termProject
{
    public partial class Client_StoreHome : System.Web.UI.Page
    {
        List<cartItem> cartItems;
        
        MerchantStore.MerchantStore pxy = new MerchantStore.MerchantStore();
        ErikaGin.MerchantStore EGpxy = new ErikaGin.MerchantStore();
        private int depNum;
        private double cartTotal;


        List<int> prodNums;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            DBConnect objDB = new DBConnect();
            if (Session["loginId"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }
            if (!IsPostBack)
            {
                
                Response.Buffer = true;
                Response.ExpiresAbsolute = DateTime.Now.AddDays(-1d);
                Response.Expires = -1500;
                Response.CacheControl = "no-cache";
                lblAddQuantity.Text = "";
            }
            if (Session["depSelected"] != null)
            {
                lblDepName.Text = Session["depName"].ToString();
                if (!IsPostBack)
                {
                    string depSelected = Session["depSelected"].ToString();
                    DataSet Ourproducts = new DataSet();
                    DataSet GinErikaProducts = new DataSet();
                    Button addCart = new Button();
                    TextBox txtQuantity = new TextBox();
                    Ourproducts = pxy.GetProductCatalog(depSelected);
                    if (Ourproducts.Tables[0].Rows.Count != 0)
                    {
                        Session["dsProd"] = Ourproducts;
                        //List<int> foundNums = productNumber();
                        gvProducts.DataSource = Ourproducts;
                        gvProducts.DataBind();
                    }
                    else
                    {
                        Ourproducts = EGpxy.GetProductCatalog(depSelected);
                        Session["dsProd"] = Ourproducts;
                        //List<int> foundNums = productNumber();
                        EGgridview.DataSource = Ourproducts;
                        EGgridview.DataBind();
                        for (int r = 0; r < EGgridview.Rows.Count; r++)
                        {
                            addCart = (Button)EGgridview.Rows[r].FindControl("btnAdd");
                            addCart.Enabled = false;
                        }
                        //gvProducts.DataSource = Ourproducts;
                        //gvProducts.DataBind();

                    }
                    //GinErikaProducts = EGpxy.GetProductCatalog(depSelected);
                    //Ourproducts.Merge(GinErikaProducts);
                    
                    //for (int r = 0; r < gvProducts.Rows.Count; r++)
                    //{
                    //    if (checkProdAvailability(foundNums.ElementAt(r)) > 0)
                    //    {
                    //        gvProducts.Rows[r].Cells[3].Text = "Item Available";

                    //    }
                    //    else
                    //    {
                    //        gvProducts.Rows[r].Cells[2].Text = "Sold Out";
                    //        addCart = (Button)gvProducts.Rows[r].FindControl("btnAdd");
                    //        txtQuantity = (TextBox)gvProducts.Rows[r].FindControl("txtQuantity");
                    //        txtQuantity.Enabled = false;
                    //        addCart.Enabled = false;
                    //    }
                    //}
                }
            }
        }

        protected void gvProducts_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            cartItems = new List<cartItem>();
            cartItems = (List<cartItem>)Session["cart"];
            int row = Convert.ToInt32(e.CommandArgument);
            cartTotal = (double)Session["cartTotal"];

            if (e.CommandName == "btnAdd")
            {
                if (((TextBox)gvProducts.Rows[row].FindControl("txtQuantity")).Text == "")
                {
                    lblAddQuantity.Text = "* Please enter quantity";
                }
                else
                {
                    int prodNum = Convert.ToInt32(gvProducts.Rows[row].Cells[0].Text);
                    string desc = gvProducts.Rows[row].Cells[1].Text;
                    double price = double.Parse(gvProducts.Rows[row].Cells[2].Text, NumberStyles.Currency);
                    
                    string image = getImageURL(prodNum);
                    int quantity = Convert.ToInt32(((TextBox)gvProducts.Rows[row].FindControl("txtQuantity")).Text);
                    double subTotal = price * quantity;
                    cartItem c = new cartItem(prodNum, desc, price, quantity, subTotal, image);
                    cartTotal += subTotal;
                    cartItems.Add(c);
                    Session["cartTotal"] = cartTotal;
                    lblAddQuantity.Text = "Added '"+desc+"' Successfully";
                }
            }
        }
        private List<int> productNumber()
        {
            prodNums = new List<int>();
            Session["prodNumsList"] = prodNums;
            DataSet pNum = (DataSet)Session["dsProd"];
            foreach (DataRow dr in pNum.Tables[0].Rows)
            {
                prodNums.Add((int)dr["productNum"]);
            }
            return prodNums;
        }
        private string getImageURL(int prodNum)
        {
            string imgURL;
            DataSet url = new DataSet();
            DBConnect objdb = new DBConnect();
            SqlCommand findURL = new SqlCommand();

            findURL.CommandType = CommandType.StoredProcedure;
            findURL.CommandText = "dbo.TP_getImageURL";

            SqlParameter theProductNumber = new SqlParameter("@prodNum", prodNum);
            theProductNumber.Direction = ParameterDirection.Input;
            theProductNumber.SqlDbType = SqlDbType.Int;
            theProductNumber.Size = 4;

            findURL.Parameters.Add(theProductNumber);
            url = objdb.GetDataSetUsingCmdObj(findURL);

            return imgURL = url.Tables[0].Rows[0][0].ToString();
        }
        private int checkProdAvailability(int prodNumber)
        {
            int count;
            DBConnect objdb = new DBConnect();
            DataSet productCount = new DataSet();
            SqlCommand checkQuan = new SqlCommand();

            checkQuan.CommandType = CommandType.StoredProcedure;
            checkQuan.CommandText = "dbo.TP_checkProductAvailable";

            SqlParameter theProductNumber = new SqlParameter("@prodNum", prodNumber);
            theProductNumber.Direction = ParameterDirection.Input;
            theProductNumber.SqlDbType = SqlDbType.Int;
            theProductNumber.Size = 4;

            checkQuan.Parameters.Add(theProductNumber);
            productCount = objdb.GetDataSetUsingCmdObj(checkQuan);
            count = Convert.ToInt32(productCount.Tables[0].Rows[0][0].ToString());
            return count;
        }

        protected void btnGoTo_Click(object sender, EventArgs e)
        {
            Response.Redirect("Client_Cart.aspx");   
        }
    }
}