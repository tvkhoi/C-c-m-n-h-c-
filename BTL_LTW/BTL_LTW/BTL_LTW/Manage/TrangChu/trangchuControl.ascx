<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="trangchuControl.ascx.cs" Inherits="BTL_LTW.Manage.TrangChu.trangchuControl" %>
<%@ Register Src="~/Manage/Chitietsanpham/chitietsanphamControl.ascx" TagPrefix="uc1" TagName="chitietsanphamControl" %>


<script type="text/javascript">
    document.addEventListener("DOMContentLoaded", function () {
          //chuyen slide trang chu
        let index = 0;
        const imgNumber = document.querySelectorAll('.slider_content_left_top img')
        const leftBtn = document.querySelector('.fa-chevron-left')
        const rightBtn = document.querySelector('.fa-chevron-right')

        rightBtn.addEventListener('click', function () {
            index++;
            if (index > imgNumber.length - 1) {
                index = 0;
            }
            document.querySelector('.slider_content_left_top').style.right = index * 100 + "%";
        })
        leftBtn.addEventListener('click', function () {
            index--;
            if (index <= 0) {
                index = imgNumber.length - 1;
            }
            document.querySelector('.slider_content_left_top').style.right = index * 100 + "%";
        })
        //-----------------pick slide
        const imgNumberPick = document.querySelectorAll('.slider_content_left_bottom li')
        imgNumberPick.forEach(function (image, index) {
            image.addEventListener('click', function () {
                document.querySelector('.slider_content_left_top').style.right = index * 100 + "%";
            })
        })


        //------------------auto chuyen slide 
        function imgAuto() {
            index++;
            if (index > imgNumber.length - 1) {
                index = 0;
            }
            document.querySelector('.slider_content_left_top').style.right = index * 100 + "%";
        }
        setInterval(imgAuto, 5000)


        //-------------------slider product
        const divNumber = document.querySelectorAll('.slider_product_one_content_items')
        const leftBtnDiv = document.querySelector('.fa-chevron-left-div')
        const rightBtnDiv = document.querySelector('.fa-chevron-right-div')
        rightBtnDiv.addEventListener('click', function () {
            index++;
            if (index > divNumber.length - 1) {
                index = 0;
            }
            document.querySelector('.slider_product_one_content_items_content').style.right = index * 100 + "%";
        })
        leftBtnDiv.addEventListener('click', function () {
            index--;
            if (index < 0) {
                index = divNumber.length - 1;
            }
            document.querySelector('.slider_product_one_content_items_content').style.right = index * 100 + "%";
        })
        // Sản phẩm
        // Lấy ra tất cả các phần tử con của .slider_product_one_content_items
        var productItems = document.querySelectorAll(".slider_product_one_content_items .slider_product_one_content_item");

        // Gắn sự kiện click vào từng phần tử sản phẩm
        productItems.forEach(function (item) {
            item.addEventListener("click", function () {
                var productId = item.getAttribute("data-product-id");
                window.location.href = "https://localhost:44358/adminisTrator.aspx?id=" + "chitietsanpham" + "&sp=" + productId;
                
            });
        });
    });
    
    
</script>
<section class="slider">
    <div class="container">
        <div class="slider_content">
            <div class="slider_content_left">
                <div class="slider_content_left_top_container">
                    <div class="slider_content_left_top">
                        <a href=""><img src='<%= ResolveUrl("/img/slide1.jpg") %>' alt="mô_tả_ảnh"></a>
                        <a href=""><img src='<%= ResolveUrl("/img/slide2.jpg") %>' alt="mô_tả_ảnh"> </a>
                        <a href=""> <img src='<%= ResolveUrl("/img/slide3.jpg") %>' alt="mô_tả_ảnh"></a>
                        <a href=""><img src='<%= ResolveUrl("/img/slide4.jpg") %>' alt="mô_tả_ảnh"> </a>
                    </div>
                    <div class="slider_content_left_top_btn">
                        <i class="fa-solid fa-chevron-left"></i>
                        <i class="fa-solid fa-chevron-right"></i>
                    </div>
                </div>
                <div class="slider_content_left_bottom">
                    <li>Tiểu điểm Acer</li>
                    <li>Intel Core Ultra</li>
                    <li>Acer predator Helios Neo</li>
                    <li>Game without compromise</li>
                </div>
            </div>
        </div>
    </div>
</section>
<section class="banner_one">
    <div class="container">
        <img runat="server" src="~/img/banner2.jpg" alt="banner one">
    </div>
</section>
<div class="slider_product_one">
    <div class="container">
        <div class="slider_product_one_content">
            <div class="slider_product_one_content_title">
                <h2>Săn Sale Online Mỗi Ngày</h2>
            </div>
            <div class="slider_product_one_content_container">
                <div class="slider_product_one_content_items_content">
                <div class="slider_product_one_content_items">
                    <div data-product-id="sp1" class="slider_product_one_content_item">
                        <img runat="server" id="hinhanh1" src=""  alt="">
                        <div class="slider_product_one_content_item_text">
                            <li runat="server" id="ten1"></li>
                            <li runat="server" id="mota1"></li>
                            <li runat="server" id="gia1"></li>
                            <li > <strike runat="server" id="giagoc1"></strike> <span runat="server" id="giamgia1"></span></li>
                        </div>
                    </div>
                    <div data-product-id="sp2" class="slider_product_one_content_item">
                        <img id="hinhanh2" runat="server" alt="">
                        <div class="slider_product_one_content_item_text">
                            <li runat="server" id="ten2"></li>
                            <li runat="server" id="mota2"></li>
                            <li runat="server" id="gia2"> </li>
                            <li> <strike runat="server" id="giagoc2"></strike> <span runat="server" id="giamgia2"></span></li>
                        </div>
                    </div>
                    <div data-product-id="sp3" class="slider_product_one_content_item">
                        <img id="hinhanh3" runat="server" alt="">
                        <div class="slider_product_one_content_item_text">
                            <li runat="server" id="ten3"></li>
                            <li runat="server" id="mota3"></li>
                            <li runat="server" id="gia3"></li>
                            <li> <strike runat="server" id="giagoc3"></strike> <span runat="server" id="giamgia3"></span></li>
                        </div>
                    </div>
                    <div data-product-id="sp4" class="slider_product_one_content_item">
                        <img id="hinhanh4" runat="server" alt="">
                        <div class="slider_product_one_content_item_text">
                            <li runat="server" id="ten4"></li>
                            <li runat="server" id="mota4"></li>
                            <li runat="server" id="gia4"></li>
                            <li > <strike runat="server" id="giagoc4"></strike> <span runat="server" id="giamgia4"></span></li>
                        </div>
                    </div>
                    <div data-product-id="sp5" class="slider_product_one_content_item">
                        <img id="hinhanh5" runat="server" alt="">
                        <div class="slider_product_one_content_item_text">
                            <li runat="server" id="ten5"></li>
                            <li runat="server" id="mota5"></li>
                            <li runat="server" id="gia5"></li>
                            <li> <strike runat="server" id="giagoc5"></strike> <span runat="server" id="giamgia5"></span></li>
                        </div>
                    </div>
                </div>
                <div class="slider_product_one_content_items">
                    <div data-product-id="sp6" class="slider_product_one_content_item">
                        <img id="hinhanh6" runat="server" alt="">
                        <div class="slider_product_one_content_item_text">
                            <li runat="server" id="ten6"></li>
                            <li runat="server" id="mota6"></li>
                            <li runat="server" id="gia6"></li>
                            <li> <strike runat="server" id="giagoc6"></strike> <span runat="server" id="giamgia6"></span></li>
                        </div>
                    </div>
                    <div data-product-id="sp7" class="slider_product_one_content_item">
                        <img id="hinhanh7" runat="server" alt="">
                        <div class="slider_product_one_content_item_text">
                            <li runat="server" id="ten7"></li>
                            <li runat="server" id="mota7"></li>
                            <li runat="server" id="gia7"></li>
                            <li> <strike runat="server" id="giagoc7"></strike> <span runat="server" id="giamgia7"></span></li>
                        </div>
                    </div>
                    <div data-product-id="sp8" class="slider_product_one_content_item">
                        <img id="hinhanh8" runat="server" alt="">
                        <div class="slider_product_one_content_item_text">
                            <li runat="server" id="ten8"></li>
                            <li runat="server" id="mota8"></li>
                            <li runat="server" id="gia8"></li>
                            <li> <strike runat="server" id="giagoc8"></strike> <span runat="server" id="giamgia8"></span></li>
                        </div>
                    </div>
                    <div data-product-id="sp9" class="slider_product_one_content_item">
                        <img id="hinhanh9" runat="server" alt="">
                        <div class="slider_product_one_content_item_text">
                            <li runat="server" id="ten9"></li>
                            <li runat="server" id="mota9"></li>
                            <li runat="server" id="gia9"></li>
                            <li > <strike runat="server" id="giagoc9"></strike> <span runat="server" id="giamgia9"></span></li>
                        </div>
                    </div>
                    <div data-product-id="sp10" class="slider_product_one_content_item">
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
                <div class="slider_product_one_content_btn">
                    <i class="fa-solid fa-chevron-left fa-chevron-left-div"></i>
                    <i class="fa-solid fa-chevron-right fa-chevron-right-div"></i>
                </div>
            </div>
        </div>
    </div>
</div>