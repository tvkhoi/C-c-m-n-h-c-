<?php
header('Content-Type: application/json');

// Kiểm tra xem yêu cầu có phải là POST không
if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    // Lấy dữ liệu truy vấn từ ứng dụng Android
    $query = isset($_POST['query']) ? $_POST['query'] : '';

    // Kiểm tra xem query có tồn tại không
    if (!empty($query)) {
        // Thực hiện kết nối đến cơ sở dữ liệu
        $servername = "mysql.cnqqiwqustkx.us-east-1.rds.amazonaws.com";
        $username = "admin";
        $password = "khoi3112004";
        $dbname = "quanli_app_ban_hang";
        $conn = new mysqli($servername, $username, $password, $dbname);

        // Kiểm tra kết nối
        if ($conn->connect_error) {
            die("Kết nối đến cơ sở dữ liệu thất bại: " . $conn->connect_error);
        }

        // Thiết lập bộ ký tự cho kết nối
        $conn->set_charset("utf8");

        // Thực thi truy vấn từ client
        $result = $conn->query($query);

        if ($result) {
            if ($result->num_rows > 0) {
                $data = array();
                while ($row = $result->fetch_assoc()) {
                    $data[] = $row; // Thêm hàng dữ liệu vào mảng $data
                }
                echo json_encode($data); // Chuyển đổi mảng $data thành JSON và xuất ra
            } else {
                echo json_encode(array('message' => 'Không có dữ liệu')); // Xuất thông báo nếu không có dữ liệu
            }
        } else {
            echo json_encode(array('error' => 'Lỗi truy vấn: ' . $conn->error)); // Xuất thông báo lỗi nếu có lỗi trong truy vấn
        }

        $conn->close(); // Đóng kết nối đến cơ sở dữ liệu
    } else {
        echo json_encode(array('error' => 'Query rỗng')); // Trả về thông báo nếu query từ Android là rỗng
    }
} else {
    // Trường hợp không phải là phương thức POST
    echo json_encode(array('error' => 'Yêu cầu không hợp lệ'));
}
?>

var express = require('express');
var app = express();
var server =require('http').createServer(app);
var io = require('socket.io').listen(server);
var fs =require('fs');
server.listen(process.env.PORT || 3000);
console.log("Server running");
// Nếu kết nối thành công
io.sockets.on('connection',function(socket){
    console.log("Co nguoi ket noi"+socket.id);
    // Lang nghe su kien client gui tin nhan
    socket.on('client-send-data',function(data){
        console.log("Co nguoi gui tin nhan"+data);
        
        // Gui lai tin nhan cho tat ca moi nguoi
        io.sockets.emit('server-send-data',data+"888");
    });
});

connect_mysql.query('SELECT * FROM MucSanPham,function(err,result,fields){
    if(err) throw err;
    result.forEach(result => {
        console.log(row);
    });
});