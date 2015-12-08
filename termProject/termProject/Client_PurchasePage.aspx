<%@ Page Title="" Language="C#" MasterPageFile="~/ClientInformation.Master" AutoEventWireup="true" CodeBehind="Client_PurchasePage.aspx.cs" Inherits="termProject.Client_PurchasePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <div class="GVcenter">
            <asp:Label ID="lblPurchase" runat="server" Text="My purchase list:"></asp:Label>
            <asp:GridView ID="gvPurchases" runat="server"   BorderColor="#FFD57B" Width="441px" DataKeyNames="transactionId" OnSelectedIndexChanged="gvPurchases_SelectedIndexChanged">
                <Columns>
                    <asp:ButtonField CommandName="Select" HeaderText="Select" ShowHeader="True" Text="Select" />
                </Columns>
              
            </asp:GridView>
          <asp:GridView ID="yourCurrentCart" runat="server" AutoGenerateColumns="false" Visible="false" EmptyDataText="There are no data!">
              <%-- <Columns>
                    <asp:BoundField DataField="purchaseId" HeaderText="Purchase" />
                    <asp:BoundField DataField="productNum" HeaderText="Product id" />
                    <asp:BoundField DataField="description " HeaderText="description" /> 
                     <asp:BoundField DataField="price " HeaderText="Price" /> 
                 <asp:BoundField DataField="quantity " HeaderText="quantity"> 

                        </asp:BoundField>
              </Columns>--%>
          </asp:GridView>
        </div>
</asp:Content>
