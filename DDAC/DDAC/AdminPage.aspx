<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="DDAC.AdminPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 84px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Panel ID="Panel1" runat="server" BackImageUrl="~/LOGO MAERSK.PNG" CssClass="auto-style1" Height="89px" Width="589px">
                <br />
            </asp:Panel>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Create Admin" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Assign Shipment" OnClick="Button2_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" Text="View Shipment" OnClick="Button3_Click" />
&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" Text="Logout" OnClick="Button4_Click" />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
