<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="merchantRegistrationPage.aspx.cs" Inherits="termProject.merchantRegistrationPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="StyleSheetControls.css"/>
  
</head>
<body>
    <form id="form1" runat="server">
        <div>
    
        <img alt="amazon" class="auto-style7" src="Images/abc.png" /></div>
        <br />
        
            <div class ="center">
        <h2 class="Title">Thank you for wanting to sell with us!</h2>
        <h3 class="Title">Please fill out the following information in order to register:</h3>

   
        <table align="center" style="height: 175px; width: 660px">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblGroupMember1" runat="server" Text="Group Member 1 Name:" Style="font-weight: 700"></asp:Label>
                    <span class="auto-style2"><strong>*</strong></span></td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtGroupMember1" class="txt" runat="server" Height="30px" Width="331px"></asp:TextBox></td>

            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblGroupMember2" runat="server" Text="Group Member 2 Name:" Style="font-weight: 700"></asp:Label>
                    <span class="auto-style2"><strong>*</strong></span></td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtGroupMember2" class="txt" runat="server" Height="30px" Width="331px"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblPhoneNum" runat="server" Text="Phone Number:" Style="font-weight: 700"></asp:Label>
                    <span class="auto-style2"><strong>*</strong></span></td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtPhoneNum" class="txt" runat="server" Height="30px" Width="331px"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblURL" runat="server" Text="Web Services URL:" Style="font-weight: 700"></asp:Label>
                    <span class="auto-style2"><strong>*</strong></span></td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtURL" class="txt" runat="server" Height="30px" Width="331px"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblDescription" runat="server" Text="Description of Your Site:" Style="font-weight: 700"></asp:Label>
                    <span class="auto-style2"><strong>*</strong></span></td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtDescription" class="txt" runat="server" Height="30px" Width="331px"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblEmail" runat="server" Text="Your Email Address:" Style="font-weight: 700"></asp:Label>
                    <span class="auto-style2"><strong>*</strong></span></td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtEmail" class="txt" runat="server" Height="30px" Width="331px"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblPassword" runat="server" Text="Your Password:" Style="font-weight: 700"></asp:Label>
                    <span class="auto-style2"><strong>*</strong></span></td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtPassword" class="txt" runat="server" Height="30px" Width="331px" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblSiteID" runat="server" Text="Your SiteID:" Style="font-weight: 700"></asp:Label>
                    <span class="auto-style2"><strong>*</strong></span></td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtSiteID" class="txt" runat="server" Height="30px" Width="331px"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblShowAPI" runat="server" Text="Your Unique Selling Key:" Style="font-weight: 700"></asp:Label>
                    <%--<span class="auto-style2"><strong>*</strong></span></td>--%>
                <td class="auto-style1">
                    <asp:Label ID="lblAPI" runat="server"></asp:Label></td>
            </tr>      
            
        </table>
            
       
                 <p style="margin-left: 200px"> 
             <asp:Button ID="btnRegister" class="yellowbutton" runat="server" OnClick="btnRegister_Click" Text="Register" style="text-align: center" Width="166px" /> </p>
                <p style="margin-left: 200px"> 
        


        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblMerchantAdded" runat="server" style="color: #CC0000; font-weight: 700">***</asp:Label>
        
        
                </p>
        


         </div>
        
    </form>
</body>
</html>
