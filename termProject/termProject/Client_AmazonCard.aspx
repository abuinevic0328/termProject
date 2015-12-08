<%@ Page Title="" Language="C#" MasterPageFile="~/ClientInformation.Master" AutoEventWireup="true" CodeBehind="Client_AmazonCard.aspx.cs" Inherits="termProject.Client_AmazonCard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <table align="center" style="height: 175px; width: 530px">
            <tr>
                <td>
                    <asp:Button ID ="btnApply" runat="server" Text="Apply" Width="527px" style="background-color:#FFD57B; font-size: medium; font-weight: 700;" OnClick="btnApply_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblCardNum" runat="server" Text="Your Card Number:"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="lblExpiration" runat="server" Text="Card Expiration:"></asp:Label>
                    <br />
                    <br />
        <asp:Label ID="lblFirstName" runat="server" Text="First Name:"></asp:Label>
                    <br />
                    <br />
        <asp:Label ID="lblLastName" runat="server" Text="Last Name:"></asp:Label>
                    <br />
                    <br />
                    <br />
                    <asp:Label ID="lblConfirmCard" runat="server"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="lblYouHaveCard" runat="server"></asp:Label>
                </td>
            </tr>
            </table>
        <p>
                    &nbsp;</p>
</asp:Content>
