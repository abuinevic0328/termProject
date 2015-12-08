using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using termProjectLibrary;

namespace termProject
{
    public partial class Client_CardManager : System.Web.UI.Page
    {
        private long cardNum;
        private string firstName;
        private string lastName;
        private int verif;
        private string expDate;
        private int loginID;
        private string type;

        cardProcessing.verifyCard pxy = new cardProcessing.verifyCard();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["loginId"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }
            else
            {
                loginID = Convert.ToInt32(Session["loginId"]);
                gvShowCards.DataSource = pxy.showCards(loginID);
                gvShowCards.DataBind();

            }
        }

        protected void btnAddCard_Click(object sender, EventArgs e)
        {
            double numbers;
            long value1;
            string value2;
            string value3;
            int value4;

            if (double.TryParse(txtCardNum.Text, out numbers))
            {
                value1 = long.Parse(txtCardNum.Text);
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Script", "<script> alert('Please enter a valid credit card number. No letters are allowed!'); </script>");
                return;
            }

            if (Regex.IsMatch(txtFirstName.Text, @"^[\p{L}]+$"))
            { value2 = Convert.ToString(txtFirstName.Text); }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Script", "<script> alert('Please enter your firstname correctly! This is a letter field only'); </script>");
                return;

            }
            if (Regex.IsMatch(txtLastName.Text, @"^[\p{L}]+$"))
            { value3 = Convert.ToString(txtLastName.Text); }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Script", "<script> alert('Please enter your lastname correctly! This is a letter field only'); </script>");
                return;

            }

            if (double.TryParse(txtCVV.Text, out numbers))
            {
                value4 = int.Parse(txtCVV.Text);
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Script", "<script> alert('Please enter a valid verification number. No letters are allowed!'); </script>");
                return;
            }


            loginID = Convert.ToInt32(Session["loginId"]);
            cardNum = long.Parse(txtCardNum.Text);
            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            expDate = ddlMonth.SelectedValue.ToString() + "/" + DropDownList1.SelectedValue.ToString();
            verif = Convert.ToInt32(txtCVV.Text);
            type = ddlCardType.SelectedValue.ToString();

            card add = new card(loginID, cardNum, firstName, lastName, expDate, verif, type);

            pxy.addNewCard(add.addCard(add));
            gvShowCards.DataSource = refreshCardTable(loginID);
            gvShowCards.DataBind();

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Client_AmazonCard.aspx");
        }
        protected void gvShowCards_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int row = Convert.ToInt32(e.CommandArgument.ToString());

            if (e.CommandName == "btnRemove")
            {
                long cardNum = long.Parse(gvShowCards.Rows[row].Cells[0].Text);

                pxy.removeCard(cardNum);
                gvShowCards.DataSource = refreshCardTable(loginID);
                gvShowCards.DataBind();
            }
        }
        public DataSet refreshCardTable(int loginID)
        {
            DataSet theCards = new DataSet();
            theCards = pxy.showCards(loginID);

            return theCards;
        }
    }
}