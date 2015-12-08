using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using termProjectLibrary;

using Utilities;

namespace termProject
{
    public partial class merchantRegistrationPage : System.Web.UI.Page
    {
        DBConnect objDB = new DBConnect();
        SqlCommand command = new SqlCommand();
        DataSet count = new DataSet();

        private int rowCount;
        private string url;
        private string sID;
        private string member1;
        private string APIkey;
        private string email;
        private string siteID;
        private string description;
        private string phoneNum;

        MerchantStore.MerchantStore pxy = new MerchantStore.MerchantStore();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["loginId"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }

            Response.Buffer = true;
            Response.ExpiresAbsolute = DateTime.Now.AddDays(-1d);
            Response.Expires = -1500;
            Response.CacheControl = "no-cache";

            if (!IsPostBack)
            {
                txtDescription.Text = "";
                txtEmail.Text = "";
                txtGroupMember1.Text = "";
                txtGroupMember2.Text = "";
                txtPhoneNum.Text = "";
                txtSiteID.Text = "";
                txtURL.Text = "";
            }

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            phoneNum = txtPhoneNum.Text;
            email = txtEmail.Text;
            description = txtDescription.Text;
            url = txtURL.Text;
            email = txtEmail.Text;
            sID = txtSiteID.Text;
            lblAPI.Text = "";
            merchant m = new merchant();
            APIkey = m.apiGenerator().ToString();
            Boolean keyFound = m.checkAPIExist(APIkey);
            while (keyFound == true)
            {
                APIkey = m.apiGenerator().ToString();
                keyFound = m.checkAPIExist(APIkey);
            }
            lblAPI.Text = APIkey;
           
            //construct customerInfo object to pass into webservice webmthod (registerSite)
                merchant newMerch = new merchant(txtGroupMember1.Text, txtGroupMember2.Text, phoneNum);
            

            //check if merchant exists by siteID and return either true or false depending on if
            //it has been added
                if (pxy.RegisterSite(sID, description, APIkey, email, m.contactInfo(newMerch)) == false)
                {
                    lblMerchantAdded.Text = "Merchant seems to already exist. Try again!";
                }
                else
                    lblMerchantAdded.Text = "Merchant Added Successfully. Please take note of your API Key!";
        }

        protected void ddlDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}