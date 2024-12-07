
function them_hang_sx() {


    
    let button_them = document.getElementById("them");
    let khoi2 = document.getElementById("khoi2");
    let khoi3 = document.getElementById("khoi3");
    let button_huy = document.getElementById("huy");
    let select_ds = document.getElementById("danhsach");
    
    // thêm phần tử vào khối 3
    let new_label = document.createElement("label");
    let new_input = document.createElement("input");

    new_label.innerText = "Hãng";
    new_input.type = "text";


    khoi3.appendChild(new_label);
    khoi3.appendChild(new_input);
    
    let new_button_luu =  document.createElement("button");
    let new_button_huy = document.createElement("button");
    new_button_luu.innerText = "Lưu";
    new_button_huy.innerText = "Hủy";
    khoi2.appendChild(new_button_luu);
    khoi2.appendChild(new_button_huy);
    khoi2.removeChild(button_them);
    khoi2.removeChild(button_huy);
    

   

    
    
    new_button_luu.addEventListener("click" ,function() {
            var mang_hang = document.getElementById("danhsach");
            var mang = [];
            
            // tạo một option để lưu vào select
            if(new_input.value.trim()==="") {
                alert("vui lòng nhập tên hàng");
            }
            else {
                
               // khi hãng trùng tên
               var so_luong = parseInt(mang_hang.length);
                if(so_luong!==0) {
                    
                    for (let index = 0; index < so_luong; index++) {
   
                    const selectedOption = mang_hang.options[index].text+"";
                    const a = selectedOption.toLowerCase().replace(/\s+/g, '');
                    mang.push(a);
                    }
                    for (let index = 0; index < so_luong; index++) {
                        
                        if(mang[index].trim()==new_input.value.trim().toLowerCase().replace(/\s+/g, '')) {
                            alert("Tên hãng này đã tồn tại!!");
                            return;
                        }
                        
                    }
                }
                
                // khi hãng thỏa mãn đủ điều kiện
                 var op = document.createElement("option");
                 op.innerText = new_input.value.trim();
                 select_ds.appendChild(op);
                 new_input.value = "";
            }
           

           

    });
    new_button_huy.addEventListener("click", function() {
            khoi2.appendChild(button_them);
            khoi2.appendChild(button_huy);
            khoi2.removeChild(new_button_luu);
            khoi2.removeChild(new_button_huy);
            khoi3.removeChild(new_label);
            khoi3.removeChild(new_input);
    });
}