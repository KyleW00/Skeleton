<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerPDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCustmerID" runat="server" Text="CustomerID" width="105px"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
            <br />
            <asp:Label ID="lblEmail" runat="server" Text="E-mail" width="105px"></asp:Label>
&nbsp;<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblPassword" runat="server" Text="Password" width="105px"></asp:Label>
&nbsp;<asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblDateOfBirth" runat="server" Text="Date Of Birth" width="105px"></asp:Label>
&nbsp;<asp:TextBox ID="txtDateOfBirth" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblAddress" runat="server" Text="Address" width="105px"></asp:Label>
&nbsp;<asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblContactNumber" runat="server" Text="Concact Number"></asp:Label>
&nbsp;<asp:TextBox ID="txtContactNumber" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="chkActive" runat="server" Text="Active" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;<asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="cancel" />
        </div>
    </form>
</body>
</html>
