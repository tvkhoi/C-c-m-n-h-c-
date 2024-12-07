<%@ Control Language="C#"  AutoEventWireup="true" CodeBehind="giohangControl.ascx.cs" Inherits="BTL_LTW.Manage.GioHang.giohangControl" %>
<link type="text/css" rel="stylesheet" href="../../CSS/giohang.css" runat="server" />
<script>
    
    document.addEventListener('DOMContentLoaded', function () {
        var dathang = document.getElementById("dathang");
        var hvaten = document.getElementById("hovaten");
        var sdt = document.getElementById("sdt");
        var baoloi = document.getElementById("baoloi");
        var radio_nam = document.getElementById("radio_nam");
        var radio_nu = document.getElementById("radio_nu");
        var loi = "";

        dathang.addEventListener('click', function () {
            loi = ""; // Đảm bảo rằng biến loi được xóa trước mỗi lần kiểm tra mới
            // Sử dụng value thay vì values để lấy giá trị của input
            if (sdt.value.trim() == "") {
                
                loi += "Số điện thoại không được để trống. ";
            }
            if (hvaten.value.trim() == "") {
                loi += "Họ và tên không được để trống. ";
            }
            if (radio_nam.checked == false && radio_nu.checked == false) {
                loi += "Giới tính";
            }
            if (loi.trim() == "") {
                alert("Bạn đã đặt hàng thành công");
            } else {
                alert("Đã xảy ra lỗi khi đặt hàng: " + loi);
            }
        });
 

    });
</script>


<div runat="server" id="check_giohang" class="cartempty">
        <li><i class="cartnew-empty"></i></li>
        <li><span>Không có sản phẩm nào trong giỏ hàng</span></li>
        <li><a href="../../adminisTrator.aspx"><button>VỀ TRANG CHỦ</button></a></li>
        <li><span>Khi cần trợ giúp vui lòng gọi <strong>1900 232 460</strong> hoặc <strong>028.3622.1060</strong> (7h30 - 22h)</span></li>

</div>

<div class="cart_product">	
	<asp:ListView ID="ListViewCart" runat="server">
		<ItemTemplate>
            <div class="list_sp">
                <ul runat="server" id="list_sp_content" style="list-style:none;">
                    <li>
                            <div class='giohangsp'>
                                <ul>
                                    <li>
                                        <img style="width: 14%; height: 14%; padding: 30px 0 0px 30px; display: inline-block;" id="hinhanh" src='<%# ResolveUrl(Eval("hinhanh").ToString()) %>' />
                                        <span style="padding: 10px; display: inline-block; width: 70%;"><%# Eval("mota") %></span>
                                        <ul style="display: inline-block; list-style: none; padding-left: 20px;">
                                            <li style="color: red;"><%# Eval("gia") %></li>
                                            <li><s><%# Eval("giagoc") %></s></li>
                                        </ul>
                                    </li>
                                    <li>
                                        <a style="color: black;" href="xuLy_Xoa.aspx?sp=<%#Eval("masp")%>" ><button style="width: 20px; border-radius: 50%; height: 20px; margin-left: 8%; margin-bottom: 20px; border: 1px solid black;" >x</button>Xóa</a>
                                    </li>
                                </ul>
                            </div>
                    </li>

                </ul>
            </div>
		</ItemTemplate>
	</asp:ListView>
</div>
<div runat="server" id="thongtinkhachhang" class="thongtinkh" style="line-height:2;display:none;">
    <h1 style="font-size: 20px;">Thông tin khách hàng</h1>
    <p style="display:inline-block;">
        <input type="radio" id="radio_nam" name="gender" value="male"/> Nam  
        <input type="radio" id="radio_nu" name="gender" value="female"/> Nữ
    </p>
    <p style="display:ruby-text;"><input id="hovaten" type="text" placeholder="Họ và tên" style="border-radius:4px;text-align: -webkit-center;width: 40%;height: 50px;font-size: 16px;"/>&nbsp;&nbsp;
        <input id="sdt"  style="border-radius:4px;text-align: -webkit-center;width: 40%;height: 50px;font-size: 16px;" type="number" placeholder="Số điện thoại"/></p>
    <div style="text-align:center;">
        <span id="baoloi" style="color:red";></span>
        <button id="dathang" style="color:white;width: 80%;height: 50px;margin: 30px 0 50px 0;">ĐẶT HÀNG</button>
    </div>
</div>


