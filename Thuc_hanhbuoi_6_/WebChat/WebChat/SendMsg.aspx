<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SendMsg.aspx.cs" Inherits="WebChat.SendMsg" ValidateRequest="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Web Chat GI App</title>
    <style>
        #form_auth {
            width: fit-content;
            margin: 0 auto;
            padding: 20px 30px;
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            border: 2px solid black;
            border-radius: 5px;
            display: none;
        }

        .wrapper {
            display: grid;
            grid-template-areas:
                "a1 a1"
                "a2 a3"
                "a4 a5"
                "a6 a6"
                "a7 a7";
            grid-template-rows: 5vh 3vh 3vh;
            grid-template-columns: 5.7vw 15vw;
            grid-gap: 20px;
        }

        .title_auth {
            grid-area: a1;
            color: black;
            font-size: 20px;
            font-weight: bold;
            text-align: center;
        }

        #auth_nickname {
            grid-area: a3;
            margin: 0 auto;
            padding: 5px;
            border: 1px solid black;
        }

        #auth_color {
            grid-area: a5;
            margin: 0 auto;
            padding: 5px;
            border: 1px solid black;
        }

        .button_auth {
            grid-area: a7;
            text-align: center;
        }

        #auth_submit, #auth_reset {
            padding: 10px;
            margin: 0 auto;
            font-weight: bold;
            color: white;
            background-color: black;
            box-sizing: border-box;
            border: 2px solid black;
            border-radius: 5px;
        }

        #auth_submit:hover, #auth_reset:hover {
            color: black;
            background-color: white;
            border: 2px solid black;
        }

        .auth_label1 {
            grid-area: a2;
            text-align: left;
        }

        .auth_label2 {
            grid-area: a4;
            text-align: left;
        }

        #divError {
            grid-area: a6;
            color: red;
        }
    </style>
</head>
<body id="container">
    <br /><br /><br />
    <form id="form_auth" method="post" action="SendMsg.aspx" runat="server">
        <div class="wrapper">
            <div class="title_auth">Thành viên mới</div>
            <label class="auth_label1" for="auth_nickname">Nickname </label>
            <input type="text" autocomplete="off" id="auth_nickname" name="auth_nickname" runat="server" autofocus="autofocus" />
            <label class="auth_label2" for="auth_color">Màu (color) </label>
            <input type="text" autocomplete="off" id="auth_color" name="auth_color" runat="server" />
            <div id="divError" runat="server"></div>
            <div class="button_auth">
                <input type="reset" id="auth_reset" name="auth_reset" value="XÓA" onclick="xoas()" runat="server" />
                <input type="submit" id="auth_submit" name="auth_submit" value="THAM GIA" runat="server" />
            </div>
        </div>
    </form>
    <script>
        function xoas() {
            document.querySelector("#divError").innerHTML = ``;
        }
    </script>
</body>
</html>
