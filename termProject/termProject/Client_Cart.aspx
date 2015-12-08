<%@ Page Title="" Language="C#" MasterPageFile="~/Client.Master" AutoEventWireup="true" CodeBehind="Client_Cart.aspx.cs" Inherits="termProject.Client_Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%--<div class="center">
    <asp:Label ID="Label1" runat="server" Text="Your shopping cart is empty!"></asp:Label>
    </div>--%>
    <div class="GVcenter">

        <asp:GridView ID="gvCart" runat="server" AutoGenerateColumns="False" ShowFooter="true" OnRowCommand="gvCart_RowCommand">
            <Columns>
                <asp:BoundField DataField="prodNum" HeaderText="Product Number" />
                <asp:BoundField DataField="ProdDesc" HeaderText="Description" />
                <asp:BoundField DataField="ProdPrice" HeaderText="Price" DataFormatString="{0:c}"/>
                <asp:BoundField DataField="ProdQuantity" HeaderText="Quantity Ordered" />
                <asp:BoundField DataField="subTotal" HeaderText="Sub Total" DataFormatString="{0:c}"/>
                <asp:ImageField DataImageUrlField="ImgUrl">
                </asp:ImageField>
                <asp:BoundField HeaderText="Merchant Selling" />
                <asp:TemplateField HeaderText="Update Quantity">
                    <ItemTemplate>
                        <asp:TextBox runat="server" ID ="txtQuantity"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:ButtonField ButtonType="Button" CommandName="btnUpdate" Text="Update" />
                <asp:ButtonField ButtonType="Button" CommandName="btnDelete" Text="Delete" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnCheckout"  class="yellowbutton" runat="server" Text="Procced to Checkout" OnClick="btnCheckout_Click"></asp:Button>
    </div>
</asp:Content>
