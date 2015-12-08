<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgetPassword.aspx.cs" Inherits="termProject.ForgetPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
            <link rel="stylesheet" type="text/css" href="StyleSheetControls.css"/>

</head>
<body>
    <form id="form1" runat="server">
        <p>
            <img alt="amazon" class="auto-style2" src="Images/abc.png" />
        </p>
    <div class="center">
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
        <asp:TextBox ID="txtForgetEmail" class="txt" runat="server" Height="31px" Width="232px"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnContinue" CssClass="yellowbutton" runat="server" Height="42px" Text="Continue" Width="138px" BackColor="#FFD57B" OnClick="btnContinue_Click" />
    
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblMsg1" runat="server" style="color: #CC0000; font-weight: 700">***</asp:Label>
    
    <div>
    </div>
    </div>
    </form>
</body>
</html>
