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

        //This method checks if the user exists in the db or not
        public int checkCustomer(string email, string password)
        {
            int loginId;
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "[TP_AccountLogin]";
            objCommand.Parameters.Add("@email", SqlDbType.VarChar, 50);
            objCommand.Parameters["@email"].Value = email;

            objCommand.Parameters.Add("@password", SqlDbType.VarChar, 50);
            objCommand.Parameters["@password"].Value = password;

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

    }
}

