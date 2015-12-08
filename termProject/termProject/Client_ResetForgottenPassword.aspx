<%@ Page Title="" Language="C#" MasterPageFile="~/ClientInformation.Master" AutoEventWireup="true" CodeBehind="Client_ResetForgottenPassword.aspx.cs" Inherits="termProject.Client_ResetForgottenPassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="center">

       <h2>Reset Forgotten Password</h2>

        <h3>Please enter the new password then click Reset.</h3>

   <table align="center" style="height: 85px; width: 500px">
      <tr>
           <td>
              <asp:Label ID="pass1" runat="server" Text="Enter the new Password:"></asp:Label>
           </td>
           <td>
             <asp:TextBox ID="txtNewPassword1" class="txt"  runat="server" Height="30px" Width="245px"></asp:TextBox>
           </td>
       </tr>              
       <tr>
           <td>
               <br />
             <asp:Label ID="Label1" runat="server" Text="Verify the new Password:"></asp:Label>
           </td>
           <td>
             <asp:TextBox ID="txtNewPassword2" class="txt"  runat="server" Height="31px" Width="245px"></asp:TextBox>
               <br />
           </td>
       </tr> 
       <br /> 
       </table>           
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:Button ID="btnReset" class="yellowbutton" runat="server" Text="Reset" OnClick="btnReset_Click" Width="98px"></asp:Button>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                         <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                         <asp:Label ID="lblMsg" runat="server" Text="***" style="color: #CC0000"></asp:Label>


        </div>
</asp:Content>
