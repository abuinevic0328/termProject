using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Utilities;
namespace termProject
{
    public partial class storeHome : System.Web.UI.Page
    {
        MerchantStore.MerchantStore pxy = new MerchantStore.MerchantStore();
        private int depNum;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            DBConnect objDB = new DBConnect();
            if (Session["loginId"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }

            if (!IsPostBack)
            {
                Response.Buffer = true;
                Response.ExpiresAbsolute = DateTime.Now.AddDays(-1d);
                Response.Expires = -1500;
                Response.CacheControl = "no-cache";

                DataSet dep = new DataSet();
                dep = pxy.GetDepartments();
                ddlDepartments.DataSource = dep;
                ddlDepartments.DataTextField = "departmentName";
                ddlDepartments.DataValueField = "departmentNumber";
                ddlDepartments.DataBind();
                ddlDepartments.Items.Insert(0, "-------Choose-------");
            }
            

            
        }

        protected void ddlDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet products = new DataSet();
            DBConnect objDB = new DBConnect();
            string depNum = ddlDepartments.SelectedValue;
            //string depNum = "SELECT departmentNum FROM TP_DEPARTMENT WHERE departmentName = "+depName+"";

            products = pxy.GetProductCatalog(depNum);
            gvProducts.DataSource = products;
            gvProducts.DataBind();
        }

       
    }
}