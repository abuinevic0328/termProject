<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResetEmail.aspx.cs" Inherits="termProject.ResetEmail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
    <div>
    
        <h3>
            <asp:Label ID="Label1" runat="server" Text="Change Email"></asp:Label>
        </h3>
        <asp:Label ID="Label2" runat="server" Text="Use the form below to change the email for your account"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Current email:"></asp:Label>
        <br />
        <asp:TextBox ID="txtCurrentEmail" runat="server" Height="31px" Width="232px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Password:"></asp:Label>
        <br />
        <asp:TextBox ID="txtPassword" runat="server" Height="31px" Width="232px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Reenter new email:"></asp:Label>
        <br />
        <asp:TextBox ID="txtNewEmail2" runat="server" Height="31px" Width="232px"></asp:TextBox>
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
