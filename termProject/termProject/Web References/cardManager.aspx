<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cardManager.aspx.cs" Inherits="termProject.cardManager" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
      
        ul {
    list-style-type: initial;
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
        
.text {
 color: black;
 font-family: serif;
 font-size:medium;
 text-align: center;
        }
        .navbar {
            text-align: center;
        }  
        .navText {
            color: #666666;
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
         <div>
    
        <img alt="amazon" src="Images/amazon.png" /></div>
            <div class="navbar">
                <ul>
  
  <li><a href="merchantRegistrationPage.aspx"><span class="navText">Register as Merchant</span></a></li>
  <li><a href="cardManager.aspx" ><span class="navText">My Account</span></a></li>
  <li><a href="MyCart.aspx" ><span class="navText">Your Cart</span></a></li>
  <li><a href="storeHome.aspx"><span class="navText">Home</span></a></li>
  </ul>
        </div>
        <p></p>
                <p></p>


        <h2>
            &nbsp;<asp:Label ID="lblAddCard" runat="server" Text="Add Credit Card"></asp:Label>
        </h2>

        <table align="center" style="height: 175px; width: 530px">
            <tr>
                <td class="text">
                    <asp:Label ID="lblCardNum" runat="server" Style="font-weight: 700" Text="Card Number:"></asp:Label>: <span class="text"><strong>*</strong></span></td>
                <td>
                    <asp:TextBox ID="txtCardNum" runat="server" Height="30px" Width="330px"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="text">
                    <asp:Label ID="lblFirstName" runat="server" Style="font-weight: 700" Text="First Name:"></asp:Label>: <span class="text"><strong>*</strong></span></td>
                <td>
                    <asp:TextBox ID="txtFirstName" runat="server" Height="30px" Width="330px"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="text">
                    <asp:Label ID="lblLastName" runat="server" Style="font-weight: 700" Text="Last Name:"></asp:Label>: <span class="text"><strong>*</strong></span></td>
                <td>
                    <asp:TextBox ID="txtLastName" runat="server" Height="30px" Width="330px"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="text">
                    <asp:Label ID="lblCardType" runat="server" Style="font-weight: 700" Text="Card Type: "></asp:Label><span class="text"><strong>*</strong></span></td>
                <td>
                    <asp:DropDownList ID="ddlCardType" runat="server" Height="30px">
                        <asp:ListItem>American Express</asp:ListItem>
                        <asp:ListItem>Discover</asp:ListItem>
                        <asp:ListItem>Master Card</asp:ListItem>
                        <asp:ListItem>Visa</asp:ListItem>
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td class="text">&nbsp;
                            <asp:Label ID="lblExpiration" runat="server" Style="font-weight: 700" Text="Expiration:"></asp:Label>&nbsp;<span class="text"><strong>*&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong></span></td>
                <td>
                    <asp:DropDownList ID="ddlMonth" runat="server">
                        <asp:ListItem>01</asp:ListItem>
                        <asp:ListItem>02</asp:ListItem>
                        <asp:ListItem>03</asp:ListItem>
                        <asp:ListItem>04</asp:ListItem>
                        <asp:ListItem>05</asp:ListItem>
                        <asp:ListItem>06</asp:ListItem>
                        <asp:ListItem>07</asp:ListItem>
                        <asp:ListItem>08</asp:ListItem>
                        <asp:ListItem>09</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                        <asp:ListItem>11</asp:ListItem>
                        <asp:ListItem>12</asp:ListItem>
                    </asp:DropDownList>
                
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>2015</asp:ListItem>
                        <asp:ListItem>2016</asp:ListItem>
                        <asp:ListItem>2017</asp:ListItem>
                        <asp:ListItem>2018</asp:ListItem>
                        <asp:ListItem>2019</asp:ListItem>
                        <asp:ListItem>2020</asp:ListItem>
                        <asp:ListItem>2021</asp:ListItem>
                        <asp:ListItem>2022</asp:ListItem>
                        <asp:ListItem>2023</asp:ListItem>
                        <asp:ListItem>2024</asp:ListItem>
                        <asp:ListItem>2025</asp:ListItem>
                        <asp:ListItem>2026</asp:ListItem>
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td class="text">
                    <asp:Label ID="lblCVV" runat="server" Style="font-weight: 700" Text="CVV:"></asp:Label><span class="text"><strong>*</strong></span></td>
                <td>
                    <asp:TextBox ID="txtCVV" runat="server" Height="30px" Width="100px"></asp:TextBox></td>
            </tr>
            


        </table>
        <div style="margin-left: 320px" class="text">
                    <asp:Button ID="btnAddCard" runat="server" Text="Add Card" BorderStyle="None" Height="35px" Style="position: relative; top: 0px; left: -10px; font-weight: 700" OnClick="btnAddCard_Click" />
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" BorderStyle="None" Height="35px" Style="font-weight: 700" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </div>

        
        <br />
        <br />
        <table align="center" style="margin-bottom:5px">
            <tr>
                <td>
                    <asp:Button ID="btnLogin" runat="server" Height="30px" Style="background-color: #FFD57B; " Text="Apply For Amazon Card" Width="292px" OnClick="btnLogin_Click" />
                </td>
            </tr>
        </table>
        <div style="text-align:center">Your Cards:</div>
        <table align="center" style="margin-bottom:5px; margin-top:5px">
            <tr>
                <td>
                    <asp:GridView ID="gvShowCards" runat="server" AutoGenerateColumns="False" OnRowCommand="gvShowCards_RowCommand">
                        <Columns>
                            <asp:BoundField DataField="cardNum" HeaderText="Card Number" />
                            <asp:BoundField DataField="cardFName" HeaderText="First Name" />
                            <asp:BoundField DataField="cardLName" HeaderText="Last Name" />
                            <asp:BoundField DataField="cardExpiration" HeaderText="Expiration" />
                            <asp:BoundField DataField="cardVerification" HeaderText="Verification" />
                            <asp:BoundField DataField="cardType" HeaderText="Card Type" />
                            <asp:ButtonField ButtonType="Button" CommandName="btnEdit" HeaderText="Edit" Text="Edit" />
                            <asp:ButtonField ButtonType="Button" CommandName="btnRemove" HeaderText="Remove" Text="Remove" />
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
