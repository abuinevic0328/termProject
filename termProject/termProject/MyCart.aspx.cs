using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using Utilities;
namespace termProject
{
    public partial class MyCart : System.Web.UI.Page
    {
        private int loginID;

        protected void Page_Load(object sender, EventArgs e)
        {
            
            DataSet dep = new DataSet();
            MerchantStore.MerchantStore pxy = new MerchantStore.MerchantStore();
            if (Session["loginId"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }
            else
            {
                loginID = (int)Session["loginID"];
                Response.Buffer = true;
                Response.ExpiresAbsolute = DateTime.Now.AddDays(-1d);
                Response.Expires = -1500;
                Response.CacheControl = "no-cache";

                dep = pxy.GetDepartments();
                ddlDepartments.DataSource = dep;

                ddlDepartments.DataTextField = "departmentName";
                ddlDepartments.DataValueField = "departmentName";
                ddlDepartments.DataBind();
                ddlDepartments.Items.Insert(0, "-----Choose-----");
            }
        }
    }
}