document.addEventListener("DOMContentLoaded",function(){{
    var themf = document.getElementById("them");
    themf.addEventListener("click",xuli_catchuoi);
    var chonf = document.getElementById("danhsach");
    chonf.addEventListener("click",chon);
    var huyf = document.getElementById("huy");
    huyf.addEventListener("click",huy);
    
}});
function xuli_catchuoi() {
    var chuoi = document.getElementById("chuoi").value;
    
    if(chuoi==="") {
        alert("Vui lòng nhập nội dung");
        let a = document.getElementById("chuoi");
        a.focus();
    
    }
    
    else {
        
        let mang = chuoi.split(",");
        // kiểm tra xem chuỗi có phần tử nào trùng không
        for (let index = 0; index < mang.length; index++) {
            for (let i= index+1; i < mang.length; i++) {
                if(mang[index]==mang[i]) {
                    mang.splice(index,1);
                }
                
            }            
        }
        // kiểm tra phần tử rỗng
        let new_mang = mang.filter(function(element) {
            return element.trim() !== '';
        });
        

        let mySelect =  document.getElementById("danhsach");
        let danhsach_mang = [];
        
        // kiểm tra phần tử trùng với phần tử trong danh sách
        for (let index = 0; index < mySelect.options.length; index++) {
            danhsach_mang.push(mySelect.options[index].value);
        }
        // phần tử nào trùng thì xóa 
        for (let i = 0; i < new_mang.length; i++) {
            for (let index = 0; index < danhsach_mang.length; index++) {
                if(new_mang[i]==danhsach_mang[index]) {
                    new_mang.splice(i,1);
                    i--;
                }
                
            }
        }
        mang = new_mang;
        // Xóa tất cả các option cũ trong select trước khi thêm mới
        // mySelect.innerHTML = "";

        mang.forEach(function(item) {
        let option = document.createElement("option");
        option.text = item;
        mySelect.add(option);
        });
    }
    

    
}
function huy() {
    document.getElementById("chuoi").value = "";
}

function chon() {
    var selectElement = document.getElementById("danhsach");

    if (!selectElement.hasListener) {
        selectElement.hasListener = true;

        selectElement.addEventListener("change", function() {
            const selectedOption = selectElement.options[selectElement.selectedIndex].text;
            alert("Bạn đã chọn: " + selectedOption);
        });
    }
}
function kiemtra_trung() {
    
}
