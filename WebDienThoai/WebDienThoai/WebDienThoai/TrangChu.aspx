<%@ Page Title="" Language="C#" MasterPageFile="~/_layout.Master" AutoEventWireup="true" CodeBehind="TrangChu.aspx.cs" Inherits="WebGiaoHang.TrangChu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="assets/css/TrangChu.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="main">
    <div class="main__img">
        <img src="assets/img/benner.png" alt="" class="main__img--item">
    </div>
    <div class="main__group">
        <div class="main__group1--title">
            <h3 class="main__group1--title-text">SẢN PHẨM NỔI BẬT</h3>
            <div class="main__group1--title-boder">
                <div class="group1__border"></div>
                <div class="group1__border"></div>
            </div>
        </div>
        <div class="main__group1--product">
            <div class="main__group1--product-item item1">
                <div  onclick= "convert ('assets/img/sp1-1.jpg')">
                    <div class="product__img" style="background-image: url('assets/img/sp1-1.jpg');"></div>
                    <div class="prodcut__title">
                        <span>Iphone 1</span>
                    </div>
                    <div class="product__money">
                        <span class="product__money-first">25.000.000đ</span>
                        <span class="product__money-second">19.000.000đ</span>
                    </div>
                    <div class="product__icon">
                        <div class="product__icon--star" >
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                        </div>
                    </div>
                    <span class="product__note">Đã bán 500</span>
                </div>
                <asp:linkbutton runat="server" CssClass="btnShoppingCart" OnClick="function1">
                    <asp:Label runat="server" ID="stringImg1" Text="assets/img/sp1-1.jpg" Visible="false"></asp:Label>
                    <i class="fa-solid fa-cart-plus iconshoppingCart"></i>
                    Thêm vào giỏ hàng
                </asp:linkbutton>
            </div>
            <div class="main__group1--product-item item2" >
                <div onclick= "convert ('assets/img/sp1-2.jpg')">
                    <div class="product__img" style="background-image: url('assets/img/sp1-2.jpg');"></div>
                    <div class="prodcut__title">
                        <span>Iphone 2</span>
                    </div>
                    <div class="product__money">
                        <span class="product__money-first">32.000.000đ</span>
                        <span class="product__money-second">28.000.000đ</span>
                    </div>
                    <div class="product__icon">
                        <div class="product__icon--star" >
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star"></i>
                        </div>
                    </div>
                    <span class="product__note">Đã bán 400</span>
                </div>
                <asp:linkbutton runat="server" CssClass="btnShoppingCart" OnClick="function2">
                    <asp:Label runat="server" ID="stringImg2" Text="assets/img/sp1-2.jpg" Visible="false"></asp:Label>
                    <i class="fa-solid fa-cart-plus iconshoppingCart"></i>
                    Thêm vào giỏ hàng
                </asp:linkbutton>
            </div>
            <div class="main__group1--product-item item3" >
                <div onclick= "convert ('assets/img/sp1-3.jpg')">
                    <div class="product__img" style="background-image: url('assets/img/sp1-3.jpg');"></div>
                    <div class="prodcut__title">
                        <span>Iphone 3</span>
                    </div>
                    <div class="product__money">
                        <span class="product__money-first">12.000.000đ</span>
                        <span class="product__money-second">10.000.000đ</span>
                    </div>
                    <div class="product__icon">
                        <div class="product__icon--star" >
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star"></i>
                        </div>
                    </div>
                    <span class="product__note">Đã bán 200</span>
                </div>
                <asp:linkbutton runat="server" CssClass="btnShoppingCart" OnClick="function3">
                    <asp:Label runat="server" ID="stringImg3" Text="assets/img/sp1-3.jpg" Visible="false"></asp:Label>
                    <i class="fa-solid fa-cart-plus iconshoppingCart"></i>
                    Thêm vào giỏ hàng
                </asp:linkbutton>
            </div>
            <div class="main__group1--product-item item4" >
                <div onclick= "convert ('assets/img/sp1-4.jpg')">   
                    <div class="product__img" style="background-image: url('assets/img/sp1-4.jpg');"></div>
                    <div class="prodcut__title">
                        <span>Iphone 4</span>
                    </div>
                    <div class="product__money">
                        <span class="product__money-first">50.000.000đ</span>
                        <span class="product__money-second">40.000.000đ</span>
                    </div>
                    <div class="product__icon">
                        <div class="product__icon--star" >
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                        </div>
                    </div>
                    <span class="product__note">Đã bán 200</span>
                </div>
                 <asp:linkbutton runat="server" CssClass="btnShoppingCart" OnClick="function4">
                    <asp:Label runat="server" ID="stringImg4" Text="assets/img/sp1-4.jpg" Visible="false"></asp:Label>
                    <i class="fa-solid fa-cart-plus iconshoppingCart"></i>
                    Thêm vào giỏ hàng
                </asp:linkbutton>
            </div>
            <div class="main__group1--product-item item5">
                <div onclick= "convert ('assets/img/sp1-5.jpg')">
                    <div class="product__img" style="background-image: url('assets/img/sp1-5.jpg');"></div>
                    <div class="prodcut__title">
                        <span>Iphone 5</span>
                    </div>
                    <div class="product__money">
                        <span class="product__money-first">42.000.000đ</span>
                        <span class="product__money-second">40.000.000đ</span>
                    </div>
                    <div class="product__icon">
                        <div class="product__icon--star" >
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star"></i>
                        </div>
                    </div>
                    <span class="product__note">Đã bán 100</span>
                </div>
                <asp:linkbutton runat="server" CssClass="btnShoppingCart" OnClick="function5">
                    <asp:Label runat="server" ID="stringImg5" Text="assets/img/sp1-5.jpg" Visible="false"></asp:Label>
                    <i class="fa-solid fa-cart-plus iconshoppingCart"></i>
                    Thêm vào giỏ hàng
                </asp:linkbutton>
            </div>
            <div class="main__group1--product-item item6">
                <div onclick= "convert ('assets/img/sp1-6.jpg')">
                    <div class="product__img" style="background-image: url('assets/img/sp1-6.jpg');"></div>
                    <div class="prodcut__title">
                        <span>Iphone 6</span>
                    </div>
                    <div class="product__money">
                        <span class="product__money-first">30.000.000đ</span>
                        <span class="product__money-second">25.000.000đ</span>
                    </div>
                    <div class="product__icon">
                        <div class="product__icon--star" >
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star"></i>
                        </div>
                    </div>
                    <span class="product__note">Đã bán 300</span>
                </div>
                <asp:linkbutton runat="server" CssClass="btnShoppingCart" OnClick="function6">
                    <asp:Label runat="server" ID="stringImg6" Text="assets/img/sp1-6.jpg" Visible="false"></asp:Label>
                    <i class="fa-solid fa-cart-plus iconshoppingCart"></i>
                    Thêm vào giỏ hàng
                </asp:linkbutton>
            </div>
        </div>
        <div class="main__group1--img">
            <img class="main__group1--img-1" src="assets/img/bener1.png" alt="">
        </div>
    </div>
    <div class="main__group">
        <div class="main__group1--title">
            <h3 class="main__group1--title-text">Sản Phẩm MỚI</h3>
            <div class="main__group1--title-boder">
                <div class="group1__border"></div>
                <div class="group1__border"></div>
            </div>
        </div>
        <div class="main__group1--product">
            <div class="main__group1--product-item item1" >
                <div onclick= "convert ('assets/img/sp2-1.jpg')">
                    <div class="product__img" style="background-image: url('assets/img/sp2-1.jpg');"></div>
                    <div class="prodcut__title">
                        <span>SamSung 1</span>
                    </div>
                    <div class="product__money">
                        <span class="product__money-first">35.000.000đ</span>
                        <span class="product__money-second">29.000.000đ</span>
                    </div>
                    <div class="product__icon">
                        <div class="product__icon--star" >
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                        </div>
                    </div>
                    <span class="product__note">Đã bán 50</span>
                </div>
                <asp:linkbutton runat="server" CssClass="btnShoppingCart" OnClick="function7">
                    <asp:Label runat="server" ID="stringImg7" Text="assets/img/sp2-1.jpg" Visible="false"></asp:Label>
                    <i class="fa-solid fa-cart-plus iconshoppingCart"></i>
                    Thêm vào giỏ hàng
                </asp:linkbutton>
            </div>
            <div class="main__group1--product-item item2">
                <div  onclick= "convert ('assets/img/sp2-2.jpg')">
                    <div class="product__img" style="background-image: url('assets/img/sp2-2.jpg');"></div>
                    <div class="prodcut__title">
                        <span>SamSung 2</span>
                    </div>
                    <div class="product__money">
                        <span class="product__money-first">23.000.000đ</span>
                        <span class="product__money-second">20.000.000đ</span>
                    </div>
                    <div class="product__icon">
                        <div class="product__icon--star" >
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star"></i>
                        </div>
                    </div>
                    <span class="product__note">Đã bán 40</span>
                </div>
                <asp:linkbutton runat="server" CssClass="btnShoppingCart" OnClick="function8">
                    <asp:Label runat="server" ID="stringImg8" Text="assets/img/sp2-2.jpg" Visible="false"></asp:Label>
                    <i class="fa-solid fa-cart-plus iconshoppingCart"></i>
                    Thêm vào giỏ hàng
                </asp:linkbutton>
            </div>
            <div class="main__group1--product-item item3">
                <div onclick="convert('assets/img/sp2-3.jpg')">
                    <div class="product__img" style="background-image: url('assets/img/sp2-3.jpg');"></div>
                    <div class="prodcut__title">
                        <span>SamSung 3</span>
                    </div>
                    <div class="product__money">
                        <span class="product__money-first">800.000đ</span>
                        <span class="product__money-second">500.000đ</span>
                    </div>
                    <div class="product__icon">
                        <div class="product__icon--star" >
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star"></i>
                        </div>
                    </div>
                    <span class="product__note">Đã bán 20</span>
                </div>
                <asp:linkbutton runat="server" CssClass="btnShoppingCart" OnClick="function9">
                    <asp:Label runat="server" ID="stringImg9" Text="assets/img/sp2-3.jpg" Visible="false"></asp:Label>
                    <i class="fa-solid fa-cart-plus iconshoppingCart"></i>
                    Thêm vào giỏ hàng
                </asp:linkbutton>
            </div>
            <div class="main__group1--product-item item4">
                <div onclick="convert('assets/img/sp2-4.jpg')">
                    <div class="product__img" style="background-image: url('assets/img/sp2-4.jpg');"></div>
                    <div class="prodcut__title">
                        <span>SamSung 4</span>
                    </div>
                    <div class="product__money">
                        <span class="product__money-first">1.550.000đ</span>
                        <span class="product__money-second">1.230.000đ</span>
                    </div>
                    <div class="product__icon">
                        <div class="product__icon--star" >
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                        </div>
                    </div>
                    <span class="product__note">Đã bán 40</span>
                </div>
                <asp:linkbutton runat="server" CssClass="btnShoppingCart" OnClick="function10">
                    <asp:Label runat="server" ID="stringImg10" Text="assets/img/sp2-4.jpg" Visible="false"></asp:Label>
                    <i class="fa-solid fa-cart-plus iconshoppingCart"></i>
                    Thêm vào giỏ hàng
                </asp:linkbutton>
            </div>
            <div class="main__group1--product-item item5">
                <div onclick="convert('assets/img/sp2-5.jpg')">
                    <div class="product__img" style="background-image: url('assets/img/sp2-5.jpg');"></div>
                    <div class="prodcut__title">
                        <span>SamSung 5</span>
                    </div>
                    <div class="product__money">
                        <span class="product__money-first">2.000.000đ</span>
                        <span class="product__money-second">1.600.000đ</span>
                    </div>
                    <div class="product__icon">
                        <div class="product__icon--star" >
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star"></i>
                        </div>
                    </div>
                    <span class="product__note">Đã bán 50</span>
                </div>
                <asp:linkbutton runat="server" CssClass="btnShoppingCart" OnClick="function11">
                    <asp:Label runat="server" ID="stringImg11" Text="assets/img/sp2-5.jpg" Visible="false"></asp:Label>
                    <i class="fa-solid fa-cart-plus iconshoppingCart"></i>
                    Thêm vào giỏ hàng
                </asp:linkbutton>
            </div>
            <div class="main__group1--product-item item6">
                <div onclick="convert('assets/img/sp2-6.png')">
                    <div class="product__img" style="background-image: url('assets/img/sp2-6.jpg');"></div>
                    <div class="prodcut__title">
                        <span>SamSung 6</span>
                    </div>
                    <div class="product__money">
                        <span class="product__money-first">4.000.000đ</span>
                        <span class="product__money-second">3.500.000đ</span>
                    </div>
                    <div class="product__icon">
                        <div class="product__icon--star" >
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star"></i>
                        </div>
                    </div>
                    <span class="product__note">Đã bán 70</span>
                </div>
                <asp:linkbutton runat="server" CssClass="btnShoppingCart" OnClick="function12">
                    <asp:Label runat="server" ID="stringImg12" Text="assets/img/sp2-6.png" Visible="false"></asp:Label>
                    <i class="fa-solid fa-cart-plus iconshoppingCart"></i>
                    Thêm vào giỏ hàng
                </asp:linkbutton>
            </div>
        </div>
        <div class="main__group1--img">
            <img class="main__group1--img-1" src="assets/img/benner2.png" alt="">
        </div>
    </div>
    <div class="main__group">
        <div class="main__group1--title">
            <h3 class="main__group1--title-text">SẢN PHẨM BÁN CHẠY</h3>
            <div class="main__group1--title-boder">
                <div class="group1__border"></div>
                <div class="group1__border"></div>
            </div>
        </div>
        <div class="main__group1--product">
            <div class="main__group1--product-item item1">
                <div onclick="convert('assets/img/SP3-1.jpg')">
                    <div class="product__img" style="background-image: url('assets/img/SP3-1.jpg');"></div>
                    <div class="prodcut__title">
                        <span>Xaomi 1 </span>
                    </div>
                    <div class="product__money">
                        <span class="product__money-first">33.000.000đ</span>
                        <span class="product__money-second">25.000.000đ</span>
                    </div>
                    <div class="product__icon">
                        <div class="product__icon--star" >
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                        </div>
                    </div>
                    <span class="product__note">Đã bán 420</span>
                </div>
                <asp:linkbutton runat="server" CssClass="btnShoppingCart" OnClick="function13">
                    <asp:Label runat="server" ID="stringImg13" Text="assets/img/SP3-1.jpg" Visible="false"></asp:Label>
                    <i class="fa-solid fa-cart-plus iconshoppingCart"></i>
                    Thêm vào giỏ hàng
                </asp:linkbutton>
            </div>
            <div class="main__group1--product-item item2">
                <div  onclick="convert('assets/img/SP3-2.png')">
                    <div class="product__img" style="background-image: url('assets/img/SP3-2.jpg');"></div>
                    <div class="prodcut__title">
                        <span>Xaomi 2 </span>
                    </div>
                    <div class="product__money">
                        <span class="product__money-first">2.520.000đ</span>
                        <span class="product__money-second">1.980.000đ</span>
                    </div>
                    <div class="product__icon">
                        <div class="product__icon--star" >
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star"></i>
                        </div>
                    </div>
                    <span class="product__note">Đã bán 450</span>
                </div>
                <asp:linkbutton runat="server" CssClass="btnShoppingCart" OnClick="function14">
                    <asp:Label runat="server" ID="stringImg14" Text="assets/img/SP3-2.jpg" Visible="false"></asp:Label>
                    <i class="fa-solid fa-cart-plus iconshoppingCart"></i>
                    Thêm vào giỏ hàng
                </asp:linkbutton>
            </div>
            <div class="main__group1--product-item item3">
                <div  onclick="convert('assets/img/SP3-3.jpg')">
                    <div class="product__img" style="background-image: url('assets/img/SP3-3.jpg');"></div>
                    <div class="prodcut__title">
                        <span>Xaomi 3 </span>
                    </div>
                    <div class="product__money">
                        <span class="product__money-first">4.020.000đ</span>
                        <span class="product__money-second">4.000.000đ</span>
                    </div>
                    <div class="product__icon">
                        <div class="product__icon--star" >
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star"></i>
                        </div>
                    </div>
                    <span class="product__note">Đã bán 200</span>
                </div>
                <asp:linkbutton runat="server" CssClass="btnShoppingCart" OnClick="function15">
                    <asp:Label runat="server" ID="stringImg15" Text="assets/img/SP3-3.jpg" Visible="false"></asp:Label>
                    <i class="fa-solid fa-cart-plus iconshoppingCart"></i>
                    Thêm vào giỏ hàng
                </asp:linkbutton>
            </div>
            <div class="main__group1--product-item item4">
                <div onclick="convert('assets/img/sp3-4.jpg')">
                    <div class="product__img" style="background-image: url('assets/img/sp3-4.jpg');"></div>
                    <div class="prodcut__title">
                        <span>Xaomi 4</span>
                    </div>
                    <div class="product__money">
                        <span class="product__money-first">500.000đ</span>
                        <span class="product__money-second">400.000đ</span>
                    </div>
                    <div class="product__icon">
                        <div class="product__icon--star" >
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                        </div>
                    </div>
                    <span class="product__note">Đã bán 340</span>
                </div>
                <asp:linkbutton runat="server" CssClass="btnShoppingCart" OnClick="function16">
                    <asp:Label runat="server" ID="stringImg16" Text="assets/img/sp3-4.jpg" Visible="false"></asp:Label>
                    <i class="fa-solid fa-cart-plus iconshoppingCart"></i>
                    Thêm vào giỏ hàng
                </asp:linkbutton>
            </div>
            <div class="main__group1--product-item item5">
                <div onclick="convert('assets/img/sp3-5.jpg')">
                    <div class="product__img" style="background-image: url('assets/img/sp3-5.jpg');"></div>
                    <div class="prodcut__title">
                        <span>Xaomi 5</span>
                    </div>
                    <div class="product__money">
                        <span class="product__money-first">3.500.000đ</span>
                        <span class="product__money-second">2.800.000đ</span>
                    </div>
                    <div class="product__icon">
                        <div class="product__icon--star" >
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star"></i>
                        </div>
                    </div>
                    <span class="product__note">Đã bán 400</span>
                </div>
                <asp:linkbutton runat="server" CssClass="btnShoppingCart" OnClick="function17">
                    <asp:Label runat="server" ID="stringImg17" Text="assets/img/sp3-5.jpg" Visible="false"></asp:Label>
                    <i class="fa-solid fa-cart-plus iconshoppingCart"></i>
                    Thêm vào giỏ hàng
                </asp:linkbutton>
            </div>
            <div class="main__group1--product-item item6">
                <div onclick="convert('assets/img/sp3-6.jpg')">
                    <div class="product__img" style="background-image: url('assets/img/sp3-6.jpg');"></div>
                    <div class="prodcut__title"> 
                        <span>Xaomi 6</span>
                    </div>
                    <div class="product__money">
                        <span class="product__money-first">4.000.000đ</span>
                        <span class="product__money-second">3.500.000đ</span>
                    </div>
                    <div class="product__icon">
                        <div class="product__icon--star" >
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star product__icon--star-color"></i>
                            <i class="fa-solid fa-star"></i>
                        </div>
                    </div>
                    <span class="product__note">Đã bán 300</span>
                </div>
                <asp:linkbutton runat="server" CssClass="btnShoppingCart" OnClick="function18">
                    <asp:Label runat="server" ID="stringImg18" Text="assets/img/sp3-6.jpg" Visible="false"></asp:Label>
                    <i class="fa-solid fa-cart-plus iconshoppingCart"></i>
                    Thêm vào giỏ hàng
                </asp:linkbutton>
            </div>
        </div>
    </div>
</main>  

<main class="details"> 
    <div class="details__content">
        <div class="details__content--img"></div>
        <div class="details__content--info">
            <div class="details__content--item1">
                <h3 class="details__content--info--title"></h3>
                <div class="details__money">
                    <p class="details__money--first"></p>
                    <p class="details__money--second"></p>
                </div>
                <p style="color: var(--primary-color); font-size: 1.3rem;"> Mô tả:</p>
                <div class="details__note">
                </div>
                <div class="details__icon">
                    <div class="details__icon--first">
                        <i class="fa-solid fa-truck-fast details__icon--size"></i>
                        <span class="details__icon--text">Miễn phí giao hàng cho đơn hàng từ 2.000.000đ</span>
                    </div>
                    <div class="details__icon--second">
                        <i class="fa-solid fa-people-carry-box details__icon--size"></i>
                        <span class="details__icon--text">Miễn phí đổi hàng nếu giao hàng lỗi</span>
                    </div>
                </div>
            </div>
            <div class="details__content--item2">
                <asp:Button runat="server" Text="Mua hàng" CssClass="details__btn--first"/>
                <button class="details__btn--second" onclick="comeback()">Trở lại</button>
            </div>
        </div>
    </div>
</main>
    
    <div class="SearchProduct">
    </div>
</asp:Content>
