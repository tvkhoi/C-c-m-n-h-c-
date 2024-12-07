<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="chitietsanphamControl.ascx.cs" Inherits="BTL_LTW.Manage.Chitietsanpham.chitietsanphamControl" %>



<style>
    .detail {
       max-width:1300px;
       margin:auto;
    }
    .detail_content_link ul li{  
        display:inline-block;
    }
    .detail_content_link ul li a {
        color:cornflowerblue;
    }
    .thongtinsanpham {
        padding: 5px 0 10px 0;
    }
    .thongtinsanpham ul {
        list-style:none;
        
    }
    .thongtinsanpham ul li {
        padding-top:5px;
    }
    .thongtinsanpham ul li strong {
        font-size:20px;
    }
    .box_main {
        padding-block: 30px;
        border-top : 1px solid black;
        display:flex;
    }
    .box_main_left {
        float:inline-start;
        width:60%;
    }
    .box_main_left img {
        width:220px;
        height:220px;
        display:inline-block;
    }
    .box_main_right {
        padding-left:50px;
        display:inline-block;
    }
    .box_main_right ul li {
        display:inline-block;
    }
    .loyalty {
        line-height:2;
    }
    .loyalty .loyalty__main {
        display:inline-block;
    }
    .loyalty__main img {
       vertical-align: middle;
    }
    .loyalty__main p {
      display: inline-block;
      vertical-align: middle;
      padding-left: 5px;
    }
     [class^="icondetail-"],[class*="icondetail-"] {
                background-image: url("data:image/png;base64,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");
                background-repeat: no-repeat;
                display: inline-block;
                height: 30px;
                width: 30px;
                line-height: 30px;
                vertical-align: middle;
                background-size: 300px 180px;
            }

    .icondetail-noibat {
        background-position: 0 0;
        height: 28px;
        width: 28px;
    }

    .icondetail-video {
        background-position: -35px 0;
        height: 30px;
        width: 30px;
    }

    .icondetail-360do {
        background-position: -70px 0;
        height: 30px;
        width: 30px;
    }

    .icondetail-thongso {
        background-position: -105px 0;
        height: 30px;
        width: 30px;
    }

    .icondetail-danhgia {
        background-position: -140px 0;
        height: 19px;
        width: 23px;
    }

    .icondetail-playvideo {
        background-position: -190px -115px;
        height: 25px;
        width: 25px;
    }
    .icondetail-baohanh {
        background-position: -105px -35px;
        height: 32px;
        width: 32px;
    }
    .icondetail-sachhd {
        background-position: -70px -35px;
        height: 32px;
        width: 32px;
    }
    icondetail-baohanh {
        background-position: -105px -35px;
        height: 32px;
        width: 32px;
    }
    .policy_intuitive {
        margin:5px 0 0 0;
        border:1px solid #000000;
        border-radius:1px;
    }
    .policy_intuitive .policy {
        padding:15px;
    }
    .policy_intuitive .policy ul li {
        list-style:none;
        display:flex;
    }
    .box_main_right .muahang {
        text-align:center;
    }
    /*Thông tin sản phẩm*/
    .article {
    position: relative;
    margin-bottom: 20px;
    }
    .content-t-wrap {
        max-width: 700px;
        margin: auto;
        padding: 20px 0;
    }
    .article__content {
        overflow: hidden;
        transition: .3s;
    }
    .article__content h3 {
        font-size: 20px;
        font-weight: bold;
        line-height: 28px;
        margin: 20px 0 15px 0;
    }
    .article__content p, .article__content div {
        line-height: 1.5;
        margin-bottom: 10px;
        font-size: 16px !important;
    }
</style>

<script>
    function themsp() {
        //  Lấy giá trị mã sp trên url
        var urlParams = new URLSearchParams(window.location.search);
        var param1 = urlParams.get('sp'); // Giá trị của 'param1'

        window.location.href = "https://localhost:44358/adminisTrator.aspx?id=giohang" + "&sp=" + param1;
    }

    document.addEventListener("DOMContentLoaded", function () {

        
    });
   
</script>



<section class="detail">
    <div class="detail_content">
        <div class="detail_content_link">
            <ul>
                <li><a href="">Laptop</a></li>
                <li style="padding-left:5px;">></li>
                <li style="padding-left:5px;"><a href="">Máy tính</a></li>
            </ul>
        </div>
        <div class="thongtinsanpham">
            <ul >
                <li><strong runat="server" id="ten">Tên</strong></li>
                <li><strong runat="server" id="mota">Mô tả</strong></li>
            </ul>
        </div>
        <div class="box_main">
            <div class="box_main_left">
                <img id="hinhanh" runat="server" src=""/>
               <div class="policy_intuitive">
                    <div class="policy">
                        <ul class="policy__list">
                                <li>
                                    <div class="iconl">
                                        <i class="icondetail-doimoi"></i>
                                    </div>
                                    <p> Hư gì đổi nấy <b>12 tháng</b>  tại 3158 siêu thị toàn quốc (miễn phí tháng đầu)</p>
                                </li>
                                <li>
                                    <div class="iconl">
                                        <i class="icondetail-baohanh"></i>
                                    </div>
                                    <p>
                                        Bảo hành <b>chính hãng laptop 2 năm</b> tại các trung tâm bảo hành hãng 
                                    </p>
                                </li>

                                    <li><div class="iconl"><i class="icondetail-sachhd"></i></div><p>Bộ sản phẩm gồm: Sách hướng dẫn, Thùng máy, Sạc Laptop Asus ( 150W )</p></li>

                                <li data-field="hardcode">
                                    <div class="iconl"><i class="icondetail-baohanh"></i></div>
                                    <p style="padding-top:5px;">Bảo hành pin 1 năm</p>
                                </li> 
                        </ul>
                    </div>
             </div>
           </div>
            <div class="box_main_right">
                <span>Giá:</span>
                <ul>
                    <li ><strong runat="server" id="gia" style="color:red;font-size:20px;">Giá</strong></li>
                    <li><s runat="server" id="giagoc" style="font-size:16px;">Giá gốc</s></li>
                    <li runat="server" id="giamgia" style="color:red;font-size:16px;">Giảm giá</li>
                </ul>
                 <div class="loyalty">
                     <div class="loyalty__main">
                         <img data-src="//cdn.tgdd.vn/mwgcart/mwgcore/ContentMwg/images/promote_loyalty/logo.png" class=" lazyloaded" width="24" height="24" src="//cdn.tgdd.vn/mwgcart/mwgcore/ContentMwg/images/promote_loyalty/logo.png">
                         <p class="loyalty__main__point"><b>+32.980</b> điểm tích lũy Quà Tặng VIP</p>
                         <img data-src="//cdn.tgdd.vn/mwgcart/mwgcore/ContentMwg/images/promote_loyalty/question_mark.png" class="loyalty__main__ic-tooltip lazyloaded" width="20" height="20" src="//cdn.tgdd.vn/mwgcart/mwgcore/ContentMwg/images/promote_loyalty/question_mark.png">
                     </div>
                     <ul class="loyalty__tooltip">
                         <li>Đây là điểm tích lũy tạm tính khi mua sản phẩm này. Số điểm thực tế có thể thay đổi và sẽ được hiển thị chính xác sau khi Quý khách hoàn tất đặt hàng.</li>
                         <li>Tải <b>app Quà Tặng VIP</b> để tích và sử dụng điểm cho khách hàng thân thiết. <a href="https://www.thegioididong.com/tin-tuc/tat-tan-tat-ve-chuong-trinh-uu-dai-app-qua-tang-vip-link-tai-va-cach-su-dung-1481677#gioithieu" target="_blank">Tìm hiểu thêm</a></li>
                     </ul>
                </div>
                <div class="muahang">
                    <button runat="server" id="themvaogiohang" onclick="themsp()"  style="width: 60%; border-color: #fb6e2e;color: white; background-color: #fb6e2e;height: 50px;text-align: center;border-radius: 3px;font-size: 20px;">MUA HÀNG</button>
                </div>
            </div>
            </div>
           <div runat="server"  class="article__content short">

                <h3 class="article__content__title">Thông tin sản phẩm</h3>
            
                <div runat="server" id="thongtinsanpham" class="content-article">
                   <!--Nơi để hiển thị thông  tin chi tiết của sản phẩm-->
                </div>
            
               
           </div>
    </div>
</section>
<section>
    <!--Thông báo chọn màu và số lượng sản phẩm-->

</section>