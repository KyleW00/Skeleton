<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockMDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 13px;
            left: 16px;
            z-index: 1;
            right: 1154px;
        }
        .auto-style2 {
            position: absolute;
            top: 12px;
            z-index: 1;
            left: 159px;
            width: 129px;
        }
        .auto-style3 {
            position: absolute;
            top: 41px;
            left: 16px;
            z-index: 1;
            height: 18px;
            width: 119px;
        }
        .auto-style4 {
            position: absolute;
            top: 39px;
            z-index: 1;
            left: 159px;
        }
        .auto-style5 {
            position: absolute;
            top: 65px;
            left: 16px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 64px;
            left: 159px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 95px;
            left: 16px;
            z-index: 1;
        }
        .auto-style8 {
            position: absolute;
            top: 94px;
            left: 159px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 125px;
            left: 16px;
            z-index: 1;
        }
        .auto-style10 {
            position: absolute;
            top: 124px;
            left: 159px;
            z-index: 1;
        }
        .auto-style11 {
            position: absolute;
            top: 156px;
            left: 16px;
            z-index: 1;
        }
        .auto-style12 {
            position: absolute;
            top: 185px;
            left: 16px;
            z-index: 1;
        }
        .auto-style13 {
            position: absolute;
            top: 212px;
            left: 16px;
            z-index: 1;
        }
        .auto-style14 {
            position: absolute;
            top: 212px;
            left: 103px;
            z-index: 1;
            width: 67px;
            height: 27px;
        }
    </style>
    </head>
<body style="height: 25px">
    <form id="form1" runat="server">
        <asp:Label ID="lblStockId" runat="server" CssClass="auto-style1" Text="Stock Id" width="119px"></asp:Label>
        <asp:TextBox ID="txtStockId" runat="server" CssClass="auto-style2" height="22px" width="128px"></asp:TextBox>
        <asp:Label ID="lblStockName" runat="server" CssClass="auto-style3" Text="Stock Name" width="119px"></asp:Label>
        <asp:TextBox ID="txtStockName" runat="server" CssClass="auto-style4" height="22px" width="128px"></asp:TextBox>
        <asp:Label ID="lblStockQuantity" runat="server" CssClass="auto-style5" Text="Stock Quantity" width="119px"></asp:Label>
        <asp:TextBox ID="txtStockQuantity" runat="server" CssClass="auto-style6" height="22px" width="128px"></asp:TextBox>
        <asp:Label ID="lblStockCost" runat="server" CssClass="auto-style7" Text="Stock Cost" width="119px"></asp:Label>
        <asp:TextBox ID="txtStockCost" runat="server" CssClass="auto-style8" height="22px" width="128px"></asp:TextBox>
        <asp:Label ID="lblDateAdded" runat="server" CssClass="auto-style9" Text="Date Added" width="119px"></asp:Label>
        <asp:TextBox ID="txtDateAdded" runat="server" CssClass="auto-style10" height="22px" width="128px"></asp:TextBox>
        <asp:CheckBox ID="chkInStock" runat="server" CssClass="auto-style11" Text="InStock" width="119px" />
        <asp:Label ID="lblError" runat="server" CssClass="auto-style12" width="119px"></asp:Label>
        <asp:Button ID="btnOK" runat="server" CssClass="auto-style13" height="26px" Text="OK" width="67px" OnClick="btnOK_Click" />
        <asp:Button ID="btnCancel" runat="server" CssClass="auto-style14" height="26px" Text="Cancel" />
        <p>
        </p>
    </form>
    </body>
</html>
