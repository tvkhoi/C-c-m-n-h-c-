// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
let stt = 3;

document.addEventListener("DOMContentLoaded", function () {
    let button_them = document.getElementById("them");
    button_them.addEventListener("click", them);
    dulieu();
});

function them() {
    let bang = document.getElementById("bang");
    let ten = document.getElementById("ten").value;
    let hang = document.getElementById("hang").value;
    let chuoingaythangnam = document.getElementById("chuoingaythangnam").value;
    let gia = document.getElementById("gia").value;
    var ngayGioHienTai = new Date();
    var ngaythangnam;

    // năm tháng ngày
    ngaythangnam = chuoingaythangnam.split("/");
    var ngayht = parseInt(ngayGioHienTai.getDate());
    var thanght = parseInt(ngayGioHienTai.getMonth()) + 1;
    var namht = parseInt(ngayGioHienTai.getFullYear());

    if (ten === "" && hang === "" && chuoingaythangnam === "" && gia === "") {
        alert("Vui lòng nhập đủ thông tin");
    } else {
        if (parseInt(ngaythangnam[2]) < namht ||
            (parseInt(ngaythangnam[2]) === namht && thanght > parseInt(ngaythangnam[1])) ||
            (parseInt(ngaythangnam[2]) === namht && thanght === parseInt(ngaythangnam[1]) && parseInt(ngaythangnam[0]) < ngayht)) {
            alert("Vui lòng kiểm tra lại thời gian!");
            return;
        }

        var mangdulieu = [];
        mangdulieu = mangdulieu.concat(stt, ten, hang, chuoingaythangnam, gia);
        let dong = document.createElement("tr");

        // Tạo và điền dữ liệu cho các ô td mới
        for (let i = 0; i < 5; i++) {
            let cot = document.createElement("td");
            cot.innerText = mangdulieu[i];
            dong.appendChild(cot);
        }

        // Tăng giá trị của stt sau khi sử dụng
        stt++;

        // Thêm dòng mới vào bảng
        bang.appendChild(dong);
    }
}

function dulieu() {
    var mang = [];
    mang.push([1, "Core i3 7100", "Intel", "20/11/2011", "3.450.000"]);
    mang.push([2, "Core i5 4430", "Intel", "20/08/2012", "4.530.000"]);
    let bang = document.getElementById("bang");
    mang.forEach(function (element) {
        let dong = document.createElement("tr");

        // Tạo và điền dữ liệu cho các ô td mới
        for (let i = 0; i < 5; i++) {
            let cot = document.createElement("td");
            cot.innerText = element[i];
            dong.appendChild(cot);
        }

        // Thêm dòng mới vào bảng
        bang.appendChild(dong);
    });
}
