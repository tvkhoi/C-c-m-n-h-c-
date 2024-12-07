//---------------hien thi form dia chi
const addressBtn = document.querySelector('#address_form')
addressBtn.addEventListener('click', function(){
  document.querySelector('.address_form').style.display='flex';
})


//-----------------dong form dia chi
const addressClose = document.querySelector('#address_close')
addressClose.addEventListener('click', function(){
  document.querySelector('.address_form').style.display='none';
})


//-----------------chuyen slide trang chu
let index =0;
const imgNumber = document.querySelectorAll('.slider_content_left_top img')
const leftBtn = document.querySelector('.fa-chevron-left')
const rightBtn = document.querySelector('.fa-chevron-right')

rightBtn.addEventListener('click', function(){
  index++;
  if (index>imgNumber.length-1) {
    index=0;
  }
  document.querySelector('.slider_content_left_top').style.right= index*100+"%";
})
leftBtn.addEventListener('click', function(){
  index--;
  if (index<0) {
    index=imgNumber.length-1;
  }
  document.querySelector('.slider_content_left_top').style.right=index*100+"%";
})


//-----------------pick slide
const imgNumberPick = document.querySelectorAll('.slider_content_left_bottom li')
imgNumberPick.forEach(function(image,index){
     image.addEventListener('click',function(){
          document.querySelector('.slider_content_left_top').style.right=index*100+"%";
     })
})


//------------------auto chuyen slide 
function imgAuto (){
    index++;
    if (index>imgNumber.length-1) {
      index=0;
    }
    document.querySelector('.slider_content_left_top').style.right=index*100+"%";
}
setInterval(imgAuto,5000)


//-------------------slider product
const divNumber = document.querySelectorAll('.slider_product_one_content_items')
const leftBtnDiv = document.querySelector('.fa-chevron-left-div')
const rightBtnDiv = document.querySelector('.fa-chevron-right-div')
rightBtnDiv.addEventListener('click', function(){
  index++;
  if (index>divNumber.length-1) {
    index=0;
  }
  document.querySelector('.slider_product_one_content_items_content').style.right= index*100+"%";
})
leftBtnDiv.addEventListener('click', function(){
  index--;
  if (index<0) {
    index=divNumber.length-1;
  }
  document.querySelector('.slider_product_one_content_items_content').style.right=index*100+"%";
})