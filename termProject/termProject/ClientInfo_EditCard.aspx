<%@ Page Title="" Language="C#" MasterPageFile="~/ClientInformation.Master" AutoEventWireup="true" CodeBehind="ClientInfo_EditCard.aspx.cs" Inherits="termProject.ClientInfo_EditCard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <p>&nbsp</p>
    <div class="center">

    <asp:Label ID="lblCardNumber" runat="server" Text="Card Number:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtCardNumber" class="txt" runat="server" Height="36px" Width="260px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblFirstN" runat="server" Text="First Name:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtFirstname" class="txt" runat="server" Height="33px" Width="256px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblLastN" runat="server" Text="Last Name:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtLname" class="txt"  runat="server" Height="34px" Width="256px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="expDate" runat="server" Text="Expiration Date:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtExpDate" class="txt"  runat="server" Height="35px" Width="253px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblCVV" runat="server" Text="CVV:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtCvv" class="txt" runat="server" Height="32px" Width="250px"></asp:TextBox>
    <br />
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnSave" CssClass="yellowbutton" runat="server" Text="Save" Width="98px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnCancel" class="greyButton" runat="server" Text="Cancel" Width="110px" OnClick="btnCancel_Click" />
        </div>
</asp:Content>
