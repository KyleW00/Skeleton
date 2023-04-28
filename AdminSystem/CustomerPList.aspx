<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerPList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 246px; width: 640px">
            <asp:ListBox ID="lstCustomerList" runat="server" Height="133px" Width="291px"></asp:ListBox>
        </div>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Enter Address"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" />
&nbsp;<asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
