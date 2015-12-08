using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using termProjectLibrary;

namespace termProject
{
    public partial class Client : System.Web.UI.MasterPage
    {
        MerchantStore.MerchantStore pxy = new MerchantStore.MerchantStore();
        ErikaGin.MerchantStore EGpxy = new ErikaGin.MerchantStore();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataSet dep = new DataSet();
                dep = pxy.GetDepartments();
                DataSet dep2 = new DataSet();
                dep2 = EGpxy.GetDepartments();
                dep.Merge(dep2);
                ddlDepartments.DataSource = dep;
                ddlDepartments.DataTextField = "departmentName";
                ddlDepartments.DataValueField = "departmentNumber";
                ddlDepartments.DataBind();
                ddlDepartments.Items.Insert(0, "-------Choose-------");
            }
        }

        protected void ddlDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            string depSelected = ddlDepartments.SelectedValue;
            string depName = ddlDepartments.SelectedItem.Text;
            Session["depName"] = depName;
            Session["depSelected"] = depSelected;
            Response.Redirect("Client_StoreHome.aspx");
        }

      
    }
}