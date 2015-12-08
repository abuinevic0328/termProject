<%@ Page Title="" Language="C#" MasterPageFile="~/Merchant.Master" AutoEventWireup="true" CodeBehind="Merchant_ResetAccountInfo.aspx.cs" Inherits="termProject.Merchant_ResetAccountInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <div class="center">
    <h2> View Account Information</h2>
         <h3>To make changes to your account, please click the Edit button.</h3>
    
   
        <h4 >
            <asp:Label ID="lblMmbr" runat="server" Text="Member 1 Name:"></asp:Label>
        </h4>
        <p >
            <asp:Label ID="lblMember1" runat="server" Text="_name1_"></asp:Label>
        </p>
        <h4 class="auto-style4">Member 2 Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </h4>
 
            <asp:Label ID="lblMmb2" runat="server" Text="_name2_"></asp:Label>
            <br />
        
        <h4 class="auto-style4">
            <asp:Label ID="lblCVV" runat="server" Text="Phone Number:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </h4>
        <div class="auto-style4">
            <asp:Label ID="lblPhone" runat="server" Text="_phone_"></asp:Label>
            <br />
        </div>
        <h4 class="auto-style4">
            <asp:Label ID="lblExpDate" runat="server" Text="Site Description:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </h4>
        <div class="auto-style4">
            <asp:Label ID="lblDescription" runat="server" Text="_descp_"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblApikey1" runat="server" Text="ApiKey:" style="font-weight: 700"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblApiKey" runat="server" Text="_apiKey_"></asp:Label>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnEdit"  class="yellowbutton" runat="server" Text="Edit" OnClick="btnEdit_Click"></asp:Button>
            <br />
        </div>
    </div>
     
</asp:Content>
