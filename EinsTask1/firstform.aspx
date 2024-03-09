<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="firstform.aspx.cs" Inherits="EinsTask1.firstform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lbl1" runat="server" Text="Enter no's"></asp:Label>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" style="margin-left:50px;"></asp:TextBox>

            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" Text="Select Type"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" style="margin-left:50px;" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList><br /><br />

            <asp:Button ID="Button1" runat="server" Text="submit" OnClick="Button1_Click" />
            <asp:TextBox ID="txtresult" runat="server" ReadOnly="True"></asp:TextBox>
        </p>
    </form>
</body>
</html>
