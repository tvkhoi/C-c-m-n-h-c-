
document.addEventListener('DOMContentLoaded',()=>{
    const warningMessageUsername = document.getElementById('warningMessageUsername');
    const warningMessagePassword = document.getElementById('warningMessagePassword');
    const warningMessageUsernameLength = document.getElementById('warningMessageUsernameLength');
    const warningMessagePasswordLength = document.getElementById('warningMessagePasswordLength');
    const logSuccess = document.getElementById('logSuccess');
    const txtUsername = document.getElementById('txtUsername');
    const txtPassword = document.getElementById('txtPassword');
    const btnPerform = document.getElementById('btnPerform');
    var index = 0 ; //sl nhap

    btnPerform.addEventListener('click', ()=>{
        const user = txtUsername.value.trim();
        const pass = txtPassword.value.trim();
        
        //doi chieu user pass
        var tk = 'adminhou';
        var mk = 'hou123456';
        if(user===tk && pass === mk){
            logSuccess.style.display='block';
            location.assign("default.html");
            return;

        } else{
            index++;
                if(index==3) {
                    alert("Tài khoản của bạn đã bị khóa do đăng nhập quá số lần quy định!");
                    btnPerform.disabled = true;
                    return;
                 }
                 //username
                if (user===''){
                    warningMessageUsername.style.display='block';
                    txtUsername.focus();
                    return;
                }
                warningMessageUsername.style.display='none';
                if (user.length<=6){
                    warningMessageUsernameLength.style.display='block'
                    return;
                }
                warningMessageUsernameLength.style.display ='none';

                //password
                if (pass===''){
                    warningMessagePassword.style.display='block';
                    txtPassword.focus();
                    return;
                }
                warningMessagePassword.style.display='none';
                if(pass.length<=8){
                    warningMessagePasswordLength.style.display='block';
                    return;
                }
                warningMessagePasswordLength.style.display='none';
        }
        logSuccess.style.display='none';
        
    });
    
})