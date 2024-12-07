<%@ Page Title="" Language="C#" MasterPageFile="~/_layout.Master" AutoEventWireup="true" CodeBehind="SanPham.aspx.cs" Inherits="WebGiaoHang.SanPham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="assets/css/SanPham.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="main">
        <div class="main__group">
            <div class="main__group1--product">
                <div class="main__group1--product-item item1">
                    <div  onclick= "convert ('assets/img/sp1-1.jpg')">
                        <div class="product__img" style="background-image: url('assets/img/sp1-1.jpg');"></div>
                        <div class="prodcut__title">
                            Điện Thoại 1</div>
                        <div class="product__money">
                            <span class="product__money-first">25.000đ</span>
                            <span class="product__money-second">19.000đ</span>
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
                            Điện Thoại 2</div>
                        <div class="product__money">
                            <span class="product__money-first">320.000đ</span>
                            <span class="product__money-second">280.000đ</span>
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
                            Điện Thoại 3</div>
                        <div class="product__money">
                            <span class="product__money-first">120.000đ</span>
                            <span class="product__money-second">100.000đ</span>
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
                            Điện Thoại 4</div>
                        <div class="product__money">
                            <span class="product__money-first">50.000đ</span>
                            <span class="product__money-second">30.000đ</span>
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
                            Điện Thoại 5</div>
                        <div class="product__money">
                            <span class="product__money-first">420.000đ</span>
                            <span class="product__money-second">400.000đ</span>
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
                            Điện Thoại 6</div>
                        <div class="product__money">
                            <span class="product__money-first">30.000đ</span>
                            <span class="product__money-second">25.000đ</span>
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
           
        </div>
        <div class="main__group">
            
            <div class="main__group1--product">
                <div class="main__group1--product-item item1" >
                    <div onclick= "convert ('assets/img/sp2-1.jpg')">
                        <div class="product__img" style="background-image: url('assets/img/sp2-1.jpg');"></div>
                        <div class="prodcut__title">
                            Điện Thoại 7</div>
                        <div class="product__money">
                            <span class="product__money-first">35.000đ</span>
                            <span class="product__money-second">29.000đ</span>
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
                            Điện Thoại 8</div>
                        <div class="product__money">
                            <span class="product__money-first">23.000đ</span>
                            <span class="product__money-second">20.000đ</span>
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
                            Điện Thoại 9</div>
                        <div class="product__money">
                            <span class="product__money-first">80.000đ</span>
                            <span class="product__money-second">50.000đ</span>
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
                            Điện Thoại 10</div>
                        <div class="product__money">
                            <span class="product__money-first">150.000đ</span>
                            <span class="product__money-second">130.000đ</span>
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
                            Điện Thoại 11</div>
                        <div class="product__money">
                            <span class="product__money-first">20.000đ</span>
                            <span class="product__money-second">16.000đ</span>
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
                            Điện Thoại 12</div>
                        <div class="product__money">
                            <span class="product__money-first">40.000đ</span>
                            <span class="product__money-second">35.000đ</span>
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
        </div>
        <div class="main__group">
            <div class="main__group1--product">
                <div class="main__group1--product-item item1">
                    <div onclick="convert('assets/img/SP3-1.jpg')">
                        <div class="product__img" style="background-image: url('assets/img/SP3-1.jpg');"></div>
                        <div class="prodcut__title">
                            Điện Thoại 3</div>
                        <div class="product__money">
                            <span class="product__money-first">33.000đ</span>
                            <span class="product__money-second">25.000đ</span>
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
                            Điện Thoại 14</div>
                        <div class="product__money">
                            <span class="product__money-first">220.000đ</span>
                            <span class="product__money-second">180.000đ</span>
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
                        <asp:Label runat="server" ID="stringImg14" Text="assets/img/SP3-2.png" Visible="false"></asp:Label>
                        <i class="fa-solid fa-cart-plus iconshoppingCart"></i>
                        Thêm vào giỏ hàng
                    </asp:linkbutton>
                </div>
                <div class="main__group1--product-item item3">
                    <div  onclick="convert('assets/img/SP3-3.jpg')">
                        <div class="product__img" style="background-image: url('assets/img/SP3-3.jpg');"></div>
                        <div class="prodcut__title">
                            Điện Thoại 15</div>
                        <div class="product__money">
                            <span class="product__money-first">420.000đ</span>
                            <span class="product__money-second">400.000đ</span>
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
                            Điện Thoại 16</div>
                        <div class="product__money">
                            <span class="product__money-first">50.000đ</span>
                            <span class="product__money-second">40.000đ</span>
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
                            Điện Thoại 17</div>
                        <div class="product__money">
                            <span class="product__money-first">35.000đ</span>
                            <span class="product__money-second">28.000đ</span>
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
                            Điện Thoại 18</div>
                        <div class="product__money">
                            <span class="product__money-first">40.000đ</span>
                            <span class="product__money-second">35.000đ</span>
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
                    <button class="details__btn--first">Mua hàng</button>
                    <button class="details__btn--second" onclick="comeback()">Trở lại</button>
                </div>
            </div>
        </div>
    </main>

    <div class="SearchProduct">
    </div>
</asp:Content>
