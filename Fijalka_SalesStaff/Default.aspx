<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="Fijalka_SalesStaff._Default" Explicit="true" Strict="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SalesStaff by Daniel Fijalka</title>
    <style type="text/css">
        .auto-style1 {
            width: 64%;
            height: 279px;
        }
        .auto-style4 {
            width: 818px;
        }
        .auto-style5 {
            text-align: center;
        }
        .auto-style9 {
            width: 457px;
            text-align: center;
            height: 19px;
        }
        .auto-style10 {
            color: #FFFFFF;
            font-family: "Segoe UI Variable Display";
            font-size: medium;
            font-weight: bold;
            margin-left: 0px;
            background-color: #CC6600;
        }
        .auto-style11 {
            width: 457px;
        }
        .auto-style12 {
            width: 932px;
        }
        .auto-style13 {
            color: #CC9900;
            font-family: "Segoe UI Variable Display";
            letter-spacing: 1pt;
        }
        .auto-style14 {
            width: 818px;
            text-align: right;
            color: #CC9900;
            height: 14px;
            font-family: "Segoe UI Variable Display";
        }
        .auto-style15 {
            width: 457px;
            height: 14px;
            text-align: center;
        }
        .auto-style16 {
            width: 932px;
            height: 14px;
        }
        .auto-style17 {
            width: 818px;
            text-align: right;
            color: #CC9900;
            height: 96px;
            font-family: "Segoe UI Variable Display";
        }
        .auto-style18 {
            width: 457px;
            height: 96px;
            text-align: center;
        }
        .auto-style19 {
            width: 932px;
            height: 96px;
        }
        .auto-style20 {
            width: 818px;
            height: 19px;
        }
        .auto-style21 {
            width: 932px;
            height: 19px;
        }
        .auto-style22 {
            width: 457px;
            text-align: left;
        }
        .auto-style23 {
            margin-left: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style5">
            <h2>&nbsp;</h2>
            <h2 class="auto-style13">Login Page</h2>
        </div>
        <br />
        <table align="center" class="auto-style1">
            <tr>
                <td class="auto-style14">&nbsp;&nbsp; Email Address:&nbsp; </td>
                <td class="auto-style15">
                    <asp:TextBox ID="txtEmail" runat="server" Height="21px" Width="353px" ToolTip="Enter email address here."></asp:TextBox>
                </td>
                <td class="auto-style16">
                    <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="An Email Address Must Be Entered" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="Enter a Valid Email Address" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style17">&nbsp;Zip Code:&nbsp;</td>
                <td class="auto-style18">
                    <asp:TextBox ID="txtZipCode" runat="server" Height="20px" Width="358px" ToolTip="Enter zip code here."></asp:TextBox>
                </td>
                <td class="auto-style19">
                    <asp:RequiredFieldValidator ID="rfvZipCode" runat="server" ControlToValidate="txtZipCode" Display="Dynamic" ErrorMessage="A Zip Code Must be Entered" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="revZipCode" runat="server" ControlToValidate="txtZipCode" Display="Dynamic" ErrorMessage="The Zip Code must be between 11111 and 99999" ForeColor="Red" MaximumValue="99999" MinimumValue="10000" SetFocusOnError="True" Type="Integer">*</asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style20"></td>
                <td class="auto-style9">
                    <asp:Button ID="btnLogin" runat="server" CssClass="auto-style10" Height="44px" Text="Login" Width="162px" ToolTip="Click to login." ViewStateMode="Enabled" />
                </td>
                <td class="auto-style21"></td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style12">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style22">
                    <asp:ValidationSummary ID="valSummaryLoginPage" runat="server" ForeColor="Red" CssClass="auto-style23" />
                </td>
                <td class="auto-style12">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style12">&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
