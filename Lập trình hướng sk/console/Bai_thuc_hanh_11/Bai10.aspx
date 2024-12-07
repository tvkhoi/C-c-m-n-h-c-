<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bai10.aspx.cs" Inherits="Bai_thuc_hanh_11.Bai10" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
       <style type="text/css">
        #txtNoiDung {
            width: 387px;
            height: 123px;
        }
        #content {
            width: 469px;
            height: 125px;
        }
    </style>
    <script type="text/javascript">
        document.addEventListener("DOMContentLoaded", function () {
          //  var noidung = document.getElementById("txtKetqua");
         //   document.getElementById("txtFile").addEventListener("change", function () {

          //      var tenfile = this.files[0]; 
         //       if (tenfile) {
         //           var reader = new FileReader();

         //           reader.onload = function (e) {
          //              var fileContent = e.target.result; 

          //              noidung.value = fileContent; 
          //          };

                 //   reader.readAsText(tenfile); 
         //       }
         //   });
        });
        
    </script>
</head>
<body>
       <form id="form1" runat="server">
        <div>
            Nhập nội dung:</div>
        <p>
            <textarea runat="server" id="txtNoiDung" name="S1"></textarea></p>
        <p>
            Upload tại đây:</p>
        <p>
            
            <input id="txtFile" type="file" runat="server" />
        </p>
           
           <input id="Submit1" runat="server" type="submit" value="submit" onserverclick="submit_ServerClick"/>
           <p id="txtKetqua" runat="server"></p>
    </form>
</body>
</html>
