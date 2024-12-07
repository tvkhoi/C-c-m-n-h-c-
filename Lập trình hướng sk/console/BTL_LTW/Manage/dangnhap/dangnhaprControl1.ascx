<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="dangnhaprControl1.ascx.cs" Inherits="BTL_LTW.Manage.dangnhap.dangnhaprControl1" %>


<form method="post" id="ctl01">
<div class="aspNetHidden">
<input type="hidden" name="__VIEWSTATE" id="__VIEWSTATE" value="wH04uXpZpUdWldc5MBKsufE5IDFB3wl8JZ4rQDUVjQFQnDiZvEN/U608nMAPP8FAccq248OuepjjZg9vJi3vf/sXU0x4vKkX3aVUprG8lZM=">
</div>

<div class="aspNetHidden">

	<input type="hidden" name="__VIEWSTATEGENERATOR" id="__VIEWSTATEGENERATOR" value="02DB6A77">
</div>
                <div class="auth__header">
                    <h2>Đăng nhập</h2>
                    <a href="Dangky.aspx">Đăng ký</a>
                </div>
                <div class="auth__form">
                    <div class="form-control">
                        <label for="username">Tên đăng nhập</label>
                        <input type="text" id="usernameL" placeholder="Nhập tên đăng nhập" name="usernameL">
                    </div>
                    <div class="form-control">
                        <label for="password">Mật khẩu</label>
                        <input type="password" id="passwordL" placeholder="Nhập mật khẩu" name="passwordL">
                    </div>
                    <p id="errorL" style=" color:red"></p>
                    <button id="btnLogin" class="auth_btn">Đăng nhập</button>
                </div>
                </form>