using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using termProjectLibrary;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using Utilities;

namespace termProject
{
    public class Global : System.Web.HttpApplication
    {
        List<cartItem> cartItems;
        cart c = new cart();

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            DBConnect objDB = new DBConnect();
            


            cartItems = new List<cartItem>();
            cartItems = (List<cartItem>)Session["cart"];
            if (cartItems != null)
            {
                cart thecart = new cart(Convert.ToInt32(Session["loginID"]), cartItems, Convert.ToDouble(Session["cartTotal"]));
                BinaryFormatter serializer = new BinaryFormatter();
                MemoryStream memStream = new MemoryStream();
                serializer.Serialize(memStream, thecart);

                byte[] byteArray;
                byteArray = memStream.ToArray();
                int loginId = Convert.ToInt32(Session["loginID"]);
                double cartTotal = Convert.ToDouble(Session["cartTotal"]);

                if (c.cartExists(Convert.ToInt32(Session["loginID"])) == false)
                {
                    //Add new cart for customer
                    SqlCommand addCart = new SqlCommand();
                    addCart.CommandType = CommandType.StoredProcedure;
                    addCart.CommandText = "dbo.TP_addCart";

                    SqlParameter cartBytes = new SqlParameter("@theCart", byteArray);
                    cartBytes.Direction = ParameterDirection.Input;
                    cartBytes.SqlDbType = SqlDbType.VarBinary;
                    cartBytes.Size = 8000;
                    addCart.Parameters.Add(cartBytes);

                    SqlParameter login = new SqlParameter("@loginID", loginId);
                    login.Direction = ParameterDirection.Input;
                    login.SqlDbType = SqlDbType.Int;
                    login.Size = 4;
                    addCart.Parameters.Add(login);

                    SqlParameter total = new SqlParameter("@cartTotal", cartTotal);
                    total.Direction = ParameterDirection.Input;
                    total.SqlDbType = SqlDbType.NVarChar;
                    total.Size = 50;
                    addCart.Parameters.Add(total);

                    objDB.DoUpdateUsingCmdObj(addCart);
                }
                else
                {
                    SqlCommand updateCart = new SqlCommand();

                    updateCart.CommandType = CommandType.StoredProcedure;
                    updateCart.CommandText = "TP_updateCartObject";

                    SqlParameter newCart = new SqlParameter("@theCart", byteArray);
                    newCart.Direction = ParameterDirection.Input;
                    newCart.SqlDbType = SqlDbType.VarBinary;
                    newCart.Size = 8000;
                    updateCart.Parameters.Add(newCart);

                    SqlParameter login = new SqlParameter("loginID", loginId);
                    login.Direction = ParameterDirection.Input;
                    login.SqlDbType = SqlDbType.Int;
                    login.Size = 4;
                    updateCart.Parameters.Add(login);

                    SqlParameter total = new SqlParameter("@cartTotal", cartTotal);
                    total.Direction = ParameterDirection.Input;
                    total.SqlDbType = SqlDbType.NVarChar;
                    total.Size = 50;
                    updateCart.Parameters.Add(total);

                    objDB.DoUpdateUsingCmdObj(updateCart);
                    //update cart on file

                }


                //db code goes here to write to TP_CART
            }
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}