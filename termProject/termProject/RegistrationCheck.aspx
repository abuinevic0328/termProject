<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationCheck.aspx.cs" Inherits="termProject.RegistrationCheck" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
              <link rel="stylesheet" type="text/css" href="StyleSheetControls.css"/>

</head>
<body>
    <form id="form1" runat="server">
    <div>
    <img alt="amazon" class="auto-style7" src="Images/abc.png" />
        </div>

        <div class="center">
            <p>
            <asp:Button ID="btnCustomer" class="yellowbutton" runat="server" Text="Register as a Customer" OnClick="btnCustomer_Click" Width="312px"></asp:Button>
                </p>
            <br />
            <asp:Button ID="btnMerchant" class="greyButton" runat="server" Text="Register as a Merchant" Width="313px" OnClick="btnMerchant_Click"></asp:Button>
        </div>
    </form>
</body>
</html>
