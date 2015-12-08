<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registrationPage.aspx.cs" Inherits="termProject.registrationPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
            <link rel="stylesheet" type="text/css" href="StyleSheetControls.css"/>

</head>
<body>
    <form id="form1" runat="server">
       <div>
    
        <img alt="amazon" class="auto-style7" src="Images/abc.png" /></div>
        <br />
          
          
        <div class="down">
          <h2>
                Create Account</h2>
            
            <table align="center" style="height: 175px; width: 530px">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblFirstName" runat="server" Text="First Name:" Style="font-weight: 700"></asp:Label>
                        <span class="auto-style7"><strong>*</strong></span></td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtFirstName" class="txt" runat="server" Height="30px" Width="331px"></asp:TextBox></td>

                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblLastName" runat="server" Text="Last Name:" Style="font-weight: 700"></asp:Label>
                        <span class="auto-style7"><strong>*</strong></span></td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtLastName"  class="txt" runat="server" Height="30px" Width="329px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblPhone" runat="server" Style="font-weight: 700" Text="Phone Number:"></asp:Label>&nbsp;<span class="auto-style7"><strong>*</strong></span></td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtPhone" class="txt" runat="server" Height="30px" Width="330px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblEmail" runat="server" Style="font-weight: 700" Text="Email:"></asp:Label>&nbsp;<span class="auto-style7"><strong>*</strong></span></td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtEmail" class="txt" runat="server" Height="30px" Width="330px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblPassword" runat="server" Style="font-weight: 700" Text="Password"></asp:Label>: <span class="auto-style7"><strong>*</strong></span></td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtPassword" class="txt" runat="server" Height="30px" Width="330px"></asp:TextBox></td>
                </tr>


            </table>
            <p class="auto-style2">
                <asp:Label ID="lblShipping" runat="server" Text="Please enter the shipping information" style="font-size: large"></asp:Label>
            </p>
                          <table align="center" style="height: 175px; width: 530px">
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="lblAddress" runat="server" Style="font-weight: 700" Text="Shipping Address"></asp:Label>: <span class="auto-style7"><strong>*</strong></span></td>
                        <td class="auto-style1">
                            <asp:TextBox ID="txtAddress"  class="txt" runat="server" Height="30px" Width="330px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style3">
                            <asp:Label ID="lblCity" runat="server" Style="font-weight: 700" Text="City: "></asp:Label><span class="auto-style7"><strong>*</strong></span></td>
                        <td class="auto-style4">
                            <asp:TextBox ID="txtCity"  class="txt" runat="server" Height="30px" Width="331px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="lblState" runat="server" Style="font-weight: 700" Text="State/Province:"></asp:Label>&nbsp;<span class="auto-style7"><strong>*</strong></span></td>
                        <td class="auto-style1">
                            <asp:DropDownList ID="ddlState1" class="txt" runat="server" Height="30px">
                                <asp:ListItem>AK</asp:ListItem>
                                <asp:ListItem>AL</asp:ListItem>
                                <asp:ListItem>AR</asp:ListItem>
                                <asp:ListItem>AZ</asp:ListItem>
                                <asp:ListItem>CA</asp:ListItem>
                                <asp:ListItem>CO</asp:ListItem>
                                <asp:ListItem>CT</asp:ListItem>
                                <asp:ListItem>DE</asp:ListItem>
                                <asp:ListItem>FL</asp:ListItem>
                                <asp:ListItem>GA</asp:ListItem>
                                <asp:ListItem>HI</asp:ListItem>
                                <asp:ListItem>IA</asp:ListItem>
                                <asp:ListItem>ID</asp:ListItem>
                                <asp:ListItem>IL</asp:ListItem>
                                <asp:ListItem>IN</asp:ListItem>
                                <asp:ListItem>KS</asp:ListItem>
                                <asp:ListItem>KY</asp:ListItem>
                                <asp:ListItem>LA</asp:ListItem>
                                <asp:ListItem>MA</asp:ListItem>
                                <asp:ListItem>MD</asp:ListItem>
                                <asp:ListItem>ME</asp:ListItem>
                                <asp:ListItem>MI</asp:ListItem>
                                <asp:ListItem>MN</asp:ListItem>
                                <asp:ListItem>MO</asp:ListItem>
                                <asp:ListItem>MS</asp:ListItem>
                                <asp:ListItem>MT</asp:ListItem>
                                <asp:ListItem>NC</asp:ListItem>
                                <asp:ListItem>ND</asp:ListItem>
                                <asp:ListItem>NE</asp:ListItem>
                                <asp:ListItem>NH</asp:ListItem>
                                <asp:ListItem>NJ</asp:ListItem>
                                <asp:ListItem>NM</asp:ListItem>
                                <asp:ListItem>NV</asp:ListItem>
                                <asp:ListItem>NY</asp:ListItem>
                                <asp:ListItem>OH</asp:ListItem>
                                <asp:ListItem>OK</asp:ListItem>
                                <asp:ListItem>OR</asp:ListItem>
                                <asp:ListItem>PA</asp:ListItem>
                                <asp:ListItem>RI</asp:ListItem>
                                <asp:ListItem>SC</asp:ListItem>
                                <asp:ListItem>SD</asp:ListItem>
                                <asp:ListItem>TN</asp:ListItem>
                                <asp:ListItem>TX</asp:ListItem>
                                <asp:ListItem>UT</asp:ListItem>
                                <asp:ListItem>VA</asp:ListItem>
                                <asp:ListItem>VT</asp:ListItem>
                                <asp:ListItem>WA</asp:ListItem>
                                <asp:ListItem>WI</asp:ListItem>
                                <asp:ListItem>WV</asp:ListItem>
                                <asp:ListItem>WY</asp:ListItem>
                            </asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="lblzip" runat="server" Style="font-weight: 700" Text="Zip Code:"></asp:Label>&nbsp;<span class="auto-style7"><strong>*</strong></span></td>
                        <td class="auto-style1">
                            <asp:TextBox ID="txtZip" class="txt" runat="server" Height="30px"></asp:TextBox></td>
                    </tr>

                </table>
                <p class="auto-style2">
            
            <asp:CheckBox ID="chkSameBilling" Text="Same as shipping" runat="server" OnCheckedChanged="btnChecked" AutoPostBack="true" />


                </p>
          <p class="auto-style2">
                    <asp:Label ID="lblBilling" runat="server" Text="Please enter the billing information" style="font-size: large"></asp:Label>
                    
                </p>


                <table align="center" style="height: 175px; width: 530px">
                                        
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="lblBillingAdr" runat="server" Style="font-weight: 700" Text="Billing Address"></asp:Label>: <strong><span class="auto-style7">*</span></td>
                        <td>
                            <asp:TextBox ID="txtBillingAdr" class="txt" runat="server" Height="30px" Width="330px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="lblBillingCity" runat="server" Style="font-weight: 700" Text="City: "></asp:Label><span class="auto-style7"><strong>*</strong></span></td>
                        <td>
                            <asp:TextBox ID="txtBillingCity" class="txt" runat="server" Height="30px" Width="331px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;
                            <asp:Label ID="lblBillingState" runat="server" Style="font-weight: 700" Text="State/Province:"></asp:Label>&nbsp;<span class="auto-style2"><strong><span class="auto-style6">*</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong></span></td>
                        <td>
                            <asp:DropDownList ID="ddlState2" class="txt" runat="server" Height="30px">
                                <asp:ListItem>AK</asp:ListItem>
                                <asp:ListItem>AL</asp:ListItem>
                                <asp:ListItem>AR</asp:ListItem>
                                <asp:ListItem>AZ</asp:ListItem>
                                <asp:ListItem>CA</asp:ListItem>
                                <asp:ListItem>CO</asp:ListItem>
                                <asp:ListItem>CT</asp:ListItem>
                                <asp:ListItem>DE</asp:ListItem>
                                <asp:ListItem>FL</asp:ListItem>
                                <asp:ListItem>GA</asp:ListItem>
                                <asp:ListItem>HI</asp:ListItem>
                                <asp:ListItem>IA</asp:ListItem>
                                <asp:ListItem>ID</asp:ListItem>
                                <asp:ListItem>IL</asp:ListItem>
                                <asp:ListItem>IN</asp:ListItem>
                                <asp:ListItem>KS</asp:ListItem>
                                <asp:ListItem>KY</asp:ListItem>
                                <asp:ListItem>LA</asp:ListItem>
                                <asp:ListItem>MA</asp:ListItem>
                                <asp:ListItem>MD</asp:ListItem>
                                <asp:ListItem>ME</asp:ListItem>
                                <asp:ListItem>MI</asp:ListItem>
                                <asp:ListItem>MN</asp:ListItem>
                                <asp:ListItem>MO</asp:ListItem>
                                <asp:ListItem>MS</asp:ListItem>
                                <asp:ListItem>MT</asp:ListItem>
                                <asp:ListItem>NC</asp:ListItem>
                                <asp:ListItem>ND</asp:ListItem>
                                <asp:ListItem>NE</asp:ListItem>
                                <asp:ListItem>NH</asp:ListItem>
                                <asp:ListItem>NJ</asp:ListItem>
                                <asp:ListItem>NM</asp:ListItem>
                                <asp:ListItem>NV</asp:ListItem>
                                <asp:ListItem>NY</asp:ListItem>
                                <asp:ListItem>OH</asp:ListItem>
                                <asp:ListItem>OK</asp:ListItem>
                                <asp:ListItem>OR</asp:ListItem>
                                <asp:ListItem>PA</asp:ListItem>
                                <asp:ListItem>RI</asp:ListItem>
                                <asp:ListItem>SC</asp:ListItem>
                                <asp:ListItem>SD</asp:ListItem>
                                <asp:ListItem>TN</asp:ListItem>
                                <asp:ListItem>TX</asp:ListItem>
                                <asp:ListItem>UT</asp:ListItem>
                                <asp:ListItem>VA</asp:ListItem>
                                <asp:ListItem>VT</asp:ListItem>
                                <asp:ListItem>WA</asp:ListItem>
                                <asp:ListItem>WI</asp:ListItem>
                                <asp:ListItem>WV</asp:ListItem>
                                <asp:ListItem>WY</asp:ListItem>
                            </asp:DropDownList> </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="lblBillingZip" runat="server" Style="font-weight: 700" Text="Zip Code:"></asp:Label>&nbsp;<span class="auto-style7"><strong>*</strong></span></td>
                        <td>
                            <asp:TextBox ID="txtBillingZip" class="txt" runat="server" Height="30px"></asp:TextBox></td>
                    </tr>


                </table>

                <br />
               <p class="auto-style2"><asp:CheckBox ID="chkRemember" runat="server" OnCheckedChanged="chkRemember_CheckedChanged" /> Remember me</p>
           
              <table align="center" style="height: 85px; width: 460px">
            <tr>
                <td>
                    <asp:Button ID="btnRegister" CssClass="yellowbutton"  runat="server" OnClick="btnRegister_Click" Text="Register Customer" Height="35px" Style="font-weight: 700" BackColor="#FFD57B" Width="223px" />
                  </td>
                <td>
                    <asp:Button ID="btnCancel" CssClass="greyButton" runat="server" Text="Cancel" OnClick="btnCancel_Click" Height="35px" Style="font-weight: 700" Width="144px" />
                    </td>
            </tr>     
               </table>

                <table align="center" style="height: 85px; width: 230px">
            <tr>
                <td>
                   <asp:Button ID="Button1" CssClass="yellowbutton" runat="server" OnClick="Button1_Click" Text="Go to homepage" Visible="False" Height="37px" Width="209px" />
                  </td>
                </table>
          </p>
            <p class="auto-style2" style="margin-left: 240px"> <asp:Label ID="lblMsg"  runat="server" Text="***" Style="position: relative; font-size: x-large; color: #CC0000;"></asp:Label>
          </p>
               
            </div>
    </form>
</body>
</html>
