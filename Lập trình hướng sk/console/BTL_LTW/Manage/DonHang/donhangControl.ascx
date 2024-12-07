<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="donhangControl.ascx.cs" Inherits="BTL_LTW.Manage.DonHang.donhangControl" %>


<style>
    .notfound_list {
    position: relative;
    overflow: hidden;
    text-align: center;
    padding: 40px 0;
    background-color: #edf0f5;
    margin-top: 12px
   
}

.notfound_list>.empty-icon {
    margin-bottom: 10px
}

.notfound_list>p {
    font-size: 18px;
    font-weight: 600;
    margin: 10px 0
}

.notfound_list>span {
    color: #9da7bc
}

.notfound_list a {
    color: #288ad6
}

.notfound_list>.group-button_direct {
    max-width: 350px;
    margin: 15px auto 25px;
    display: flex;
    flex-wrap: wrap;
    justify-content: center;
    align-content: space-between;
    font-size: 12px
}

.notfound_list>.group-button_direct a {
    border: 1px solid #288ad6;
    padding: 9px 10px;
    display: block;
    margin: 3px 5px;
    border-radius: 4px;
    font-weight: 400;
    color: #023f88
}

.notfound_list .break {
    flex-basis: 100%;
    height: 0
}

.notfound_list>.button_direct-home {
    color: #023f88
}

.notfound_list>.button_direct-home::before {
    content: "";
    border: 1px solid #023f88;
    border-width: 0 2px 2px 0;
    display: inline-block;
    padding: 3px;
    margin-right: 10px;
    transform: rotate(135deg);
    -webkit-transform: rotate(135deg)
}
</style>


<div runat="server" id="donhang" style="width:70%;margin:auto;padding-bottom: 10px;display:block;">
    <div class="notfound_list">
        <i class="iconoh-empty-list-order empty-icon"></i>
        <p>Rất tiếc, bạn chưa có đơn hàng</p>
        <span>Vẫn còn rất nhiều sản phẩm đang chờ bạn</span>
        <div class="group-button_direct">
             <p><a href="?id=laptopvanphong" previewlistener="true">Laptop văn phòng</a></p>
             <p><a href="?id=phukien" previewlistener="true">Phụ kiện</a></p>
             <p><a href="?id=phanmem" previewlistener="true">Phụ kiện</a></p>
        </div>
        <a class="button_direct-home" href="../../adminisTrator.aspx" previewlistener="true">Về trang chủ</a>
    </div>
</div>


<div id="chitiet_donhang" runat="server" style="width: 60%;margin: auto;padding-top: 40px;padding-bottom: 40px;">
    <div>
        <ul style="list-style:none;">
            <li>
                <p style="font-size: 40px;">Đơn đặt hàng của khách hàng</p>
            </li>
            <li style="font-size: 22px;padding: 5px;">
                Tên: <span runat="server" id="tenkh"></span>
            </li>
            <li style="font-size: 22px;padding: 5px;">Số điện thoại: <span runat="server" id="sdtkh"></span></li>
            <li style="font-size: 22px;padding: 5px;">Địa chỉ: <span runat="server" id="diachikh"></span></li>
            <li style="font-size: 22px;padding: 5px;">Ngày sinh: <span runat="server" id="namsinh"></span></li>
        </ul>
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
                                    </ul>
                                </div>
                        </li>

                    </ul>
                </div>
		    </ItemTemplate>
        </asp:ListView>
    </div>
    <p  style="font-weight: bold;font-size: 20px;">Tổng tiền: <span style="" runat="server" id="tongtien"></span></p>
</div>



