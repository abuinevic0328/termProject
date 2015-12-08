using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using termProjectLibrary;
using System.Data.SqlClient;
using System.Data;
using Utilities;
using termProjectWS;
namespace termProject
{

    public partial class amazonCard : System.Web.UI.Page
    {
        private long cardNum;
        private string firstName;
        private string lastName;
        private int verif;
        private string exp;
        private int loginID;
        private string type;
        card c = new card();
        DBConnect objdb = new DBConnect();
        SqlCommand findCust = new SqlCommand();
        DataSet cust = new DataSet();
        cardProcessing.verifyCard pxy = new cardProcessing.verifyCard();
        MerchantStore.MerchantStore Mpxy = new MerchantStore.MerchantStore();
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

            if (IsPostBack)
            {
                lblYouHaveCard.Text = "";
            }

            DataSet dep = new DataSet();
            dep = Mpxy.GetDepartments();
            ddlDepartments.DataSource = dep;
            ddlDepartments.DataTextField = "departmentName";
            ddlDepartments.DataValueField = "departmentName";
            ddlDepartments.DataBind();
            ddlDepartments.Items.Insert(0, "-----Choose-----");
        }

        protected void btnApply_Click(object sender, EventArgs e)
        {
            loginID = Convert.ToInt32(Session["loginId"]);
            //loginID = 2;
            cardNum = long.Parse(c.generateCardNum());
            Boolean cardFound;
            cardFound = c.cardExists(cardNum);
            while (cardFound == true)
            {
                cardNum = long.Parse(c.generateCardNum().ToString());
                cardFound = c.cardExists(cardNum);
            }

            Boolean hasCard;
            hasCard = c.cardExists(loginID);
            if (hasCard == false)
            {
                lblYouHaveCard.Text = "Sorry, it looks like you already have an Amazon Card!";
            }
            else
            {
                lblConfirmCard.Text = "Thank you for applying. Your new card will arrive soon! But you can use it in the meantime. "+
                "Go to your account to view your Amazon Card details";
                lblCardNum.Text = cardNum.ToString();
                exp = c.cardExpiration();
                lblExpiration.Text = exp;
                verif = Convert.ToInt32(c.generateCVV());

                findCust.CommandType = CommandType.StoredProcedure;
                findCust.CommandText = "dbo.TP_findCustomerByID";

                SqlParameter inputLoginID = new SqlParameter("@loginID", loginID);
                inputLoginID.Direction = ParameterDirection.Input;
                inputLoginID.SqlDbType = SqlDbType.NVarChar;
                inputLoginID.Size = 50;
                findCust.Parameters.Add(inputLoginID);

                cust = objdb.GetDataSetUsingCmdObj(findCust);
                firstName = cust.Tables[0].Rows[0][0].ToString();
                lastName = cust.Tables[0].Rows[0][1].ToString();
                type = "Amazon Card";
                card addAmazon = new card(loginID, cardNum, firstName, lastName, exp, verif, type);
                pxy.addNewCard(addAmazon.addCard(addAmazon));
            }
        }
    }
}