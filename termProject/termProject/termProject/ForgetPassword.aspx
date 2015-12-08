<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgetPassword.aspx.cs" Inherits="termProject.ForgetPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
        <h3>
            <asp:Label ID="Label1" runat="server" Text="Password assistance"></asp:Label>
        </h3>
        <asp:Label ID="Label2" runat="server" Text="Enter the email address  associated with your account, then click Continue. "></asp:Label>
        <br />
        <asp:Label ID="Label6" runat="server" Text="We'll send you a link to a page where you can easily create a new password."></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Email:"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="txtForgetEmail" runat="server" Height="31px" Width="232px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnContinue" runat="server" Height="42px" Text="Continue" Width="138px" />
    
        <br />
        <br />
        <asp:Label ID="lblMsg1" runat="server" Text="Label"></asp:Label>
    
    <div>
    
    </div>
    </form>
</body>
</html>
