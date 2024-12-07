<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FileName.aspx.cs" Inherits="WebApplication1.FileName" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="StyleSheet1.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Tên"></asp:Label>
        </div>
        <p>
            <asp:TextBox ID="TextBox_ten" runat="server" OnTextChanged="TextBox_ten_TextChanged"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Kết quả :"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button" runat="server" Text="Button" OnClick="Button1_Click" />
            </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
