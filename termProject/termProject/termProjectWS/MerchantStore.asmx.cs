using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using System.Data;
using System.Data.SqlClient;

using Utilities;

namespace termProjectWS
{
    /// <summary>
    /// Summary description for MerchantStore
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MerchantStore : System.Web.Services.WebService
    {
        SqlCommand checkMerch = new SqlCommand();
        DBConnect objDB = new DBConnect();
        SqlCommand regMerch = new SqlCommand();
        DataSet count = new DataSet();
        SqlCommand cmdCheckCustomer = new SqlCommand();

        

        [WebMethod]
        public DataSet GetDepartments()
        {
            SqlCommand dep = new SqlCommand();
            DBConnect objDB = new DBConnect();
            DataSet department = new DataSet();
            
            dep.CommandType = CommandType.StoredProcedure;
            dep.CommandText = "dbo.TP_getDepartments";

            department = objDB.GetDataSetUsingCmdObj(dep);

            return department;
        }
        [WebMethod]
        public DataSet GetProductCatalog(string DepartmentNumber)
        {
            SqlCommand prod = new SqlCommand();
            DBConnect objDB = new DBConnect();
            DataSet product = new DataSet();

            prod.CommandType = CommandType.StoredProcedure;
            prod.CommandText = "dbo.TP_getProductCatalog";

            SqlParameter findProducts = new SqlParameter("@depNum", DepartmentNumber);
            findProducts.Direction = ParameterDirection.Input;
            findProducts.SqlDbType = SqlDbType.Int;
            findProducts.Size = 4;
            prod.Parameters.Add(findProducts);

            product = objDB.GetDataSetUsingCmdObj(prod);

            return product;
        }
        [WebMethod]
        public Boolean RegisterSite(String SiteID, String Description, String APIKey, String email, object[] contactInfo)
        {
            checkMerch.CommandType = CommandType.StoredProcedure;
            checkMerch.CommandText = "dbo.TP_checkMerchantExist";

            
            SqlParameter findSite = new SqlParameter("@siteID", SiteID);

            findSite.Direction = ParameterDirection.Input;
            findSite.SqlDbType = SqlDbType.NVarChar;
            findSite.Size = 50;
            checkMerch.Parameters.Add(findSite);

            count = objDB.GetDataSetUsingCmdObj(checkMerch);

            int size = Convert.ToInt32(count.Tables[0].Rows[0][0].ToString());
            if (size > 0)
            {
                return false;
            }
            else
            {
                regMerch.CommandType = CommandType.StoredProcedure;
                regMerch.CommandText = "dbo.TP_addMerchant";

                SqlParameter inputSiteID = new SqlParameter("@siteID", SiteID);

                inputSiteID.Direction = ParameterDirection.Input;
                inputSiteID.SqlDbType = SqlDbType.NVarChar;
                inputSiteID.Size = 50;
                regMerch.Parameters.Add(inputSiteID);

                SqlParameter inputDescription = new SqlParameter("@description", Description);

                inputDescription.Direction = ParameterDirection.Input;
                inputDescription.SqlDbType = SqlDbType.NVarChar;
                inputDescription.Size = 50;
                regMerch.Parameters.Add(inputDescription);

                SqlParameter inputAPI = new SqlParameter("@apiKey", APIKey);

                inputAPI.Direction = ParameterDirection.Input;
                inputAPI.SqlDbType = SqlDbType.NVarChar;
                inputAPI.Size = 50;
                regMerch.Parameters.Add(inputAPI);

                SqlParameter inputEmail = new SqlParameter("@email", email);

                inputEmail.Direction = ParameterDirection.Input;
                inputEmail.SqlDbType = SqlDbType.NVarChar;
                inputEmail.Size = 50;
                regMerch.Parameters.Add(inputEmail);

                SqlParameter inputName1 = new SqlParameter("@member1", contactInfo[0].ToString());

                inputName1.Direction = ParameterDirection.Input;
                inputName1.SqlDbType = SqlDbType.NVarChar;
                inputName1.Size = 50;
                regMerch.Parameters.Add(inputName1);

                SqlParameter inputName2 = new SqlParameter("@member2", contactInfo[1].ToString());

                inputName2.Direction = ParameterDirection.Input;
                inputName2.SqlDbType = SqlDbType.NVarChar;
                inputName2.Size = 50;
                regMerch.Parameters.Add(inputName2);

                SqlParameter inputPhoneNum = new SqlParameter("@phoneNum", contactInfo[2].ToString());

                inputPhoneNum.Direction = ParameterDirection.Input;
                inputPhoneNum.SqlDbType = SqlDbType.NVarChar;
                inputPhoneNum.Size = 50;
                regMerch.Parameters.Add(inputPhoneNum);

                objDB.DoUpdateUsingCmdObj(regMerch);

                return true;
            }
        }
        [WebMethod]
        public Boolean Purchase(String ProductID, int Quantity, String SiteID, String APIKey, String[] CustomerInfo)
        {
           
            string email = CustomerInfo[0].ToString();
            string name = CustomerInfo[1].ToString();
            string lastname = CustomerInfo[2].ToString();
            string cardNumber = CustomerInfo[3].ToString();

            cmdCheckCustomer.CommandType = CommandType.StoredProcedure;
            cmdCheckCustomer.CommandText = "dbo.tp_CheckCustomer";
            
            SqlParameter inputEmail = new SqlParameter("@email", email);

            inputEmail.Direction = ParameterDirection.Input;
            inputEmail.SqlDbType = SqlDbType.NVarChar;
            inputEmail.Size = 50;
            cmdCheckCustomer.Parameters.Add(inputEmail);

            SqlParameter inputName = new SqlParameter("@name", name);

            inputName.Direction = ParameterDirection.Input;
            inputName.SqlDbType = SqlDbType.NVarChar;
            inputName.Size = 50;
            cmdCheckCustomer.Parameters.Add(inputName);

            SqlParameter inputLastName = new SqlParameter("@lastname", lastname);

            inputLastName.Direction = ParameterDirection.Input;
            inputLastName.SqlDbType = SqlDbType.NVarChar;
            inputLastName.Size = 50;
            cmdCheckCustomer.Parameters.Add(inputLastName);
            
            SqlParameter inputCreditCard = new SqlParameter("@cardNumber", cardNumber);

            inputCreditCard.Direction = ParameterDirection.Input;
            inputCreditCard.SqlDbType = SqlDbType.NVarChar;
            inputCreditCard.Size = 50;
            cmdCheckCustomer.Parameters.Add(inputCreditCard);
            cmdCheckCustomer.Parameters.Add("@loginIdValue", SqlDbType.Int).Direction = ParameterDirection.Output;

            objDB.DoUpdateUsingCmdObj(cmdCheckCustomer);
            int loginId = Convert.ToInt32(cmdCheckCustomer.Parameters["@loginIdValue"].Value);

            SqlCommand cmd = new SqlCommand();


           

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "dbo.tp_InsertPurchase";

            SqlParameter inputProductId = new SqlParameter("@productId", ProductID);

            inputProductId.Direction = ParameterDirection.Input;
            inputProductId.SqlDbType = SqlDbType.Int;
            inputProductId.Size = 50;
            cmd.Parameters.Add(inputProductId);

            SqlParameter inputQuantity = new SqlParameter("@quantity", Quantity);

            inputQuantity.Direction = ParameterDirection.Input;
            inputQuantity.SqlDbType = SqlDbType.NVarChar;
            inputQuantity.Size = 50;
            cmd.Parameters.Add(inputQuantity);

            SqlParameter inputSiteId = new SqlParameter("@siteId", SiteID);

            inputSiteId.Direction = ParameterDirection.Input;
            inputSiteId.SqlDbType = SqlDbType.NVarChar;
            inputSiteId.Size = 50;
            cmd.Parameters.Add(inputSiteId);

            SqlParameter inputApiKey = new SqlParameter("@apiKey", APIKey);

            inputApiKey.Direction = ParameterDirection.Input;
            inputApiKey.SqlDbType = SqlDbType.NVarChar;
            inputApiKey.Size = 50;
            cmd.Parameters.Add(inputApiKey);

            SqlParameter inputLoginId = new SqlParameter("@loginId", loginId);

            inputLoginId.Direction = ParameterDirection.Input;
            inputLoginId.SqlDbType = SqlDbType.Int;
            inputLoginId.Size = 50;
            cmd.Parameters.Add(inputLoginId);


            int nr = objDB.DoUpdateUsingCmdObj(cmd);
            
            if (nr == -1)
                return false;
            else
                return true;



        }
        
        
    }
}
