<%@ Page Title="" Language="C#" MasterPageFile="~/Merchant.Master" AutoEventWireup="true" CodeBehind="Merchant_Home.aspx.cs" Inherits="termProject.Merchant_Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:GridView class="GVcenter" ID="gvTransaction" runat="server" OnSelectedIndexChanged="gvTransaction_SelectedIndexChanged"></asp:GridView>
    <asp:GridView class="GVcenter" ID="gvTransactionDetails" runat="server"></asp:GridView>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
   
</asp:Content>
