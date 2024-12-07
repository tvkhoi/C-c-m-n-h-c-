<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="menuControl.ascx.cs" Inherits="BTL_LTW.Manage.menu.menuControl" %>

     <script type="text/javascript" src="../../JS/navJs.js">
        
     </script>
<nav>
            <div class="container">
                <ul>
                    <li>  <a href="../../adminisTrator.aspx"> <img src="../../img/longvuong.png" alt="" style="width: 170px;"> </a> </li>
                    <li>  
                        <div>
                            <p>Xem giá, khuyến mãi tại</p>
                            <p  id="address_form"> Hà Nội<i class="fa-solid fa-sort-down"></i> </p>
                        </di>
                    </li>
                    <li>  <input type="text" placeholder="Bạn tìm gì..."> <i class="fa-solid fa-magnifying-glass"></i> </li>
                    <li>  <a href="?id=giohang">   <button>  <i class="fa-solid fa-cart-plus"></i> Giỏ hàng </button></a></li>
                    <li>  <a href=""> Tài khoản & đơn hàng </a></li>
                    <li>   <a href="">  
                        <span class="span_content"> 
                            <span class="span_top"> </span>
                        </span>  Hỗ trợ trả góp </a>
                    </li>
                    <li>  <a href=""> 24H Công nghệ</a></li>
                    <li>  <a href=""> Hỏi đáp</a></li>
                    <li>  <a href=""> Game App</a></li>
                            <div class="address_form" style="display: none;">
                                    <div class="address_form_content">
                                        <h2>Chọn địa chỉ nhận hàng
                                            <span id="address_close"> X Đóng </span>
                                        </h2>
                                        <div class="form_diachi">
                                            <p>Quý khách vui lòng cho biết <b>Địa Chỉ Nhận Hàng </b>để biết chính xác thời gian giao hàng</p>
                                            <select name="" >
                                                <option value="#">----Chọn Tỉnh\Thành phố-----</option>
                                                <option value="#">Hà Nội</option>
                                            </select>
                                            <select name="">
                                                <option value="#">----Chọn Quận\Huyện----</option>
                                                <option value="#">Hà Nội</option>
                                            </select>
                                            <select name="" >
                                                <option value="#">----Chọn Phường\Xã-----</option>
                                                <option value="#">Hà Nội</option>
                                            </select>
                                            <input type="text" placeholder="Số nhà, tên đường" >
                                            <button id="address_confirm">Xác nhận</button>
                                        </div>
                                    </div>
                      </div>
                </ul>
            </div>
</nav>

<section class="menu_bar">
            <div class="container">
                <div class="menu_bar_container">
                    <ul>
                        <li> <a href="?id=laptopvanphong" > <i class="fa-solid fa-laptop"></i> Laptop văn phòng </a> </li>
                        <li> <a href="?id=laptopgaming"> <i class="fa-solid fa-gamepad"></i> Laptop gaming</a> </li>
                        <li> <a href="?id=phukien"> <i class="fa-solid fa-headphones"></i> Phụ kiện <i class="fa-solid fa-sort-down"></i> </a>
                             <div class="submenu">
                                 <ul>
                                     <li>Phụ kiện 1</li>
                                     <li>Phụ kiện 2</li>
                                     <li>Phụ kiện 3</li>
                                     <li>Phụ kiện 4</li>
                                     <li>Phụ kiện 5</li>
                                     <li>Phụ kiện 6</li>
                                 </ul>
                             </div>
                        </li>
                        
                        <li> <a href="?id=laptopgear"> <i class="fa-solid fa-desktop"></i> Gaming gear</a> </li>
                        <li> <a href="?id=phanmem"> <i class="fa-brands fa-windows"></i> Phần mềm </a></li>
                    </ul>
                </div>
            </div>
</section>
