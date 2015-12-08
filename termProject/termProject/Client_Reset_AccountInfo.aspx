<%@ Page Title="" Language="C#" MasterPageFile="~/ClientInformation.Master" AutoEventWireup="true" CodeBehind="Client_Reset_AccountInfo.aspx.cs" Inherits="termProject.Reset_Account_Info" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   

<div class="center" >
             <h2 class="auto-style4">
            <asp:Label ID="lbl1" runat="server" Text="Change Account Settings"></asp:Label>
        </h2>
        <div class="auto-style4">
        <br />
      
        </div>
      
        <h4 class="auto-style4">
            <asp:Label ID="lblNameChange" runat="server" style="font-size: medium" Text="Name:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnEditName" runat="server" Height="36px" style="color: #333333; font-weight: 700" Text="Edit" Width="95px" OnClick="btnEditName_Click" />
        </h4>
        <div class="auto-style4">
        <asp:Label ID="lblName" runat="server" Text="_name_"></asp:Label>
        <br />
        </div>
        <h4 class="auto-style4">
            <asp:Label ID="lblEmailChange" runat="server" Text="E-mail:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnEditEmail" runat="server" Height="36px" style="color: #333333; font-weight: 700" Text="Edit" Width="95px" OnClick="btnEditEmail_Click" />
        </h4>
        <div class="auto-style4">
        <asp:Label ID="lblEmail" runat="server" Text="_email_"></asp:Label>
        <br />
        </div>
        <h4 class="auto-style4">
            <asp:Label ID="lblPhoneChange" runat="server" Text="Mobile Phone Number:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnEditPhone" runat="server" Height="36px" style="color: #333333; font-weight: 700" Text="Edit" Width="95px" OnClick="btnEditPhone_Click" />
        </h4>
        <div class="auto-style4">
        <asp:Label ID="lblPhone" runat="server" Text="_phone_"></asp:Label>
        <br />
        </div>
        <h4 class="auto-style4">
            <asp:Label ID="lblPasswordChange" runat="server" Text="Password"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnEditPassword" runat="server" Height="36px" style="color: #333333; font-weight: 700" Text="Edit" Width="95px" OnClick="btnEditPassword_Click1" />
        </h4>
        <div class="auto-style4">
        <asp:Label ID="lblPassword" runat="server" Text="_password_"></asp:Label>
        <br />
    <br />
          :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  <asp:Button ID="btnDone" class="yellowButton" runat="server" BackColor="#FFD57B" Height="36px" OnClick="btnDone_Click" style="color: #333333; font-weight: 700; text-align: center;" Text="Done" Width="95px" />
        </div>
    
    </div>
<%--                        </asp:Panel>--%>

       
      
</asp:Content>
