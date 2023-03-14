<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockMDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 213px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="StockId" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Stock ID"></asp:Label>
            <br />
        </div>
        <p>
            <asp:Label ID="ProductName" runat="server" style="z-index: 1; left: 10px; top: 53px; position: absolute" Text="Product Name"></asp:Label>
            <asp:TextBox ID="TxtProductName" runat="server" style="z-index: 1; left: 103px; top: 51px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="TxtStockId" runat="server" style="z-index: 1; left: 72px; top: 14px; position: absolute"></asp:TextBox>
            <asp:Label ID="ProductCost" runat="server" style="z-index: 1; left: 10px; top: 91px; position: absolute" Text="Product Cost"></asp:Label>
            <asp:TextBox ID="TxtProductCost" runat="server" style="z-index: 1; left: 95px; top: 91px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="StockQuantity" runat="server" style="z-index: 1; left: 10px; top: 129px; position: absolute" Text="Quantity"></asp:Label>
        <asp:TextBox ID="TxtQuantity" runat="server" style="z-index: 1; left: 62px; top: 128px; position: absolute"></asp:TextBox>
        <asp:Label ID="InStock" runat="server" style="z-index: 1; left: 12px; top: 163px; position: absolute" Text="In Stock"></asp:Label>
        <asp:TextBox ID="TxtInStock" runat="server" style="z-index: 1; left: 71px; top: 163px; position: absolute"></asp:TextBox>
        <asp:Label ID="DateAdded" runat="server" style="z-index: 1; left: 17px; top: 196px; position: absolute" Text="Date Added"></asp:Label>
        <asp:TextBox ID="TxtDateAdded" runat="server" style="z-index: 1; left: 95px; position: absolute; top: 194px"></asp:TextBox>
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
