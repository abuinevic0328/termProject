<%@ Page Title="" Language="C#" MasterPageFile="~/ClientInformation.Master" AutoEventWireup="true" CodeBehind="Client_Reset_PhoneNumber.aspx.cs" Inherits="termProject.Client_Reset_PhoneNumber" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    
    
    
   
    <div class="center">
     <h2>
            <asp:Label ID="Label1" runat="server" Text="Change Your Phone Number"></asp:Label>
        </h2>
        <asp:Label ID="Label2" runat="server" Text="If you want to change the phone number associated with your account, you may do so below. "></asp:Label>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Be sure to click the Save Changes button when you are done."></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="Email:"></asp:Label>
        <br />
        <asp:TextBox ID="txtCurrentEmail" class="txt"  runat="server" Height="31px" Width="232px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="New Phone Number:"></asp:Label>
        <br />
        <asp:TextBox ID="txtPhonenumber" class="txt"  runat="server" Height="31px" Width="232px"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSaveChanges" class="yellowbutton" runat="server" Height="38px" Text="Save Changes" Width="167px" OnClick="btnSaveChanges_Click" />
    
 
    
        <br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblMsg" runat="server" style="text-align: center; color: #CC0000; font-weight: 700;">***</asp:Label>
    
    </div>
</asp:Content>
