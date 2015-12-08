<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResetPassword.aspx.cs" Inherits="termProject.PasswordChange" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h3>
            <asp:Label ID="Label1" runat="server" Text="Change Password"></asp:Label>
        </h3>
        <asp:Label ID="Label2" runat="server" Text="Use the form below to change the password for your account"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Current email:"></asp:Label>
        <br />
        <asp:TextBox ID="txtCurrentEmail" runat="server" Height="31px" Width="232px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Current password:"></asp:Label>
        <br />
        <asp:TextBox ID="txtCurrentPassword" runat="server" Height="31px" Width="232px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="New password:"></asp:Label>
        <br />
        <asp:TextBox ID="txtNewPassword" runat="server" Height="31px" Width="232px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnSaveChanges" class="yellowButton" runat="server" Height="38px" Text="Save Changes" Width="132px" OnClick="btnSaveChanges_Click" />
    
        <br />
        <br />
        <asp:Label ID="lblMsg" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
