<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="storeHome.aspx.cs" Inherits="termProject.storeHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 1883px;
            height: 58px;
        }
        ul {
    list-style-type: none;
    margin: 0;
    padding: 0;
    overflow: hidden;
}

li {
    float: right;
            width: 329px;
        }

a {
    display: block;
    width: 299px;
    background-color: #FFD57B;
}
        .auto-style2 {
            font-size: x-large;
        }
        .auto-style3 {
            color: #666666;
        }
        .auto-style4 {
            font-size: x-large;
            color: #666666;
        }
        .navbar {
            text-align: center;
        }
        .auto-style5 {
            text-decoration: none;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <img alt="amazon" class="auto-style1" src="Images/amazon.png" /></div>
            <div class="navbar">
                <ul>
                    <asp:Label ID="lblDepartments" runat="server" Text="Departments       " style="font-size: x-large"></asp:Label>
                    <asp:DropDownList ID="ddlDepartments" runat="server" Height="40px" Width="206px" style="font-size: large" OnSelectedIndexChanged="ddlDepartments_SelectedIndexChanged" AutoPostBack="True" ></asp:DropDownList>
 
<li class="auto-style2"><a href="merchantRegistrationPage.aspx" class="auto-style5"><span class="auto-style3">Register as Merchant</span></a></li>
  <li class="auto-style2"><a href="cardManager.aspx" class="auto-style5"><span class="auto-style3">My Account</span></a></li>
  <li class="auto-style2"><a href="MyCart.aspx" class="auto-style5"><span class="auto-style3">Your Cart</span></a></li>
  <li class="auto-style2"><a href="storeHome.aspx" class="auto-style5"><span class="auto-style4">Home</span></a></li>
  </ul>
        </div>
        <div>
            
            <asp:GridView ID="gvProducts" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="description" HeaderText="Description" />
                    <asp:BoundField DataField="price" HeaderText="Price" />
                    <asp:TemplateField HeaderText="Order Quantity">
                        <ItemTemplate>
                            <asp:TextBox ID ="txtQuantity" runat="server" Width="50px"></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:ImageField DataImageUrlField="imageURL">
                    </asp:ImageField>
                    <asp:ButtonField ButtonType="Button" Text="Add to Cart" />
                </Columns>
            </asp:GridView>
            
        </div>
    </form>
</body>
</html>
