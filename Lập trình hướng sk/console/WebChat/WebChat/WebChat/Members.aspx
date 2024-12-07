<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Members.aspx.cs" Inherits="WebChat.Member1" %>

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

        #members_title {
            color: white;
            background-color: forestgreen;
            text-align: center;
            margin: 0;
            padding: 10px 0px;
            position: -webkit-sticky;
            position: sticky;
            top: 0;
        }

        #members {
            margin: 15px 0px;
        }
    </style>
</head>
<body id="container" onload="javascript:page_refresh()">
    <h2 id="members_title" runat="server">Thành viên</h2>
    <div id="members" runat="server"></div>
    <script type="text/javascript">
        setInterval(page_refresh, 5000);
        function page_refresh() {
            var xhttp = new XMLHttpRequest();
            xhttp.onreadystatechange = function () {
                if (this.readyState == 4 && this.status == 200) {
                    document.getElementById("container").innerHTML = this.responseText;
                }
            };
            xhttp.open("GET", "Members.aspx", true);
            xhttp.send();
        }
    </script>
</body>
</html>
