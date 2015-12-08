<%@ Page Title="" Language="C#" MasterPageFile="~/ClientInformation.Master" AutoEventWireup="true" CodeBehind="Client_Reset_Name.aspx.cs" Inherits="termProject.Client_Reset_Name" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <script src="AJAXSample1.js"></script>
    <script type="text/javascript">
        var makeChng = new MakeChange();

        function UpdateName() {

            var name = document.getElementById("name_input").value;

            var result = makeChng.makeRequest("UpdateField.ashx?name=" + name);
            if (result == 1)
               alert("Your name was changed successfully!");
                
            else
                if (result == 0)
                   alert("Your name has not been changed. An error ocurred!");


        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="center">
     <h2>
            <asp:Label ID="Label1" runat="server" Text="Change Your Name"></asp:Label>
        </h2>
        <asp:Label ID="Label2" runat="server" Text="If you want to change the name associated with your account, you may do so below. "></asp:Label>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Be sure to click the Save Changes button when you are done."></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="New Name:"></asp:Label>
        <br />
        
    <input type="text" class="txt" id="name_input" />
         <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <input type="button" value="Change name!" onclick="UpdateName()" class="yellowbutton" />

        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblMsg" runat="server" Text="***" style="color: #CC0000"></asp:Label>
        <p id="p_message"></p>
        </div>
</asp:Content>
