<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostMsg.aspx.cs" Inherits="Webchat_th.PostMsg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtMessage" runat="server"></asp:TextBox>
            <asp:Button ID="btnSend" runat="server" Text="Send" OnClick="btnSend_Click" />
        </div>
    </form>
</body>
</html>
