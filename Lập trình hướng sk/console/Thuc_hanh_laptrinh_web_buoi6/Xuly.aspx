<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Xuly.aspx.cs" Inherits="Thuc_hanh_laptrinh_web_buoi6.Xuly" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
 
</head>
<body>
       <form id="form1" runat="server">
        <div class="table-title">
        <h3>Danh sách</h3>
        </div>
        <table border="1" style="border-collapse:collapse">
            <thead>
                <tr>
                    <th class="text-left">Họ tên</th>
                    <th class="text-left text-left-namsinh">Năm sinh</th>
                </tr>
            </thead>
            <tbody class="table-hover" id="viewDanhSach" runat="server">
            </tbody>
        </table>
       
    </form>
</body>
</html>
