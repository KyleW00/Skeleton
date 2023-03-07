<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffMDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStaff_Id" runat="server" Text="Staff Id" width="76px"></asp:Label>
        <asp:TextBox ID="txtStaff_Id" runat="server" OnTextChanged="txtStaff_Id_TextChanged"></asp:TextBox>
        <p>
            <asp:Label ID="lblStaff_Name" runat="server" Text="Staff Name" width="76px"></asp:Label>
            <asp:TextBox ID="txtStaff_Name" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblStaff_Role" runat="server" Text="Staff Role" width="76px"></asp:Label>
        <asp:TextBox ID="txtStaff_Role" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblStaff_Started" runat="server" Text="Staff Started"></asp:Label>
            <asp:TextBox ID="txtStaff_Started" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblStaff_Salary" runat="server" Text="Staff Salary" width="76px"></asp:Label>
            <asp:TextBox ID="txtStaff_Salary" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="chkStaff_Online" runat="server" Text="Staff Online" />
        </p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
