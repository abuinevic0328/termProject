using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Utilities;

using termProjectLibrary;

namespace termProjectLibrary
{
    public class merchant
    {
        private int merchantId;
        private string merchantURL;
        private string APIKey;
        private string description;
        private string email;
        private string groupMemberName1;
        private string groupMemberName2;
        private string phoneNumber;

        public int MerchantId
        {
            get { return merchantId; }
            set { merchantId = value; }
        }

        public string merchURL
        {
            get { return merchantURL; }
            set { merchantURL = value; }
        }
        public string key
        {
            get { return APIKey; }
            set { APIKey = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string EMail
        {
            get { return email; }
            set { email = value; }
        }
        public string Member1
        {
            get { return groupMemberName1; }
            set { groupMemberName1 = value; }
        }
        public string Member2
        {
            get { return groupMemberName2; }
            set { groupMemberName2 = value; }
        }
        public string PhoneNum
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public merchant()
        {
            merchantURL = "";
            APIKey = "";
            email = "";
            groupMemberName1 = "";
            groupMemberName2 = "";
        }
        public merchant(int merchantId)
        {
            DBConnect objDB = new DBConnect();
            this.merchantId = merchantId;
            string query = " select siteID, description, apiKey, email, member1, member2, phoneNum from TP_MERCHANT where merchantID=" + this.merchantId + "";
            DataSet ds = objDB.GetDataSet(query);
            DataTable MerchantDetailsData = ds.Tables[0];
            foreach (DataRow dr in MerchantDetailsData.Rows)
            {

                this.merchantURL = dr["siteID"].ToString();
                this.APIKey = dr["apiKey"].ToString();
                this.description = dr["description"].ToString();
                this.email = dr["email"].ToString();
                this.groupMemberName1 = dr["member1"].ToString();
                this.groupMemberName2 = dr["member2"].ToString();
               this.phoneNumber = dr["phoneNum"].ToString();
            }
        
        }
        public merchant(string url, string api, string emailAddress, string memberName1, string memberName2)
        {
            this.merchantURL = url;
            this.key = api;
            this.EMail = emailAddress;
            this.groupMemberName1 = memberName1;
            this.groupMemberName2 = memberName2;
        }
        public merchant(string memberName1, string memberName2, string phoneNum)
        {
            this.groupMemberName1 = memberName1;
            this.groupMemberName2 = memberName2;
            this.phoneNumber = phoneNum;
        }

        public string apiGenerator()
        {
            string APIKey = "";
            char[] key = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890".ToCharArray();
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                APIKey += key[r.Next(0,59)].ToString();
            }
            return APIKey;
        }
        public object[] contactInfo(merchant m)
        {
            object[] contactInfo = new object[3];
            contactInfo[0] = m.groupMemberName1;
            contactInfo[1] = m.groupMemberName2;
            contactInfo[2] = m.phoneNumber;

            return contactInfo;

        }
        public Boolean checkAPIExist(string key)
        {
            DBConnect objDB = new DBConnect();

            DataSet foundKey = new DataSet();
            SqlCommand findKeys = new SqlCommand();
            findKeys.CommandType = CommandType.StoredProcedure;
            findKeys.CommandText = "dbo.TP_CheckAPIExist";

            SqlParameter theKey = new SqlParameter("@APIKey", key);

            theKey.Direction = ParameterDirection.Input;
            theKey.SqlDbType = SqlDbType.NVarChar;
            theKey.Size = 50;
            findKeys.Parameters.Add(theKey);

            foundKey = objDB.GetDataSetUsingCmdObj(findKeys);
            int found = Convert.ToInt32(foundKey.Tables[0].Rows[0]["foundKeys"].ToString());
            if (found == 0)
            {
                return false;
            }
            else
            {
                
                return true;
            }
        }

        public DataSet MerchantTransaction(string siteId, string apiKey )
        {
            SqlCommand cmdTransaction = new SqlCommand();
            DBConnect objDB = new DBConnect();

            cmdTransaction.CommandType = CommandType.StoredProcedure;
            cmdTransaction.CommandText = "dbo.tp_MerchantTransaction";

            SqlParameter inputSite = new SqlParameter("@siteId", siteId.ToString());

            inputSite.Direction = ParameterDirection.Input;
            inputSite.SqlDbType = SqlDbType.NVarChar;
            inputSite.Size = 50;
            cmdTransaction.Parameters.Add(inputSite);

            SqlParameter inputApiKey = new SqlParameter("@apiKey", apiKey.ToString());

            inputApiKey.Direction = ParameterDirection.Input;
            inputApiKey.SqlDbType = SqlDbType.NVarChar;
            inputApiKey.Size = 50;
            cmdTransaction.Parameters.Add(inputApiKey);

            DataSet transactionMerchantDataSet = objDB.GetDataSetUsingCmdObj(cmdTransaction);
            return transactionMerchantDataSet;
        }

        public DataSet MerchantTransactionDetails(int transactionId)
        {
            SqlCommand cmdTransactionDetail = new SqlCommand();
            DBConnect objDB = new DBConnect();

            cmdTransactionDetail.CommandType = CommandType.StoredProcedure;
            cmdTransactionDetail.CommandText = "dbo.tp_MerchantTransactionDetails";

            SqlParameter inputSite = new SqlParameter("@transactionId", transactionId);

            inputSite.Direction = ParameterDirection.Input;
            inputSite.SqlDbType = SqlDbType.NVarChar;
            inputSite.Size = 50;
            cmdTransactionDetail.Parameters.Add(inputSite);

            
            DataSet transactionDetailDataSet = objDB.GetDataSetUsingCmdObj(cmdTransactionDetail);
            return transactionDetailDataSet;
        }
        //public Boolean merchantCreated(string siteID)
        //{
        //
           
        //        //create proxy for adding merchant
        //        return true;
        //    }
            
        //}
    }
}
