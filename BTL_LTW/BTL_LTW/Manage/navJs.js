document.addEventListener("DOMContentLoaded", function () {
    //dong form dia chi
    var addressClose = document.getElementById("address_close");
    addressClose.addEventListener('click', function () {
        document.querySelector('.address_form').style.display = 'none';
    })
    //hien thi form dia chi
    const addressBtn = document.querySelector('#address_form')
    addressBtn.addEventListener('click', function () {
        
        document.querySelector('.address_form').style.display = 'flex';
    })
    // xác nhận gửi
    var address_confirm = document.getElementById("address_confirm");
    address_confirm.addEventListener('click', function () {
        document.querySelector('.address_form').style.display = 'none';
        
    })
    
});