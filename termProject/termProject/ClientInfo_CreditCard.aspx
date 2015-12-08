<%@ Page Title="" Language="C#" MasterPageFile="~/ClientInformation.Master" AutoEventWireup="true" CodeBehind="ClientInfo_CreditCard.aspx.cs" Inherits="termProject.ClientInfo_CreditCard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    #Card_div {
        margin-left: 40px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="center" >
        <h2 class="auto-style4">
            <asp:Label ID="lbl1" runat="server" Text="Change Credit Card Information"></asp:Label>
        </h2>
        <div class="auto-style4">
        <br />
      
        </div>
      <div runat="server" id="noCard_div"> <h4 class="auto-style4">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </h4>
          
      <div runat="server" id="Card_div">
        <h4 class="auto-style4">
            <asp:Label ID="lblCardNumber" runat="server" Text="Card Number:"></asp:Label>
        </h4>
        <p class="auto-style4">
        <asp:Label ID="lblCard" runat="server" Text="_card_"></asp:Label>
        </p>
        <h4 class="auto-style4">
            <asp:Label ID="lblNameChange" runat="server" style="font-size: medium" Text="Full Name:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </h4>
        <div class="auto-style4">
        <asp:Label ID="lblName" runat="server" Text="_name_"></asp:Label>
        <br />
        </div>
        <h4 class="auto-style4">
            <asp:Label ID="lblCVV" runat="server" Text="CVV"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </h4>
        <div class="auto-style4">
        <asp:Label ID="lblCvv2" runat="server" Text="_CVV_"></asp:Label>
        <br />
        </div>
        <h4 class="auto-style4">
            <asp:Label ID="lblExpDate" runat="server" Text="Experation Date:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </h4>
        <div class="auto-style4">
        <asp:Label ID="lblExp" runat="server" Text="_exp_"></asp:Label>
        <br />
        </div>
        <h4 class="auto-style4">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </h4>
       
        <asp:Button ID="btnEdit" class="yellowbutton" runat="server" Text="Edit" OnClick="btnEdit_Click" Width="72px" />
          <br />
          <br />
    <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
    </div>
          </div>
</asp:Content>
