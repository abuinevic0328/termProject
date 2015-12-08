<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="termProject.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="lblUserName" runat="server" Text="User Name: " style="position:absolute; top: 138px; left: 108px;"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" Width="200px" style="position:absolute; top: 135px; left: 202px;"></asp:TextBox>
        <asp:Label ID="lblPassword" runat="server" Text="Password: " style="position:absolute; top: 194px; left: 106px;"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" Width="200px" style="position:absolute; top: 194px; left: 201px;"></asp:TextBox>
        <asp:Button ID="btnLogin" runat="server" Text="Login" style ="position:absolute; top: 241px; left: 199px;"/>
        <p>
        <asp:Button ID="btnCreateAccount" runat="server" Text="Create Account" style ="position:absolute; top: 243px; left: 304px;"/>
        </p>
    </form>
</body>
</html>
