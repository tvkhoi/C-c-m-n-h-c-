<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebForm_UserControl.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <a href="?id=trangchu">Trang chủ</a>
                <a href="?id=laptop">Laptop</a>
            </div>
            <asp:PlaceHolder ID="PlaceHolder" runat="server"></asp:PlaceHolder>
        </div>
    </form>
</body>
</html>
