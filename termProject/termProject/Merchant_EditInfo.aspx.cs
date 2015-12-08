using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using termProjectLibrary;
using Utilities;

namespace termProject
{
    public partial class Merchant_EditInfo : System.Web.UI.Page
    {
        string email = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {

            string email = "laura@gmail.com";

            if (Session["email"] != null)
            {
                email = Session["email"].ToString();
                int merchantId = 1;

                merchant merchantObj = new merchant(merchantId);


                txtMember1Name.Text = merchantObj.Member1;
                txtMember1Name.Enabled = false;

                txtMember2Name.Text = merchantObj.Member2;
                txtMember2Name.Enabled = true;

                txtPhone.Text = merchantObj.PhoneNum;
                txtPhone.Enabled = true;

                txtDescription.Text = merchantObj.Description;
                txtDescription.Enabled = true;

            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMember1Name.Text) || String.IsNullOrEmpty(txtMember2Name.Text) || String.IsNullOrEmpty(txtPhone.Text))
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Script", "<script> alert('All fields are required.Thank you!'); </script>");
           int merchantId=Convert.ToInt32(Session["loginId"].ToString());
             
	
            
                string description = txtDescription.Text;
                string phoneNumber = txtPhone.Text;
                string member1 = txtMember1Name.Text;
               string member2 = txtMember2Name.Text;


                SqlCommand merchantCmd = new SqlCommand();
                DBConnect objDB = new DBConnect();

                merchantCmd.CommandType = CommandType.StoredProcedure;
                merchantCmd.CommandText = "dbo.TP_UpdateMerchantData";

                SqlParameter inputMerchId = new SqlParameter("@merchantId", merchantId);

                inputMerchId.Direction = ParameterDirection.Input;
                inputMerchId.SqlDbType = SqlDbType.NVarChar;
                inputMerchId.Size = 50;
                merchantCmd.Parameters.Add(inputMerchId);

                SqlParameter inputDescription = new SqlParameter("@description", description);

                inputDescription.Direction = ParameterDirection.Input;
                inputDescription.SqlDbType = SqlDbType.NVarChar;
                inputDescription.Size = 50;
                merchantCmd.Parameters.Add(inputDescription);

                SqlParameter inputPhone = new SqlParameter("@phonenumber", phoneNumber);

                inputPhone.Direction = ParameterDirection.Input;
                inputPhone.SqlDbType = SqlDbType.NVarChar;
                inputPhone.Size = 50;
                merchantCmd.Parameters.Add(inputPhone);

             SqlParameter inputMember1 = new SqlParameter("@member1", member1);

                inputMember1.Direction = ParameterDirection.Input;
                inputMember1.SqlDbType = SqlDbType.NVarChar;
                inputMember1.Size = 50;
                merchantCmd.Parameters.Add(inputMember1);

             SqlParameter inputMember2 = new SqlParameter("@member2", member2);

                inputMember2.Direction = ParameterDirection.Input;
                inputMember2.SqlDbType = SqlDbType.NVarChar;
                inputMember2.Size = 50;
                merchantCmd.Parameters.Add(inputMember2);

            objDB.DoUpdateUsingCmdObj(merchantCmd); 
                
            }
        }
    }


