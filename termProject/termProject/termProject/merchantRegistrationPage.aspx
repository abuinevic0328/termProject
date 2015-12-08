<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="merchantRegistrationPage.aspx.cs" Inherits="termProject.merchantRegistrationPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 339px;
        }

        .auto-style2 {
            text-align: center;
        }
        .Title {
            text-align:center;
        }

        .auto-style7 {
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
        .auto-style3 {
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
    
        <img alt="amazon" class="auto-style7" src="Images/amazon.png" /></div>
        <div>
            <div class="navbar">
                <ul>
<li class="auto-style2"><a href="merchantRegistrationPage.aspx" class="auto-style5"><span class="auto-style3">Register as Merchant</span></a></li>
  <li class="auto-style2"><a href="cardManager.aspx" class="auto-style5"><span class="auto-style3">My Account</span></a></li>
  <li class="auto-style2"><a href="MyCart.aspx" class="auto-style5"><span class="auto-style3">Your Cart</span></a></li>
  <li class="auto-style2"><a href="storeHome.aspx" class="auto-style5"><span class="auto-style3">Home</span></a></li>
  </ul>
             </div>

        </div>
    <div class ="Title">
        <h2>Thank you for wanting to sell with us!</h2>
        <h3>Please fill out the following information in order to register:</h3>
    </div>
        <table align="center" style="height: 175px; width: 660px">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblGroupMember1" runat="server" Text="Group Member 1 Name:" Style="font-weight: 700"></asp:Label>
                    <span class="auto-style2"><strong>*</strong></span></td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtGroupMember1" runat="server" Height="30px" Width="331px"></asp:TextBox></td>

            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblGroupMember2" runat="server" Text="Group Member 2 Name:" Style="font-weight: 700"></asp:Label>
                    <span class="auto-style2"><strong>*</strong></span></td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtGroupMember2" runat="server" Height="30px" Width="331px"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblPhoneNum" runat="server" Text="Phone Number:" Style="font-weight: 700"></asp:Label>
                    <span class="auto-style2"><strong>*</strong></span></td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtPhoneNum" runat="server" Height="30px" Width="331px"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblURL" runat="server" Text="Web Services URL:" Style="font-weight: 700"></asp:Label>
                    <span class="auto-style2"><strong>*</strong></span></td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtURL" runat="server" Height="30px" Width="331px"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblDescription" runat="server" Text="Description of Your Site:" Style="font-weight: 700"></asp:Label>
                    <span class="auto-style2"><strong>*</strong></span></td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtDescription" runat="server" Height="30px" Width="331px"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblEmail" runat="server" Text="Your Email Address:" Style="font-weight: 700"></asp:Label>
                    <span class="auto-style2"><strong>*</strong></span></td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtEmail" runat="server" Height="30px" Width="331px"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblSiteID" runat="server" Text="Your SiteID:" Style="font-weight: 700"></asp:Label>
                    <span class="auto-style2"><strong>*</strong></span></td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtSiteID" runat="server" Height="30px" Width="331px"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblShowAPI" runat="server" Text="Your Unique Selling Key:" Style="font-weight: 700"></asp:Label>
                    <%--<span class="auto-style2"><strong>*</strong></span></td>--%>
                <td class="auto-style1">
                    <asp:Label ID="lblAPI" runat="server"></asp:Label></td>
            </tr>      
            
        </table>
        <p>  <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" Text="Register" style="text-align: center; position: relative; top: 0px; left: -1px" /> </p>
        




        <br />
        <p>
        <asp:Label ID="lblMerchantAdded" runat="server"></asp:Label>
        
        
        </p>
        
        
    </form>
</body>
</html>
