<%@ Page Title="" Language="C#" MasterPageFile="~/ClientInformation.Master" AutoEventWireup="true" CodeBehind="Clinet_CheckuoutPage.aspx.cs" Inherits="termProject.Clinet_CheckuoutPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div class="center">
      <asp:Label ID="lblOrderTotal" runat="server" Text="Your Order Total: " style="font-weight: 700"></asp:Label>
<p>
    <asp:Label ID="Label1" runat="server" Text="Select Credit Card: " style="font-weight: 700"></asp:Label>
    <asp:DropDownList ID="ddlCreditCardNums" runat="server">

    </asp:DropDownList> </p>
      <p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      </p>
      <p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnPlaceOrder" CssClass="yellowbutton" runat="server" Text="Place Order" />
      </p>

  </div>
</asp:Content>
