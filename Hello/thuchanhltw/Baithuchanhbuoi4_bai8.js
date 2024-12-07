let stt = 3;

document.addEventListener("DOMContentLoaded", function() {
   
   

    let button_them = document.getElementById("them");
    button_them.addEventListener("click", them);
    var mang = [];
    mang.push([1,"Core i3 7100","Intel","20/11/2011","3.450.000"]);
    mang.push([2,"Core i5 4430","Intel","20/08/2012","4.530.000"]);
    dulieu(mang);
});

function them() {
    
    let so_loi= 0;
    let bang = document.getElementById("bang");
    let ten = document.getElementById("ten").value;
    let hang = document.getElementById("hang").value;
    let chuoingaythangnam = document.getElementById("chuoingaythangnam").value;
    let gia = document.getElementById("gia").value;
    var ngayGioHienTai = new Date();
    var ngaythangnam;

    // năm tháng ngày
    ngaythangnam = chuoingaythangnam.split("-");
    var ngayht = parseInt(ngayGioHienTai.getDate());
    var thanght = parseInt(ngayGioHienTai.getMonth()) + 1;
    var namht = parseInt(ngayGioHienTai.getFullYear());
    
    let khoi1_loi1 = document.getElementById("khoi1_loi1");
    let khoi1_loi2 = document.getElementById("khoi1_loi2");
    let khoi2_loi1 = document.getElementById("khoi2_loi1");
    let khoi2_loi2 = document.getElementById("khoi2_loi2");
    let khoi3_loi1 = document.getElementById("khoi3_loi1");
    let khoi3_loi2 = document.getElementById("khoi3_loi2");
    let khoi4_loi1 = document.getElementById("khoi4_loi1");
    let khoi4_loi2 = document.getElementById("khoi4_loi2");
   

    
            // kiểm tra rỗng
        if(ten.trim() == "") {
            khoi1_loi1.style.display = "block";
            so_loi++;
        }
        else {
            khoi1_loi1.style.display = "none";
            
        }
        if(hang.trim() == "") {
            khoi2_loi1.style.display = "block";
            so_loi++;
        }
        else {
            khoi2_loi1.style.display = "none";
           
        }
        if(chuoingaythangnam.trim() == "") {
            khoi3_loi1.style.display = "block";
            so_loi++;
        }
        else {
            khoi3_loi1.style.display = "none";
            
        }
        if( gia.trim() == "") {
            khoi4_loi1.style.display = "block";
            so_loi++;
        }
        else {
            khoi4_loi1.style.display = "none";
            
        }
    // nếu 4 vị trí nhập không rỗng
    if (ten.trim().length > 0 && hang.trim().length > 0 && chuoingaythangnam.trim().length > 0 && gia.trim().length > 0) {
        
        if (parseInt(ngaythangnam[0]) > namht || 
            (parseInt(ngaythangnam[0]) === namht && thanght < parseInt(ngaythangnam[1])) ||
            (parseInt(ngaythangnam[0]) === namht && thanght === parseInt(ngaythangnam[1]) && parseInt(ngaythangnam[2]) > ngayht)) {
             khoi3_loi2.style.display ="none";
        }
        else {
             khoi3_loi2.style.display = "block";
            so_loi++;
            
            
        }

        var mangdulieu = [];
        mangdulieu.push([stt, ten, hang, chuoingaythangnam, gia]);
        let dong = document.createElement("tr");

        var mangdulieu_check = [];
        var mangdulieu_check_1 = [];
        var mangdulieu_check_2 = [];
        // Lấy tất cả các dòng trong bảng
        let rows = bang.getElementsByTagName("tr");
        // kiểm tra vxl
        for (let index = 0; index < rows.length; index++) {
            let cot = rows[index].getElementsByTagName("td");
            if (cot.length > 1) {
                let cellContent = cot[1].innerText.trim(); // Truy cập vào cột thứ hai
                let a = cellContent.toLowerCase().replace(/\s+/g, '');
                mangdulieu_check.push(a);
                mangdulieu_check_1.push(a);
            }
         }
        //  for (let index = 0; index < mangdulieu_check.length; index++) {
            
        //     if(mangdulieu_check[index]==ten.trim().toLowerCase().replace(/\s+/g, '')) {
        //         khoi1_loi2.style.display = "block"
        //         so_loi++;
        //     }
        //     else {
        //         khoi1_loi2.style.display = "none";
               
        //     }
        //  }
         // kiểm tra tên hàng
         for (let index = 0; index < rows.length; index++) {
            let cot = rows[index].getElementsByTagName("td");
            if (cot.length > 1) {
                let cellContent = cot[2].innerText.trim(); // Truy cập vào cột thứ hai
                let a = cellContent.toLowerCase().replace(/\s+/g, '');
                mangdulieu_check.push(a);
                mangdulieu_check_2.push(a);
            }
         }
         
         for (let index = 0; index < rows.length; index++) {
            
            if(mangdulieu_check_2[index]==hang.trim().toLowerCase().replace(/\s+/g, '') && mangdulieu_check_1[index]==ten.trim().toLowerCase().replace(/\s+/g, '')) {
                khoi1_loi2.style.display = "block";
                khoi2_loi2.style.display = "block";
                so_loi++;
                break;
               
             }
                    khoi2_loi2.style.display = "none";
                    khoi1_loi2.style.display = "none";
                    
            
         }
        //  for (let index = 0; index < mangdulieu_check.length; index++) {
            
        //     if(mangdulieu_check[index]==hang.trim().toLowerCase().replace(/\s+/g, '')) {
        //         khoi2_loi2.style.display = "block";
        //         so_loi++;
                
        //     }
        //     else {
        //         khoi2_loi2.style.display = "none";
        //     }
        //  }
        if(parseInt(gia)<0) {
            khoi4_loi2.style.display = "block";
            so_loi++;
        }
        else {
            khoi4_loi2.style.display = "none";
        }
         if(parseInt(so_loi) == 0) {
            // thêm dữ liệu vào bảng
            dulieu(mangdulieu);

            // Tăng giá trị của stt sau khi sử dụng
            stt++;
         }
        
    }
}

function dulieu(mang) {
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