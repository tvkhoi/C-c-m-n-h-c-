

/* nav Menu */ 
var btn__header = document.querySelector('.header__content-nav--item0');
var btn__header__item1 = document.querySelector('.header__content-nav');
var check = btn__header__item1.clientHeight;

btn__header.onclick = function () {
    var isClose = btn__header__item1.clientHeight <= check;
    if (isClose) {
        btn__header__item1.style.height = 'auto';
    } else {
        btn__header__item1.style.height = null;
    }
}


/* Chi tiết sản phẩm */
var Data = [
    {
        id: 1,
        name: 'Iphone 1',
        price: '25.000.000đ',
        sale: '19.000.000đ',
        image: 'url("assets/img/sp1-1.jpg")',
        information: 'Độ phân giải Full HD+ (1080 x 2340 Pixels) đảm bảo độ rõ nét và chi tiết ấn tượng ở mọi góc độ. Từ việc xem video chất lượng cao đến lướt web và chơi game, màn hình này mang đến trải nghiệm sắc nét và màu sắc chân thực. '   
    },
    {
        id: 2,
        name: 'Iphone 2',
        price: '32.000.000đ',
        sale: '29.000.000đ',
        image: 'url("assets/img/sp1-2.jpg")',
        information: 'Độ phân giải Full HD+ (1080 x 2340 Pixels) đảm bảo độ rõ nét và chi tiết ấn tượng ở mọi góc độ. Từ việc xem video chất lượng cao đến lướt web và chơi game, màn hình này mang đến trải nghiệm sắc nét và màu sắc chân thực. '
    },
    {
        id: 3,
        name: 'Iphone 3',
        price: '12.000.000đ',
        sale: '10.000.000đ',
        image: 'url("assets/img/sp1-3.jpg")',
        information: 'Độ phân giải Full HD+ (1080 x 2340 Pixels) đảm bảo độ rõ nét và chi tiết ấn tượng ở mọi góc độ. Từ việc xem video chất lượng cao đến lướt web và chơi game, màn hình này mang đến trải nghiệm sắc nét và màu sắc chân thực. '
    },
    {
        id: 4,
        name: 'Iphone 4',
        price: '5.000.000đ',
        sale: '3.000.000đ',
        image: 'url("assets/img/sp1-4.jpg")',
        information: 'Độ phân giải Full HD+ (1080 x 2340 Pixels) đảm bảo độ rõ nét và chi tiết ấn tượng ở mọi góc độ. Từ việc xem video chất lượng cao đến lướt web và chơi game, màn hình này mang đến trải nghiệm sắc nét và màu sắc chân thực. '
    },
    {
        id: 5,
        name: 'Iphone 5',
        price: '42.000.000đ',
        sale: '40.000.000đ',
        image: 'url("assets/img/sp1-5.jpg")',
        information: 'Độ phân giải Full HD+ (1080 x 2340 Pixels) đảm bảo độ rõ nét và chi tiết ấn tượng ở mọi góc độ. Từ việc xem video chất lượng cao đến lướt web và chơi game, màn hình này mang đến trải nghiệm sắc nét và màu sắc chân thực. '
    },
    {
        id: 6,
        name: 'Iphone 6',
        price: '30.000.000đ',
        sale: '25.000.000đ',
        image: 'url("assets/img/sp1-6.jpg")',
        information: 'Độ phân giải Full HD+ (1080 x 2340 Pixels) đảm bảo độ rõ nét và chi tiết ấn tượng ở mọi góc độ. Từ việc xem video chất lượng cao đến lướt web và chơi game, màn hình này mang đến trải nghiệm sắc nét và màu sắc chân thực. '
    },
    {
        id: 7,
        name: 'Samsung 1',
        price:'3.500.000đ',
        sale: '2.900.000đ',
        image: 'url("assets/img/sp2-1.jpg")',
        information: 'Độ phân giải Full HD+ (1080 x 2340 Pixels) đảm bảo độ rõ nét và chi tiết ấn tượng ở mọi góc độ. Từ việc xem video chất lượng cao đến lướt web và chơi game, màn hình này mang đến trải nghiệm sắc nét và màu sắc chân thực. '
    },
    {
        id: 8,
        name: 'Samsung 2',
        price:'23.000.000đ',
        sale: '20.000.000đ',
        image:'url("assets/img/sp2-2.jpg")',
        information: 'Độ phân giải Full HD+ (1080 x 2340 Pixels) đảm bảo độ rõ nét và chi tiết ấn tượng ở mọi góc độ. Từ việc xem video chất lượng cao đến lướt web và chơi game, màn hình này mang đến trải nghiệm sắc nét và màu sắc chân thực. '
    },
    {
        id: 9,
        name: 'Samsung 3',
        price: '8.000.000đ',
        sale: '5.000.000đ',
        image: 'url("assets/img/sp2-3.jpg")',
        information: 'Độ phân giải Full HD+ (1080 x 2340 Pixels) đảm bảo độ rõ nét và chi tiết ấn tượng ở mọi góc độ. Từ việc xem video chất lượng cao đến lướt web và chơi game, màn hình này mang đến trải nghiệm sắc nét và màu sắc chân thực. '
    },
    {
        id: 10,
        name: 'Samsung 4',
        price: '15.000.000đ',
        sale: '13.000.000đ',
        image: 'url("assets/img/sp2-4.jpg")',
        information: 'Độ phân giải Full HD+ (1080 x 2340 Pixels) đảm bảo độ rõ nét và chi tiết ấn tượng ở mọi góc độ. Từ việc xem video chất lượng cao đến lướt web và chơi game, màn hình này mang đến trải nghiệm sắc nét và màu sắc chân thực. '
    },
    {
        id: 11,
        name: 'Samsung 5',
        price: '2.000.000đ',
        sale: '1.600.000đ',
        image: 'url("assets/img/sp2-5.jpg")',
        information: 'Độ phân giải Full HD+ (1080 x 2340 Pixels) đảm bảo độ rõ nét và chi tiết ấn tượng ở mọi góc độ. Từ việc xem video chất lượng cao đến lướt web và chơi game, màn hình này mang đến trải nghiệm sắc nét và màu sắc chân thực. '
    },
    {
        id: 12,
        name: 'Samsung 6',
        price: '4.000.000đ',
        sale: '3.500.000đ',
        image: 'url("assets/img/sp2-6.png")',
        information: 'Độ phân giải Full HD+ (1080 x 2340 Pixels) đảm bảo độ rõ nét và chi tiết ấn tượng ở mọi góc độ. Từ việc xem video chất lượng cao đến lướt web và chơi game, màn hình này mang đến trải nghiệm sắc nét và màu sắc chân thực. '
    },
    {
        id: 13,
        name: 'Xiaomi 1',
        price: '33.000.000đ',
        sale: '25.000.000đ',
        image: 'url("assets/img/SP3-1.jpg")',
        information: 'Độ phân giải Full HD+ (1080 x 2340 Pixels) đảm bảo độ rõ nét và chi tiết ấn tượng ở mọi góc độ. Từ việc xem video chất lượng cao đến lướt web và chơi game, màn hình này mang đến trải nghiệm sắc nét và màu sắc chân thực. '
    },
    {
        id: 14,
        name: 'Xiaomi 2',
        price: ' 2.200.000đ',
        sale: '1.800.000đ',
        image: 'url("assets/img/SP3-2.png")',
        information: 'Độ phân giải Full HD+ (1080 x 2340 Pixels) đảm bảo độ rõ nét và chi tiết ấn tượng ở mọi góc độ. Từ việc xem video chất lượng cao đến lướt web và chơi game, màn hình này mang đến trải nghiệm sắc nét và màu sắc chân thực. '
    },
    {
        id: 15,
        name: 'Xiaomi 3',
        price: '4.520.000đ',
        sale: '4.000.000đ',
        image: 'url("assets/img/SP3-3.jpg")',
        information: 'Độ phân giải Full HD+ (1080 x 2340 Pixels) đảm bảo độ rõ nét và chi tiết ấn tượng ở mọi góc độ. Từ việc xem video chất lượng cao đến lướt web và chơi game, màn hình này mang đến trải nghiệm sắc nét và màu sắc chân thực. '
    },
    {
        id: 16,
        name: 'Xiaomi 4',
        price: '5.000.000đ',
        sale: '4.000.000đ',
        image: 'url("assets/img/sp3-4.jpg")',
        information: 'Độ phân giải Full HD+ (1080 x 2340 Pixels) đảm bảo độ rõ nét và chi tiết ấn tượng ở mọi góc độ. Từ việc xem video chất lượng cao đến lướt web và chơi game, màn hình này mang đến trải nghiệm sắc nét và màu sắc chân thực. '
    },
    {
        id: 17,
        name: 'Xiaomi 5',
        price: '3.500.000đ',
        sale: '2.800.000đ',
        image: 'url("assets/img/sp3-5.jpg")',
        information: 'Độ phân giải Full HD+ (1080 x 2340 Pixels) đảm bảo độ rõ nét và chi tiết ấn tượng ở mọi góc độ. Từ việc xem video chất lượng cao đến lướt web và chơi game, màn hình này mang đến trải nghiệm sắc nét và màu sắc chân thực. '
    },
    {
        id: 18,
        name: 'Xiaomi 6',
        price: '4.000.000đ',
        sale: '3.500.000đ',
        image: 'url("assets/img/sp3-6.jpg")',
        information: 'Độ phân giải Full HD+ (1080 x 2340 Pixels) đảm bảo độ rõ nét và chi tiết ấn tượng ở mọi góc độ. Từ việc xem video chất lượng cao đến lướt web và chơi game, màn hình này mang đến trải nghiệm sắc nét và màu sắc chân thực. '
    }
];

function convert(temp) {
    var cache = temp;
    temp = "url" + '("' + temp + '")';
    var img = document.querySelector('.details__content--img');
    var title = document.querySelector('.details__content--info--title');
    var money1 = document.querySelector('.details__money--first');
    var money2 = document.querySelector('.details__money--second');
    var content = document.querySelector('.details__note');
    var item1 = document.querySelector('.main');
    var item2 = document.querySelector ('.details');

    Data.forEach ( function (e) {
        if (temp === e.image) {
            item1.style.display = 'none';
            item2.style.display = 'flex';
            img.style.backgroundImage = e.image;
            title.innerHTML = e.name;
            money1.innerHTML = e.price;
            money2.innerHTML = e.sale;
            content.innerHTML = e.information;
        }
    });
}

function comeback () {
    var item1 = document.querySelector('.main');
    var item2 = document.querySelector ('.details');
    item1.style.display = 'block';
    item2.style.display = 'none';
}


/* Thanh tìm kiếm  */

var enter__search = document.querySelector('.header__content-search--input');
enter__search.oninput = function (e) {
    SearchProduct();
};

function SearchProduct () {
    
    var item1 = document.querySelector('.main');
    var item2 = document.querySelector ('.details');
    var item3 = document.querySelector('.SearchProduct');
    var item4 = document.getElementById('haeder__search-input');
    var item5 = document.querySelector('.main__group1--product-item.item6');
    
    item1.style.display = 'none';
    item2.style.display = 'none';
    item3.style.display = 'flex';

    var child = item3.firstElementChild;
    var check = 1;

    for (; child;) {
        item3.removeChild(child);
        child = item3.firstElementChild;
    }

    Data.forEach ( function (e) {
        if (e.name.toUpperCase().includes(item4.value.toUpperCase()) && item4.value != "") {
            
            var img = document.createElement('div');
            var content = document.createElement('div');

            var title = document.createElement('div');

            var money = document.createElement('div');
            var money1 = document.createElement('div');
            var money2 = document.createElement('div');

            img.className = 'showproduct__img';
            content.className = 'showproduct__content';
            title.className = 'showproduct__title';
            money.className = 'showproduct__money';


            money1.className = 'showproduct__money--first';
            money2.className = 'showproduct__money--second';

            img.style.backgroundImage = e.image;
            title.innerHTML = e.name;
            money1.innerHTML = e.price;
            money2.innerHTML = e.sale;


            money.appendChild(money1);
            money.appendChild(money2);

            content.appendChild(title);
            content.appendChild(money);

            
            var temp  = document.createElement ('div');
            temp.className = 'showproduct';
            temp.appendChild(img);
            temp.appendChild(content);

            temp.onclick = function () {
                var img1 = document.querySelector('.details__content--img');
                var title1 = document.querySelector('.details__content--info--title');
                var money11 = document.querySelector('.details__money--first');
                var money12 = document.querySelector('.details__money--second');
                var content = document.querySelector('.details__note');


                var item11 = document.querySelector('.main');
                var item12 = document.querySelector ('.details');
                var item13 = document.querySelector('.SearchProduct');
                
                Data.forEach ( function (k) {
                    if (e.image === k.image) {
                        item11.style.display = 'none';
                        item13.style.display = 'none';
                        item12.style.display = 'flex';
                        img1.style.backgroundImage = k.image;
                        title1.innerHTML = k.name;
                        money11.innerHTML = k.price;
                        money12.innerHTML = k.sale;
                        content.innerHTML = k.information;
                    }
                });
            };
            item3.appendChild(temp);
            check = 0;
        }
    });

    if (check) {
        var error = document.createElement('div');
        var txtconten = document.createElement('span');
        error.className = 'Error';
        error.appendChild(txtconten);
        item3.appendChild(error);
        
        txtconten.innerText = 'Không tìm thấy sản phẩm!!!';
        
        console.log (error);
        
    }
}