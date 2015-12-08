using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using System.Data;
using System.Data.SqlClient;
using Utilities;


namespace Project3WS
{
    /// <summary>
    /// Summary description for verifyCard
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class verifyCard : System.Web.Services.WebService
    {
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();
        //CardInfo card = new CardInfo();
        

        //webmethod to add customer information to database from Array
        [WebMethod]
        public void AddCustomer(object[] cust)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "dbo.addCustomer1Address";

            if (cust.Length == 6)
            {
                SqlParameter inputFName = new SqlParameter("@FName", cust[0].ToString());
                inputFName.Direction = ParameterDirection.Input;
                inputFName.SqlDbType = SqlDbType.NVarChar;
                inputFName.Size = 50;
                objCommand.Parameters.Add(inputFName);

                SqlParameter inputLName = new SqlParameter("@LName", cust[1].ToString());
                inputLName.Direction = ParameterDirection.Input;
                inputLName.SqlDbType = SqlDbType.NVarChar;
                inputLName.Size = 50;
                objCommand.Parameters.Add(inputLName);

                SqlParameter inputAddress1 = new SqlParameter("@Address1", cust[2].ToString());
                inputAddress1.Direction = ParameterDirection.Input;
                inputAddress1.SqlDbType = SqlDbType.NVarChar;
                inputAddress1.Size = 50;
                objCommand.Parameters.Add(inputAddress1);

                SqlParameter City = new SqlParameter("@City", cust[3].ToString());
                City.Direction = ParameterDirection.Input;
                City.SqlDbType = SqlDbType.NVarChar;
                City.Size = 50;
                objCommand.Parameters.Add(City);

                SqlParameter State = new SqlParameter("@State", cust[4].ToString());
                State.Direction = ParameterDirection.Input;
                State.SqlDbType = SqlDbType.NVarChar;
                State.Size = 50;
                objCommand.Parameters.Add(State);

                SqlParameter Zip = new SqlParameter("@Zip", cust[5].ToString());
                Zip.Direction = ParameterDirection.Input;
                Zip.SqlDbType = SqlDbType.NVarChar;
                Zip.Size = 50;
                objCommand.Parameters.Add(Zip);

                objDB.DoUpdateUsingCmdObj(objCommand);
            }
            else
            {
                objCommand.CommandText = "dbo.addCustomerAddress";

                SqlParameter inputFName = new SqlParameter("@FName", cust[0].ToString());
                inputFName.Direction = ParameterDirection.Input;
                inputFName.SqlDbType = SqlDbType.NVarChar;
                inputFName.Size = 50;
                objCommand.Parameters.Add(inputFName);

                SqlParameter inputLName = new SqlParameter("@LName", cust[1].ToString());
                inputLName.Direction = ParameterDirection.Input;
                inputLName.SqlDbType = SqlDbType.NVarChar;
                inputLName.Size = 50;
                objCommand.Parameters.Add(inputLName);

                SqlParameter inputAddress1 = new SqlParameter("@Address1", cust[2].ToString());
                inputAddress1.Direction = ParameterDirection.Input;
                inputAddress1.SqlDbType = SqlDbType.NVarChar;
                inputAddress1.Size = 50;
                objCommand.Parameters.Add(inputAddress1);

                SqlParameter inputAddress2 = new SqlParameter("@Address2", cust[3].ToString());
                inputAddress2.Direction = ParameterDirection.Input;
                inputAddress2.SqlDbType = SqlDbType.NVarChar;
                inputAddress2.Size = 50;
                objCommand.Parameters.Add(inputAddress2);

                SqlParameter City = new SqlParameter("@City", cust[4].ToString());
                City.Direction = ParameterDirection.Input;
                City.SqlDbType = SqlDbType.NVarChar;
                City.Size = 50;
                objCommand.Parameters.Add(City);

                SqlParameter State = new SqlParameter("@State", cust[5].ToString());
                State.Direction = ParameterDirection.Input;
                State.SqlDbType = SqlDbType.NVarChar;
                State.Size = 50;
                objCommand.Parameters.Add(State);

                SqlParameter Zip = new SqlParameter("@Zip", cust[6].ToString());
                Zip.Direction = ParameterDirection.Input;
                Zip.SqlDbType = SqlDbType.NVarChar;
                Zip.Size = 50;
                objCommand.Parameters.Add(Zip);

                objDB.DoUpdateUsingCmdObj(objCommand);
            }
        }
        [WebMethod]
        public void addNewCard(object[] card)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "dbo.TP_addNewCard";

            SqlParameter inputCredNum = new SqlParameter("@cardNum", card[0].ToString());
            inputCredNum.Direction = ParameterDirection.Input;
            inputCredNum.SqlDbType = SqlDbType.NVarChar;
            inputCredNum.Size = 50;
            objCommand.Parameters.Add(inputCredNum);

            SqlParameter inputFName = new SqlParameter("@cardFName", card[1].ToString());
            inputFName.Direction = ParameterDirection.Input;
            inputFName.SqlDbType = SqlDbType.NVarChar;
            inputFName.Size = 50;
            objCommand.Parameters.Add(inputFName);

            SqlParameter inputLName = new SqlParameter("@cardLName", card[2].ToString());
            inputLName.Direction = ParameterDirection.Input;
            inputLName.SqlDbType = SqlDbType.NVarChar;
            inputLName.Size = 50;
            objCommand.Parameters.Add(inputLName);

            SqlParameter inpputExpiration = new SqlParameter("@cardExpiration", card[3].ToString());
            inpputExpiration.Direction = ParameterDirection.Input;
            inpputExpiration.SqlDbType = SqlDbType.NVarChar;
            inpputExpiration.Size = 50;
            objCommand.Parameters.Add(inpputExpiration);

            SqlParameter inputVerification = new SqlParameter("@cardVerification", card[4].ToString());
            inputVerification.Direction = ParameterDirection.Input;
            inputVerification.SqlDbType = SqlDbType.Int;
            inputVerification.Size = 4;
            objCommand.Parameters.Add(inputVerification);

            SqlParameter inputCardType = new SqlParameter("@cardType", card[5].ToString());
            inputCardType.Direction = ParameterDirection.Input;
            inputCardType.SqlDbType = SqlDbType.NVarChar;
            inputCardType.Size = 50;
            objCommand.Parameters.Add(inputCardType);

            SqlParameter inputLoginID = new SqlParameter("@loginID", card[6].ToString());
            inputLoginID.Direction = ParameterDirection.Input;
            inputLoginID.SqlDbType = SqlDbType.Int;
            inputLoginID.Size = 4;
            objCommand.Parameters.Add(inputLoginID);

            objDB.DoUpdateUsingCmdObj(objCommand);
        }
        [WebMethod]

        public void makeTransaction(object[] trans)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "dbo.makeTransaction";

            SqlParameter inputAmount = new SqlParameter("@transAmount", trans[0].ToString());
            inputAmount.Direction = ParameterDirection.Input;
            inputAmount.SqlDbType = SqlDbType.NVarChar;
            inputAmount.Size = 50;
            objCommand.Parameters.Add(inputAmount);

            SqlParameter inputDate = new SqlParameter("@transDate", trans[1].ToString());
            inputDate.Direction = ParameterDirection.Input;
            inputDate.SqlDbType = SqlDbType.NVarChar;
            inputDate.Size = 50;
            objCommand.Parameters.Add(inputDate);

            SqlParameter inputApproval = new SqlParameter("@approvedDenied", trans[2].ToString());
            inputApproval.Direction = ParameterDirection.Input;
            inputApproval.SqlDbType = SqlDbType.NVarChar;
            inputApproval.Size = 50;
            objCommand.Parameters.Add(inputApproval);

            objDB.DoUpdateUsingCmdObj(objCommand);
        }

        [WebMethod]
        public DataSet findCreditCard(long cardNum)
        {
            
            DataSet card = new DataSet();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "dbo.getCards";

            SqlParameter inputCardNum = new SqlParameter("@cardNum", cardNum);
            inputCardNum.Direction = ParameterDirection.Input;
            inputCardNum.SqlDbType = SqlDbType.NVarChar;
            inputCardNum.Size = 50;
            objCommand.Parameters.Add(inputCardNum);

            card = objDB.GetDataSetUsingCmdObj(objCommand);

            return card;
        }
        [WebMethod]
        public int test()
        {
            int test = 1;
            return test;
        }
        [WebMethod]
        public DataSet showCards(int loginID)
        {
            DataSet cards = new DataSet();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "dbo.TP_populateCards";

            SqlParameter inputLogin = new SqlParameter("@loginID", loginID);
            inputLogin.Direction = ParameterDirection.Input;
            inputLogin.SqlDbType = SqlDbType.Int;
            inputLogin.Size = 4;
            objCommand.Parameters.Add(inputLogin);

            cards = objDB.GetDataSetUsingCmdObj(objCommand);

            return cards;
        }
        [WebMethod]
        public void removeCard(long cardNum)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "dbo.TP_removeCard";

            SqlParameter inputCardID = new SqlParameter("@cardNum", cardNum);
            inputCardID.Direction = ParameterDirection.Input;
            inputCardID.SqlDbType = SqlDbType.NVarChar;
            inputCardID.Size = 50;
            objCommand.Parameters.Add(inputCardID);

            objDB.DoUpdateUsingCmdObj(objCommand);
        }
        [WebMethod]
        public DataSet cardExists(long cardNum)
        {
            DataSet foundCard = new DataSet();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "dbo.findCard";

            SqlParameter findMatch = new SqlParameter("@cardID", cardNum);
            findMatch.Direction = ParameterDirection.Input;
            findMatch.SqlDbType = SqlDbType.Int;
            findMatch.Size = 4;
            objCommand.Parameters.Add(findMatch);

            foundCard = objDB.GetDataSetUsingCmdObj(objCommand);
            return foundCard;
        }
        [WebMethod]
        public void updateCardInfo(object[] update)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "dbo.updateCard";

            SqlParameter inputID = new SqlParameter("@cID", update[0].ToString());
            inputID.Direction = ParameterDirection.Input;
            inputID.SqlDbType = SqlDbType.Int;
            inputID.Size = 4;
            objCommand.Parameters.Add(inputID);

            SqlParameter inputType = new SqlParameter("@type", update[1].ToString());
            inputType.Direction = ParameterDirection.Input;
            inputType.SqlDbType = SqlDbType.NVarChar;
            inputType.Size = 50;
            objCommand.Parameters.Add(inputType);

            SqlParameter inputNum = new SqlParameter("@cNum", update[2].ToString());
            inputNum.Direction = ParameterDirection.Input;
            inputNum.SqlDbType = SqlDbType.NVarChar;
            inputNum.Size = 50;
            objCommand.Parameters.Add(inputNum);

            SqlParameter inputExp = new SqlParameter("@exp", update[3].ToString());
            inputExp.Direction = ParameterDirection.Input;
            inputExp.SqlDbType = SqlDbType.NVarChar;
            inputExp.Size = 50;
            objCommand.Parameters.Add(inputExp);

            SqlParameter inputVerif = new SqlParameter("@verif", update[4].ToString());
            inputVerif.Direction = ParameterDirection.Input;
            inputVerif.SqlDbType = SqlDbType.NVarChar;
            inputVerif.Size = 50;
            objCommand.Parameters.Add(inputVerif);

            objDB.DoUpdateUsingCmdObj(objCommand);





        }
    }
}
