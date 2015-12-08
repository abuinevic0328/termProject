<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccountPage.aspx.cs" Inherits="termProject.AccountPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .center {
            margin-left: 720px;
        }
        .auto-style2 {
            font-size: x-large;
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
            font-size: medium;
        }
        .navbar {
            text-align: center;
        }
        .auto-style5 {
            text-decoration: none;
        }   
        .auto-style6 {
            color: #666666;
            font-size: medium;
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
                    <asp:Label ID="lblDepartments" runat="server" Text="Departments       " style="font-size: large"></asp:Label>
                    <asp:DropDownList ID="ddlDepartments" runat="server" Height="40px" Width="206px" style="font-size: large"  ></asp:DropDownList>
 
  <li class="auto-style2"><a href="merchantRegistrationPage.aspx" class="auto-style5"><span class="auto-style3"><strong>Register as Merchant</strong></span></a></li>
  <li class="auto-style2"><a href="cardManager.aspx" class="auto-style5"><span class="auto-style3"><strong>My Account</strong></span></a></li>
  <li class="auto-style2"><a href="MyCart.aspx" class="auto-style5"><span class="auto-style3"><strong>Your Cart</strong></span></a></li>
  <li class="auto-style2"><a href="storeHome.aspx" class="auto-style5"><span class="auto-style6"><strong>Home</strong></span></a></li>
  </ul>
             </div>

        </div>
         <p>&nbsp</p>
         <p>&nbsp</p>
        <div class="center">
    <div>
        <h2>
            <asp:Label ID="lbl1" runat="server" Text="Change Account Settings"></asp:Label>
        </h2>
        <br />
        <div class="col-md-10"></div>
        <h4>
            <asp:Label ID="lblNameChange" runat="server" style="font-size: medium" Text="Name:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnEditName" runat="server" Height="36px" style="color: #333333; font-weight: 700" Text="Edit" Width="95px" OnClick="btnEditName_Click" />
        </h4>
        <asp:Label ID="lblName" runat="server" Text="_name_"></asp:Label>
        <br />
        <h4>
            <asp:Label ID="lblEmailChange" runat="server" Text="E-mail:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnEditEmail" runat="server" Height="36px" style="color: #333333; font-weight: 700" Text="Edit" Width="95px" />
        </h4>
        <asp:Label ID="lblEmail" runat="server" Text="_email_"></asp:Label>
        <br />
        <h4>
            <asp:Label ID="lblPhoneChange" runat="server" Text="Mobile Phone Number:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnEditPhone" runat="server" Height="36px" style="color: #333333; font-weight: 700" Text="Edit" Width="95px" />
        </h4>
        <asp:Label ID="lblPhone" runat="server" Text="_phone_"></asp:Label>
        <br />
        <h4>
            <asp:Label ID="lblPasswordChange" runat="server" Text="Password"></asp:Label>
            :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnEditPassword" class="greyButton" runat="server" Height="36px" style="color: #333333; font-weight: 700" Text="Edit" Width="95px" OnClick="btnEditPassword_Click" />
        </h4>
        <asp:Label ID="lblPassword" runat="server" Text="_password_"></asp:Label>
        <br />
    
    </div>
<%--                        </asp:Panel>--%>

        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnDone" class="yellowButton" runat="server" BackColor="#FFD57B" Height="36px" OnClick="btnDone_Click" style="color: #333333; font-weight: 700" Text="Done" Width="95px" />
        </p>
        <p>
            &nbsp;</p>
        </div>
    </form>
</body>
</html>
