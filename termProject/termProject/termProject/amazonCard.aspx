<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="amazonCard.aspx.cs" Inherits="termProject.amazonCard" %>

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
        <div>
            <div class="navbar">
                <ul>
                    <asp:Label ID="lblDepartments" runat="server" Text="Departments       " style="font-size: x-large"></asp:Label>
                    <asp:DropDownList ID="ddlDepartments" runat="server" Height="40px" Width="206px" style="font-size: large" ></asp:DropDownList>
 
 
  <li class="auto-style2"><a href="merchantRegistrationPage.aspx" class="auto-style5"><span class="auto-style3">Register as Merchant</span></a></li>
  <li class="auto-style2"><a href="cardManager.aspx" class="auto-style5"><span class="auto-style3">My Account</span></a></li>
  <li class="auto-style2"><a href="MyCart.aspx" class="auto-style5"><span class="auto-style3">Your Cart</span></a></li>
  <li class="auto-style2"><a href="storeHome.aspx" class="auto-style5"><span class="auto-style3">Home</span></a></li>
  </ul>
             </div>

        </div>
   <p></p>
        <p></p>
        <table align="center" style="height: 175px; width: 530px">
            <tr>
                <td>
                    <asp:Button ID ="btnApply" runat="server" Text="Apply" Width="527px" style="background-color:#FFD57B; font-size: medium; font-weight: 700;" OnClick="btnApply_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblCardNum" runat="server" Text="Your Card Number:"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="lblExpiration" runat="server" Text="Card Expiration:"></asp:Label>
                    <br />
                    <br />
        <asp:Label ID="lblFirstName" runat="server" Text="First Name:"></asp:Label>
                    <br />
                    <br />
        <asp:Label ID="lblLastName" runat="server" Text="Last Name:"></asp:Label>
                    <br />
                    <br />
                    <br />
                    <asp:Label ID="lblConfirmCard" runat="server"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="lblYouHaveCard" runat="server"></asp:Label>
                </td>
            </tr>
            </table>
        <p>
                    &nbsp;</p>
        <br />
        <br />
    </form>
</body>
</html>
