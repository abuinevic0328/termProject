<%@ Page Title="" Language="C#" MasterPageFile="~/Client.Master" AutoEventWireup="true" CodeBehind="Client_StoreHome.aspx.cs" Inherits="termProject.Client_StoreHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        function loadDoc() {
            var xhttp = new XMLHttpRequest();
            xhttp.onreadystatechange = function () {
                if (xhttp.readyState == 4 && xhttp.status == 200) {
                    document.getElementById("text_expr").innerHTML = xhttp.responseText;
                }
            }; 
            xhttp.open("GET", "expression.txt", true);
            xhttp.send();
        } 
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
 <h2>Want to save more next time you shop with us?</h2>

    <div class="GVcenter" >
         <div id="text_expr"> </div>
         <button type="button" class="yellowbutton" onclick="loadDoc()" >Learn More</button>
           <h2> <asp:Label ID="lblDepName" runat="server" Text=""></asp:Label> </h2>
         <h2><asp:Label ID="lblAddQuantity" runat="server" Text="" style="color:red"></asp:Label></h2>
            <asp:GridView ID="gvProducts" runat="server" AutoGenerateColumns="False" OnRowCommand="gvProducts_RowCommand" BorderColor="#FFD57B">
                <Columns>
                    <asp:BoundField DataField="productNum" HeaderText="Product Number" />
                    <asp:BoundField DataField="description" HeaderText="Description" />
                    <asp:BoundField DataField="price" HeaderText="Price" DataFormatString="{0:c}" >
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField HeaderText="Availability">
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:TemplateField HeaderText="Order Quantity">
                        <ItemTemplate>
                            <asp:TextBox ID ="txtQuantity" runat="server" Width="50px"></asp:TextBox>
                        </ItemTemplate>
                        <ItemStyle HorizontalAlign="Center" />
                    </asp:TemplateField>
                    <asp:ImageField DataImageUrlField="imageURL">
                    </asp:ImageField>
                    <asp:TemplateField HeaderText="Add">
                        <ItemTemplate>
                            <asp:Button ID="btnAdd" runat="server" CausesValidation="false" CommandName="btnAdd" Text="Add to Cart" CommandArgument="<%# Container.DataItemIndex %>" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <p>&nbsp;</p>
        </div>
</asp:Content>
