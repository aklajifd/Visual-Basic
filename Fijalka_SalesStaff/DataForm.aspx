<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="DataForm.aspx.vb" Inherits="Fijalka_SalesStaff.DataForm" Strict="true" Explicit="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SalesStaff by Daniel Fijalka</title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            font-family: "Segoe UI Variable Display";
            text-align: center;
        }
        .auto-style4 {
            font-family: "Segoe UI Variable Display";
            font-size: medium;
        }
        .auto-style5 {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
        <div>
            <h2 class="auto-style2">SalesStaff by Daniel Fijalka</h2>
            </div>
            <div class="auto-style1">
                <div class="auto-style5">
        <asp:DetailsView ID="detailsView" runat="server" AllowPaging="True" AutoGenerateRows="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="ID" DataSourceID="SqlDataSource1" Height="123px" Width="879px" HorizontalAlign="Center" ToolTip="Click on page below to switch records.">
            <EditRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <Fields>
                <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID">
                <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="Last_Name" HeaderText="Last Name" SortExpression="Last_Name">
                <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="First_Name" HeaderText="First Name" SortExpression="First_Name">
                <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:CheckBoxField DataField="Full_Time" HeaderText="Full Time" SortExpression="Full_Time">
                <ItemStyle HorizontalAlign="Center" />
                </asp:CheckBoxField>
                <asp:BoundField DataField="Hire_Date" DataFormatString="{0:d}" HeaderText="Hire Date" SortExpression="Hire_Date">
                <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="Salary" DataFormatString="{0:c}" HeaderText="Salary" SortExpression="Salary">
                <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:CommandField ShowEditButton="True" />
            </Fields>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        </asp:DetailsView>
                </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CompanyConnectionString2 %>" DeleteCommand="DELETE FROM [SalesStaff] WHERE [ID] = @ID" InsertCommand="INSERT INTO [SalesStaff] ([ID], [Last_Name], [First_Name], [Full_Time], [Hire_Date], [Salary]) VALUES (@ID, @Last_Name, @First_Name, @Full_Time, @Hire_Date, @Salary)" SelectCommand="SELECT * FROM [SalesStaff]" UpdateCommand="UPDATE [SalesStaff] SET [Last_Name] = @Last_Name, [First_Name] = @First_Name, [Full_Time] = @Full_Time, [Hire_Date] = @Hire_Date, [Salary] = @Salary WHERE [ID] = @ID">
            <DeleteParameters>
                <asp:Parameter Name="ID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="ID" Type="Int32" />
                <asp:Parameter Name="Last_Name" Type="String" />
                <asp:Parameter Name="First_Name" Type="String" />
                <asp:Parameter Name="Full_Time" Type="Boolean" />
                <asp:Parameter Name="Hire_Date" Type="DateTime" />
                <asp:Parameter Name="Salary" Type="Decimal" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Last_Name" Type="String" />
                <asp:Parameter Name="First_Name" Type="String" />
                <asp:Parameter Name="Full_Time" Type="Boolean" />
                <asp:Parameter Name="Hire_Date" Type="DateTime" />
                <asp:Parameter Name="Salary" Type="Decimal" />
                <asp:Parameter Name="ID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
                <br />
                <asp:Button ID="btnLogout" runat="server" CssClass="auto-style4" Height="57px" Text="Logout" ToolTip="Click to return to login page." Width="174px" />
            </div>
        </div>
    </form>
</body>
</html>
