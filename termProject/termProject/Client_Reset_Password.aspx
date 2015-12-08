<%@ Page Title="" Language="C#" MasterPageFile="~/ClientInformation.Master" AutoEventWireup="true" CodeBehind="Client_Reset_Password.aspx.cs" Inherits="termProject.Client_Reset_Password" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="center" >
    
        <h2>
            <asp:Label ID="Label1" runat="server" Text="Change Password"></asp:Label>
        </h2>
        <asp:Label ID="Label2" runat="server" Text="Use the form below to change the password for your account."></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Current email * :"></asp:Label>
        <br />
        <asp:TextBox ID="txtCurrentEmail" class="txt"  runat="server" Height="31px" Width="232px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Current password * :"></asp:Label>
        <br />
        <asp:TextBox ID="txtCurrentPassword" class="txt"  runat="server" Height="31px" Width="232px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="New password * :"></asp:Label>
        <br />
        <asp:TextBox ID="txtNewPassword" class="txt"  runat="server" Height="31px" Width="232px"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSaveChanges" class="yellowbutton" runat="server" Height="38px" Text="Save Changes" Width="165px" OnClick="btnSaveChanges_Click" />
    
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblMsg" runat="server" Text="***" style="color: #CC0000"></asp:Label>
    
    </div>
</asp:Content>
