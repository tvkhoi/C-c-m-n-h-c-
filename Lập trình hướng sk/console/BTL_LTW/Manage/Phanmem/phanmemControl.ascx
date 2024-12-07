<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="phanmemControl.ascx.cs" Inherits="BTL_LTW.Manage.Phanmem.phanmemControl" %>
<style>
    .logoBrand{
        margin-top:50px;
        margin-left:100px;
        margin-right:600px
    }
    .logoBrand ul{
        display: flex;
        justify-content: space-between,
    }
    .logoBrand ul li {
         list-style: none;
    }
    .logoBrand > ul > li {
        display:flex;
        width:90px;
        height:42px;
        padding: 7px 0;
        margin: auto;
        border:2px solid #bab9b4;
        border-radius : 10px;
        align-items:center;
        justify-content: center

    }
    .logoBrand ul li img {
        max-width:50px;
        max-height:25px;
        height: auto;
 
    }

     #containerMoTa{
         display:flex;
         margin-top:20px;
         margin-left:155px;
         margin-bottom:30px;
         width:1200px;
         background-color:rgb(243, 239, 239);
         align-items:center;
     }
     #sanPham{
         margin-left:80px;
         padding:20px;
     }
     .items{
         margin-bottom:10px;
         display:flex;
     }
     .items > div{
         margin:3px;
         border:1px solid #bab9b4;
       
     }
     #bannerVP{
           width: 100%;
            margin: 20px 0;
            display: flex;
            justify-content: center;
     }
     #containerMoTa img{
         max-width:800px
     }

</style>


<script type="text/javascript">
    document.addEventListener('DOMContentLoaded', function () {
        // Lấy ra tất cả các phần tử con của .slider_product_one_content_items
        var productItems = document.querySelectorAll(".items .slider_product_one_content_item");

        // Gắn sự kiện click vào từng phần tử sản phẩm
        productItems.forEach(function (item) {
            item.addEventListener("click", function () {
                var productId = item.getAttribute("data-product-id");
                // Đổi location của trang đến URL mong muốn với id của sản phẩm
                window.location.href = "https://localhost:44358/adminisTrator.aspx?id=chitietsanpham&sp=" + productId;
            });
        });
    });
</script>

<div id="containerMoTa">
     <p style="margin:16px"> Windows bản quyền là phiên bản Windows được kích hoạt chính hãng bởi Microsoft với đầy đủ tính năng, hệ thống bảo mật giúp bạn sử dụng tốt nhất. 
        LongVuong cam kết hàng chính hãng 100%, chính sách thanh toán linh hoạt luôn đi cùng các chính
        sách ưu đãi hấp dẫn. Cập nhật ngay những  <b>Phần Mềm</b> tốt nhất hiện đang có mặt tại LongVuong ngay sau đây nhé!</p>
    <img src="../../img/imgBannerPM.png" alt="" />
</div>

<div id="sanPham">
        <div class="items">
        <div data-product-id="pm1" class="slider_product_one_content_item">
            <img runat="server" id="hinhanh1" src=""  alt="">
            <div class="slider_product_one_content_item_text">
                <li runat="server" id="ten1"></li>
                <li runat="server" id="mota1"></li>
                <li runat="server" id="gia1"></li>
                <li > <strike runat="server" id="giagoc1"></strike> <span runat="server" id="giamgia1"></span></li>
            </div>
        </div>
        <div data-product-id="pm2" class="slider_product_one_content_item">
            <img id="hinhanh2" runat="server" alt="">
            <div class="slider_product_one_content_item_text">
                <li runat="server" id="ten2"></li>
                <li runat="server" id="mota2"></li>
                <li runat="server" id="gia2"> </li>
                <li> <strike runat="server" id="giagoc2"></strike> <span runat="server" id="giamgia2"></span></li>
            </div>
        </div>
        <div data-product-id="pm3" class="slider_product_one_content_item">
            <img id="hinhanh3" runat="server" alt="">
            <div class="slider_product_one_content_item_text">
                <li runat="server" id="ten3"></li>
                <li runat="server" id="mota3"></li>
                <li runat="server" id="gia3"></li>
                <li> <strike runat="server" id="giagoc3"></strike> <span runat="server" id="giamgia3"></span></li>
            </div>
        </div>
        <div data-product-id="pm4" class="slider_product_one_content_item">
            <img id="hinhanh4" runat="server" alt="">
            <div class="slider_product_one_content_item_text">
                <li runat="server" id="ten4"></li>
                <li runat="server" id="mota4"></li>
                <li runat="server" id="gia4"></li>
                <li > <strike runat="server" id="giagoc4"></strike> <span runat="server" id="giamgia4"></span></li>
            </div>
        </div>
        <div data-product-id="pm5" class="slider_product_one_content_item">
            <img id="hinhanh5" runat="server" alt="">
            <div class="slider_product_one_content_item_text">
                <li runat="server" id="ten5"></li>
                <li runat="server" id="mota5"></li>
                <li runat="server" id="gia5"></li>
                <li> <strike runat="server" id="giagoc5"></strike> <span runat="server" id="giamgia5"></span></li>
            </div>
        </div>
    </div>
    <div class="items">
        <div data-product-id="pm6" class="slider_product_one_content_item">
            <img id="hinhanh6" runat="server" alt="">
            <div class="slider_product_one_content_item_text">
                <li runat="server" id="ten6"></li>
                <li runat="server" id="mota6"></li>
                <li runat="server" id="gia6"></li>
                <li> <strike runat="server" id="giagoc6"></strike> <span runat="server" id="giamgia6"></span></li>
            </div>
        </div>
        <div data-product-id="pm7" class="slider_product_one_content_item">
            <img id="hinhanh7" runat="server" alt="">
            <div class="slider_product_one_content_item_text">
                <li runat="server" id="ten7"></li>
                <li runat="server" id="mota7"></li>
                <li runat="server" id="gia7"></li>
                <li> <strike runat="server" id="giagoc7"></strike> <span runat="server" id="giamgia7"></span></li>
            </div>
        </div>
        <div data-product-id="pm8" class="slider_product_one_content_item">
            <img id="hinhanh8" runat="server" alt="">
            <div class="slider_product_one_content_item_text">
                <li runat="server" id="ten8"></li>
                <li runat="server" id="mota8"></li>
                <li runat="server" id="gia8"></li>
                <li> <strike runat="server" id="giagoc8"></strike> <span runat="server" id="giamgia8"></span></li>
            </div>
        </div>
        <div data-product-id="pm9" class="slider_product_one_content_item">
            <img id="hinhanh9" runat="server" alt="">
            <div class="slider_product_one_content_item_text">
                <li runat="server" id="ten9"></li>
                <li runat="server" id="mota9"></li>
                <li runat="server" id="gia9"></li>
                <li > <strike runat="server" id="giagoc9"></strike> <span runat="server" id="giamgia9"></span></li>
            </div>
        </div>
        <div data-product-id="pm10" class="slider_product_one_content_item">
            <img id="hinhanh10" runat="server" alt="">
            <div class="slider_product_one_content_item_text">
                <li runat="server" runat="server" id="ten10"></li>
                <li runat="server" id="mota10"></li>
                <li runat="server" id="gia10"></li>
                <li> <strike runat="server" id="giagoc10"></strike> <span runat="server" id="giamgia10"></span></li>
            </div>
        </div>
    </div>
</div>



