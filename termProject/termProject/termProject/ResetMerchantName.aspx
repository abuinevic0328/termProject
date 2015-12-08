<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResetMerchantName.aspx.cs" Inherits="termProject.ResetMerchantName" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h3>
            <asp:Label ID="Label1" runat="server" Text="Change Your Name"></asp:Label>
        </h3>
        <asp:Label ID="Label2" runat="server" Text="If you want to change the name associated with your account, you may do so below. "></asp:Label>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Be sure to click the Save Changes button when you are done."></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="Current Merchant Email:"></asp:Label>
        <br />
        <asp:TextBox ID="txtCurrentMerchantEmail" runat="server" Height="31px" Width="232px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Member 1 Name:"></asp:Label>
        <br />
        <asp:TextBox ID="txtNewMerchantName" runat="server" Height="31px" Width="232px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label8" runat="server" Text="Member 2 Name:"></asp:Label>
        <br />
        <asp:TextBox ID="txtNewMerchantName2" runat="server" Height="31px" Width="232px"></asp:TextBox>
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
