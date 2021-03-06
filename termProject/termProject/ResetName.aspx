﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResetName.aspx.cs" Inherits="termProject.ResetName" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
    <div>
    
        <h3>
            <asp:Label ID="Label1" runat="server" Text="Change Your Name"></asp:Label>
        </h3>
        <asp:Label ID="Label2" runat="server" Text="If you want to change the name associated with your account, you may do so below. "></asp:Label>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Be sure to click the Save Changes button when you are done."></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="Current email:"></asp:Label>
        <br />
        <asp:TextBox ID="txtCurrentEmail" runat="server" Height="31px" Width="232px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="New Name:"></asp:Label>
        <br />
        <asp:TextBox ID="txtNewName" runat="server" Height="31px" Width="232px"></asp:TextBox>
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
