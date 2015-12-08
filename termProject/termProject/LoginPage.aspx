<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="termProject.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 1883px;
            height: 144px;
            text-align: center;
        }
        .auto-style3 {
            color: #999999;
        }
        
            .centered {
            text-align: center;
        }
        
           
        
            .auto-style4 {
            color: #333333;
        }
        
           
        
            </style>
</head>

<body>
    <form id="form1" runat="server">
        <p>
            <img alt="amazon" class="auto-style2" src="Images/abc.png" />
        </p>
        <div class="center">
            <p>
                &nbsp;
            </p>
        </div>
        <p>
            &nbsp;
        </p>
        <asp:Panel ID="Panel1" align="center" runat="server" BorderColor="#CCCCCC" BorderWidth="1px" Style="position: relative; top: -76px; left: 792px" Width="325px">
            <div>
                <p>
                    &nbsp;&nbsp;
                    <asp:Label ID="lblSignIN0" runat="server" Style="font-size: xx-large" Text="Sign In"></asp:Label>
                </p>
                <p>I am a:</p>
                <p>
                    Customer<asp:RadioButton ID="rdbCustomer" runat="server" Checked GroupName="Role" /> <br />
 
                  Merchant <asp:RadioButton ID="rdbMerchant" runat="server" GroupName="Role" /></p>
                <p>
                    &nbsp;&nbsp;
                    <asp:Label ID="lblUserName" runat="server" Text="Email" Style="font-weight: 700"></asp:Label>
                </p>
                    <p>
                    &nbsp;&nbsp;
                    <asp:TextBox ID="txtUserName" runat="server" Height="25px" Width="284px"></asp:TextBox>
                </p>
                <p>
                    &nbsp;&nbsp;
                    <asp:Label ID="lblPassword" runat="server" Text="Password" Style="font-weight: 700"></asp:Label>
                </p>
                <p>
                    &nbsp;&nbsp;
                    <asp:TextBox ID="txtPassword" runat="server" Height="25px" Width="284px" TextMode="Password"></asp:TextBox>
                </p>
                <p>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Forget Password?</asp:LinkButton>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                </p>
                <p>
                    &nbsp;
                    <asp:Button ID="btnLogin" runat="server" Height="30px" Style="background-color: #FFD57B; font-weight: 700;" Text="Sign in" Width="292px" OnClick="btnLogin_Click2" />
                </p>
                <p class="auto-style3">
                    &nbsp;&nbsp;&nbsp; -----------------New to Amazon?----------------
                    <asp:CheckBox ID="chkRemember" runat="server" OnCheckedChanged="chkRemember_CheckedChanged"  /> <span class="auto-style4">Remember me </span> 
                </p>
                <p class="auto-style3">
                    &nbsp;&nbsp;
                    <asp:Button ID="btnCreateAccount" runat="server" Height="30px" Style="background-color: #E6E6E6; font-weight: 700;" Text="Create an account" Width="289px" OnClick="btnCreateAccount_Click2" />
                </p>
            </div>
        </asp:Panel>

        <p style="margin-left: 800px">
            <asp:Label ID="lblMsg" runat="server" Text="*"></asp:Label>
        </p>

    </form>

</body>
</html>
