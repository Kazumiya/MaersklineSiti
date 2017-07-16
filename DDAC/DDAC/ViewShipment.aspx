<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewShipment.aspx.cs" Inherits="DDAC.View_Shipment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 109px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Panel ID="Panel1" runat="server" BackImageUrl="~/LOGO MAERSK.PNG" CssClass="auto-style1" Height="91px" Width="587px">
            </asp:Panel>
            <br />
            <br />
            Assigned Shipment<br />
            <br />
            <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1" HorizontalAlign="Justify" RepeatDirection="Horizontal">
                <ItemTemplate>
                    ID:
                    <asp:Label ID="IDLabel" runat="server" Text='<%# Eval("ID") %>' />
                    <br />
                    Depart:
                    <asp:Label ID="DepartLabel" runat="server" Text='<%# Eval("Depart") %>' />
                    <br />
                    Destination:
                    <asp:Label ID="DestinationLabel" runat="server" Text='<%# Eval("Destination") %>' />
                    <br />
                    ContainerNumber:
                    <asp:Label ID="ContainerNumberLabel" runat="server" Text='<%# Eval("ContainerNumber") %>' />
                    <br />
                    
                </ItemTemplate>
            </asp:DataList>
            &nbsp;
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DDACConnectionString %>" SelectCommand="SELECT * FROM [AssignShipment]"></asp:SqlDataSource>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Back" OnClick="Button1_Click" />
        &nbsp;</div>
    </form>
</body>
</html>
