using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;



namespace termProjectLibrary
{

    public class customer
    {
        DBConnect connect = new DBConnect();

        SqlCommand objCommand = new SqlCommand();
        private int loginId;
        private string email;
        private string password;
        private string fName;
        private string lName;
        private string addressShipping;
        private string cityShipping;
        private string stateShipping;
        private int zipShipping;
        private string addressBilling;
        private string cityBilling;
        private string stateBilling;
        private int zipBilling;
        private string phoneNumber;
        private string passHash;
        private string generateCode;
        //DEFAULT CONSTRUCTOR
        public customer()
        {
            loginId = 0;
            email = "";
            password = "";
            fName = "";
            lName = "";
            addressShipping = "";
            cityShipping = "";
            stateShipping = "";
            addressBilling = "";
            cityBilling = "";
            stateBilling = "";
            phoneNumber = "";
            zipShipping = 0;
            zipBilling = 0;
            phoneNumber = "";
        }

        public customer(string email)
        {
            this.email = email;
            string query = " select loginId, firstName, lastName, PhoneNumber, email, password,passwordHash, generateCode from TP_Customer where email='" + this.email+"'";
            DataSet ds = connect.GetDataSet(query);
            DataTable CustomerDetailsData = ds.Tables[0];
            foreach (DataRow dr in CustomerDetailsData.Rows)
            {
                this.LoginId = Convert.ToInt32(dr["loginId"].ToString());
                this.FName = dr["firstName"].ToString();
                this.LName = dr["lastName"].ToString();
                this.PhoneNumber = dr["PhoneNumber"].ToString();
                this.Password = dr["Password"].ToString();
                this.PasswordHash = dr["PasswordHash"].ToString();
                this.GenerateCode = dr["generateCode"].ToString();

            }
        }
       
        public customer(int loginId, string email, string password, string fName, string lName,
            string addressShipping, string cityShipping, string stateShipping, string addressBilling, string cityBilling,
            string stateBilling, string phoneNumber, int zipShipping, int zipBilling)
        {
            this.loginId = loginId;
            this.email = email;
            this.password = password;
            this.fName = fName;
            this.lName = lName;
            this.addressShipping = addressShipping;
            this.cityShipping = cityShipping;
            this.stateShipping = stateShipping;
            this.addressBilling = addressBilling;
            this.cityBilling = cityBilling;
            this.stateBilling = stateBilling;
            this.zipBilling = zipBilling;
            this.zipShipping = zipShipping;
            this.phoneNumber = phoneNumber;
        }
        public int LoginId
        {
            get { return loginId; }
            set { loginId = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string GenerateCode
        {
            get { return generateCode; }
            set { generateCode = value; }
        }
        public string PasswordHash
        {
            set { this.passHash = value; }
            get { return this.passHash; }
        }
        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }
        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }
        public string AddressShipping
        {
            get { return addressShipping; }
            set { addressShipping = value; }
        }
        public string CityShipping
        {
            get { return cityShipping; }
            set { cityShipping = value; }
        }
        public string StateShipping
        {
            get { return stateShipping; }
            set { stateShipping = value; }
        }
        public string AddressBilling
        {
            get { return addressBilling; }
            set { addressBilling = value; }
        }
        public string CityBilling
        {
            get { return cityBilling; }
            set { cityBilling = value; }
        }
        public string StateBilling
        {
            get { return stateBilling; }
            set { stateBilling = value; }
        }
        public int ZipBilling
        {
            get { return zipBilling; }
            set { zipBilling = value; }
        }
        public int ZipShipping
        {
            get { return zipShipping; }
            set { zipShipping = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string getCardCreditNumber()
        {
            string cardNo = string.Empty;
            string queryCheckForCard = "select count(*) from tp_card where loginId=" + this.LoginId;
            SqlCommand cmdExist = new SqlCommand(queryCheckForCard, connect.GetConnection());
            int no =Convert.ToInt32(connect.ExecuteScalarFunction(cmdExist).ToString());
            if (no == 1)
            {
                string queryCardNo = "select top 1 cardNum from tp_card where loginId=" + this.LoginId;
                SqlCommand cardCmd = new SqlCommand(queryCardNo, connect.GetConnection());
                cardNo = connect.ExecuteScalarFunction(cardCmd).ToString();
            }
            else
                cardNo = "0";
            return cardNo;
        }

        //This method checks if the user exists in the db or not
        public int checkCustomer(string email, string password,string role)
        {
            int loginId;
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "[TP_AccountLogin]";
            objCommand.Parameters.Add("@email", SqlDbType.VarChar, 50);
            objCommand.Parameters["@email"].Value = email;

            objCommand.Parameters.Add("@password", SqlDbType.VarChar, 50);
            objCommand.Parameters["@password"].Value = password;

            objCommand.Parameters.Add("@role", SqlDbType.VarChar, 50);
            objCommand.Parameters["@role"].Value = role;

            objCommand.Parameters.Add("@loginId", SqlDbType.Int).Direction = ParameterDirection.Output;
            connect.GetDataSetUsingCmdObj(objCommand);

            loginId = Convert.ToInt32(objCommand.Parameters["@loginId"].Value);
            return loginId;

        }
        //This method gets the unique ID of the customer
        public int getID(string email, string password)
        {
            int customerID;
            string sql = "select LoginID from TP_Customer where email='" + email + "' and password ='" + password + "' ";
            SqlCommand cmd = new SqlCommand(sql, connect.GetConnection());
            customerID = Convert.ToInt32(connect.ExecuteScalarFunction(cmd));
            return customerID;
        }
        public void insertGeneratedCode(string code,string emailAddress )
        {
            string query = "update tp_customer set generatecode='" + code + "' where email='" + emailAddress + "'";
            connect.DoUpdate(query);
        }
        public bool existCustomerByEmail(string email)
        {
            //call tp_existEmail store procedure
         
            bool exist = false;

                SqlCommand cmdEmail = new SqlCommand();
                DBConnect objDB = new DBConnect();

                cmdEmail.CommandType = CommandType.StoredProcedure;
                cmdEmail.CommandText = "dbo.TP_ExistEmail";

                SqlParameter inputEmail = new SqlParameter("@email", email);

                inputEmail.Direction = ParameterDirection.Input;
                inputEmail.SqlDbType = SqlDbType.NVarChar;
                inputEmail.Size = 50;
                cmdEmail.Parameters.Add(inputEmail);

                cmdEmail.Parameters.Add("@result", SqlDbType.Int).Direction = ParameterDirection.Output;

                objDB.DoUpdateUsingCmdObj(cmdEmail);
                int result = Convert.ToInt32(cmdEmail.Parameters["@result"].Value);

                if (result == 1)
                    exist = true;

                else
                    exist = false;
                
                    return exist;

        }
        public DataSet customerTransaction(int loginId)
        {
            SqlCommand cmdTransaction = new SqlCommand();
            DBConnect objDB = new DBConnect();

            cmdTransaction.CommandType = CommandType.StoredProcedure;
            cmdTransaction.CommandText = "dbo.TP_CustomerTransactions";

            SqlParameter inputTransaction = new SqlParameter("@loginId", loginId);

            inputTransaction.Direction = ParameterDirection.Input;
            inputTransaction.SqlDbType = SqlDbType.NVarChar;
            inputTransaction.Size = 50;
            cmdTransaction.Parameters.Add(inputTransaction);

         DataSet customerTransctionDataSet= connect.GetDataSetUsingCmdObj(cmdTransaction);
         return customerTransctionDataSet;
        }

        public DataSet transactionHistory(int loginID, int transactionID)
        {
            SqlCommand cmdTransactionHistory = new SqlCommand();
            DBConnect objDB = new DBConnect();

            cmdTransactionHistory.CommandType = CommandType.StoredProcedure;
            cmdTransactionHistory.CommandText = "dbo.TP_TransactionDetails";

            SqlParameter inputTransaction = new SqlParameter("@loginId", loginID);

            inputTransaction.Direction = ParameterDirection.Input;
            inputTransaction.SqlDbType = SqlDbType.NVarChar;
            inputTransaction.Size = 50;
            cmdTransactionHistory.Parameters.Add(inputTransaction);

            SqlParameter inputTransactionHistory = new SqlParameter("@transactionId", loginID);

            inputTransactionHistory.Direction = ParameterDirection.Input;
            inputTransactionHistory.SqlDbType = SqlDbType.NVarChar;
            inputTransactionHistory.Size = 50;
            cmdTransactionHistory.Parameters.Add(inputTransactionHistory);

           DataSet transactionHistoryDataSet= connect.GetDataSetUsingCmdObj(cmdTransactionHistory);
           return transactionHistoryDataSet;
        }
        public int registerCustomer(string email, string password, string fName, string lName, string shipAddress, string billAddress,
                                    string phoneNo, string cityBilling, string cityShipping, string stateShipping,
                                    string stateBilling, string zipShipping, string zipBilling)
        {
            int insertedId;
            string salt = Salt.NewSalt();
           
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "[TP_InsertCustomer]";
            objCommand.Parameters.Add("@fname", SqlDbType.VarChar, 50);
            objCommand.Parameters["@fname"].Value = fName;

            objCommand.Parameters.Add("@lname", SqlDbType.VarChar, 50);
            objCommand.Parameters["@lname"].Value = lName;

            objCommand.Parameters.Add("@password", SqlDbType.VarChar, 50);
            objCommand.Parameters["@password"].Value = password;

            objCommand.Parameters.Add("@addressShipping", SqlDbType.VarChar, 50);
            objCommand.Parameters["@addressShipping"].Value = shipAddress;

            objCommand.Parameters.Add("@addressBilling", SqlDbType.VarChar, 50);
            objCommand.Parameters["@addressBilling"].Value = billAddress;

            objCommand.Parameters.Add("@email", SqlDbType.VarChar, 50);
            objCommand.Parameters["@email"].Value = email;

            objCommand.Parameters.Add("@cityBilling", SqlDbType.VarChar, 50);
            objCommand.Parameters["@cityBilling"].Value = cityBilling;

            objCommand.Parameters.Add("@cityShipping", SqlDbType.VarChar, 50);
            objCommand.Parameters["@cityShipping"].Value = cityShipping;

            objCommand.Parameters.Add("@stateShipping", SqlDbType.VarChar, 50);
            objCommand.Parameters["@stateShipping"].Value = stateShipping;

            objCommand.Parameters.Add("@stateBilling", SqlDbType.VarChar, 50);
            objCommand.Parameters["@stateBilling"].Value = stateBilling;

            objCommand.Parameters.Add("@zipShipping", SqlDbType.Int);
            objCommand.Parameters["@zipShipping"].Value = Convert.ToInt32(zipShipping);

            objCommand.Parameters.Add("@zipBilling", SqlDbType.Int);
            objCommand.Parameters["@zipBilling"].Value = Convert.ToInt32(zipBilling);

            objCommand.Parameters.Add("@phoneNumber", SqlDbType.VarChar, 50);
            objCommand.Parameters["@phoneNumber"].Value = phoneNo;

            objCommand.Parameters.Add("@salt", SqlDbType.VarChar, 50);
            objCommand.Parameters["@salt"].Value = salt;

            objCommand.Parameters.Add("@idInserted", SqlDbType.Int).Direction = ParameterDirection.Output;

            connect.GetDataSetUsingCmdObj(objCommand);

            insertedId = Convert.ToInt32(objCommand.Parameters["@idInserted"].Value);
            return insertedId;
        }


        public int ResetPassword(string currentEmail, string currentPassword, string newPassword1, string salt, string role)
        {

            SqlCommand pass = new SqlCommand();
            DBConnect objDB = new DBConnect();

            pass.CommandType = CommandType.StoredProcedure;
            pass.CommandText = "dbo.TP_ResetPassword";
            SqlParameter inputEmail = new SqlParameter("@email", currentEmail);

            inputEmail.Direction = ParameterDirection.Input;
            inputEmail.SqlDbType = SqlDbType.NVarChar;
            inputEmail.Size = 50;
            pass.Parameters.Add(inputEmail);
            SqlParameter inputRole = new SqlParameter("@role", role);

            inputRole.Direction = ParameterDirection.Input;
            inputRole.SqlDbType = SqlDbType.NVarChar;
            inputRole.Size = 50;
            pass.Parameters.Add(inputRole);

            SqlParameter inputPassword = new SqlParameter("@currentPass", currentPassword);

            inputPassword.Direction = ParameterDirection.Input;
            inputPassword.SqlDbType = SqlDbType.NVarChar;
            inputPassword.Size = 50;
            pass.Parameters.Add(inputPassword);

            SqlParameter inputPassword1 = new SqlParameter("@newPass", newPassword1);

            inputPassword1.Direction = ParameterDirection.Input;
            inputPassword1.SqlDbType = SqlDbType.NVarChar;
            inputPassword1.Size = 50;
            pass.Parameters.Add(inputPassword1);

            SqlParameter inputSalt = new SqlParameter("@newSalt", salt);

            inputSalt.Direction = ParameterDirection.Input;
            inputSalt.SqlDbType = SqlDbType.NVarChar;
            inputSalt.Size = 50;
            pass.Parameters.Add(inputSalt);


            pass.Parameters.Add("@returnId", SqlDbType.Int).Direction = ParameterDirection.Output;

            objDB.DoUpdateUsingCmdObj(pass);
            int result = Convert.ToInt32(pass.Parameters["@returnId"].Value);

            return result;
        }
        
        public int changeName(string newName, string email)
        {
            SqlCommand nameCmd = new SqlCommand();
            DBConnect objDB = new DBConnect();

            nameCmd.CommandType = CommandType.StoredProcedure;
            nameCmd.CommandText = "dbo.TP_ResetName";

            SqlParameter inputEmail = new SqlParameter("@email", email);
            inputEmail.Direction = ParameterDirection.Input;
            inputEmail.SqlDbType = SqlDbType.NVarChar;
            inputEmail.Size = 50;
            nameCmd.Parameters.Add(inputEmail);

            SqlParameter inputName = new SqlParameter("@newName", newName);
            inputName.Direction = ParameterDirection.Input;
            inputName.SqlDbType = SqlDbType.NVarChar;
            inputName.Size = 50;
            nameCmd.Parameters.Add(inputName);

            nameCmd.Parameters.Add("@result", SqlDbType.Int).Direction = ParameterDirection.Output;
            objDB.DoUpdateUsingCmdObj(nameCmd);
            int result = Convert.ToInt32(nameCmd.Parameters["@result"].Value);
            return result;


        }
    }}

