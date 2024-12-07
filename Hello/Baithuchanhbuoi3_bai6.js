
function xulithang(thang, ngay) {
    var ketqua = document.getElementById("ketqua");
    
    switch (thang) {
        case 1:
            if (ngay >= 20) {
                ketqua.innerText = "Bảo Bình";
            } else {
                ketqua.innerText = "Ma Kết";
            }
            break;
        case 2:
            if (ngay >= 19) {
                ketqua.innerText = "Song Ngư";
            } else {
                ketqua.innerText = "Bảo Bình";
            }
            break;
        case 3:
            if (ngay >= 21) {
                ketqua.innerText = "Bạch Dương";
            }
            else {
                ketqua.innerText = "Song Ngư";
            }
            break;
        case 4:
            if (ngay >= 21) {
                ketqua.innerText = "Kim Ngưu";
            } else {
                ketqua.innerText = "Bạch Dương";
            }
            break;
        case 5:
            if (ngay >= 21) {
                ketqua.innerText = "Song Tử";
            } else {
                ketqua.innerText = "Kim Ngưu";
            }
            break;
        case 6:
            if (ngay >= 22) {
                ketqua.innerText = "Cự Giải";
            } else {
                ketqua.innerText = "Song Tử";
            }
            break;
        case 7:
            if (ngay >= 23) {
                ketqua.innerText = "Sư Tử";
            } else {
                ketqua.innerText = "Cự Giải";
            }
            break;
        case 8:
            if (ngay >= 23) {
                ketqua.innerText = "Xử Nữ";
            } else {
                ketqua.innerText = "Sư Tử";
            }
            break;
        case 9:
            if (ngay >= 23) {
                ketqua.innerText = "Thiên Bình";
            } else {
                ketqua.innerText = "Xử Nữ";
            }
            break;
        case 10:
            if (ngay >= 24) {
                ketqua.innerText = "Bọ Cạp";
            } else {
                ketqua.innerText = "Thiên Bình";
            }
            break;
        case 11:
            if (ngay >= 23) {
                ketqua.innerText = "Nhân Mã";
            }
            else {
                ketqua.innerText = "Bọ Cạp";
            }
            break;
        case 12:
            if (ngay >= 22) {
                ketqua.innerText = "Ma Kết";
            } else {
                ketqua.innerText = "Nhân Mã";
            }
            break;
        default:
            alert("Vui lòng nhập ngày sinh!");
            var ns = document.getElementById("ngaysinh");
            ns.focus();
            break;
    }
    return;
}

function xuli() {
    var ngaysinh = document.getElementById("ngaysinh").value;
    var mang = ngaysinh.split("-");
    var thang = parseInt(mang[1]);
    var ngay = parseInt(mang[2]);

    xulithang(thang, ngay); 
}
function huy() {
    var ngaysinh = document.getElementById("ngaysinh").value = "";
    var ketqua = document.getElementById("ketqua").innerText = "";
}