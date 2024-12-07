<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MessageList.aspx.cs" Inherits="WebChat.MessageList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        * {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        }

        #container {
            margin: 0;
            padding: 0;
            color: black;
            background-color: white;
        }

        #messages_title {
            color: white;
            background-color: dodgerblue;
            text-align: center;
            margin: 0;
            padding: 10px 0px;
            position: -webkit-sticky;
            position: sticky;
            top: 0;
        }

        #messages {
            margin: 15px 0px;
        }
    </style>
</head>
<body id="container">
    <form id="form1" runat="server">
        <h2 id="messages_title" runat="server">Lịch sử tin nhắn</h2>
        <div id="messages" runat="server"></div>
    </form>
    <script type="text/javascript">
        setInterval(page_refresh, 500);
        function page_refresh() {
            var xhttp = new XMLHttpRequest();
            xhttp.onreadystatechange = function () {
                if (this.readyState == 4 && this.status == 200) {
                    document.getElementById("container").innerHTML = this.responseText;
                }
            };
            xhttp.open("GET", "MessageList.aspx", true);
            xhttp.send();
        }
    </script>
</body>
</html>
