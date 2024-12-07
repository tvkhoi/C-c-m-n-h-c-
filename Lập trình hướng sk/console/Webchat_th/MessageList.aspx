<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MessageList.aspx.cs" Inherits="Webchat_th.MessageList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Repeater ID="rptMessages" runat="server">
                <ItemTemplate>
                    <div>
                        <asp:Label runat="server" Text='<%# Eval("NickName") + ": " + Eval("Content") %>'></asp:Label>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
