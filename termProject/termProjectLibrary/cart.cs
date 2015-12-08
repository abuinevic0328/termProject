using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Utilities;

namespace termProjectLibrary
{
    [Serializable]
    public class cart
    {
        cartItem cartitems = new cartItem();
        List<cartItem> cartList;
        
        private int loginID;
        private double cartTotal;
        
        public cart()
        {
            
        }
        public cart(int login, List<cartItem> item, double total)
        {
            this.loginID = login;
            this.cartList = item;
            this.cartTotal = total;
            
        }
        public List<cartItem> CartList
        {
            get { return cartList; }
            set { cartList = value; }
        }
        public int LoginID
        {
            get { return loginID; }
            set { loginID = value; }
        }
        public double CartTotal
        {
            get { return cartTotal; }
            set { cartTotal = value; }
        }
        public Boolean cartExists(int loginID)
        {
            Boolean cartExists = false;

            DataSet cart = new DataSet();
            DBConnect objDB = new DBConnect();
            SqlCommand logID = new SqlCommand();

            logID.CommandType = CommandType.StoredProcedure;
            logID.CommandText = ("TP_findCartByLogin");

            SqlParameter theID = new SqlParameter("@loginID", loginID);
            theID.Direction = ParameterDirection.Input;
            theID.SqlDbType = SqlDbType.Int;
            theID.Size = 4;
            logID.Parameters.Add(theID);

            cart = objDB.GetDataSetUsingCmdObj(logID);
            int size = Convert.ToInt32(cart.Tables[0].Rows[0][0].ToString());

            if (size > 0)
            {
                cartExists = true;
                return cartExists;
            }

            else
            {
                return cartExists;
            }
        }
        public DataSet serializedCart(int loginID)
        {
            DataSet theCart = new DataSet();
            DBConnect objDB = new DBConnect();
            SqlCommand getCart = new SqlCommand();

            getCart.CommandType = CommandType.StoredProcedure;
            getCart.CommandText = "TP_getCart";

            SqlParameter theID = new SqlParameter("@loginID", loginID);
            theID.Direction = ParameterDirection.Input;
            theID.SqlDbType = SqlDbType.Int;
            theID.Size = 4;
            getCart.Parameters.Add(theID);

            theCart = objDB.GetDataSetUsingCmdObj(getCart);

            return theCart;
            //code for getting the cart object
        }
    }
}
