const swiper = new Swiper('.mySwiper', {
    direction: 'horizontal',
    loop: true,
    autoplay: {
        delay: 5000,
    },
});

$(document).ready(function () {
    $(window).scroll(function () {
      $(window).scrollTop() > 20 ? $(".navbar").css({ "background-color": "#24285b" }) : $(".navbar").css({ "background-color": "" });
      //$(window).scrollTop() > 20 ? $(".nav-link-index").css({ "color": "#fff" }) : $(".nav-link-index").css({ "color": "#000"});
    });
  });
  
  $('.nav-link, .nav-link-footer').on('click', function(e) { 
  
    e.preventDefault();
  
    var el = $( e.target.getAttribute('href') );
    var elOffset = el.offset().top;
    var elHeight = el.height();
    var windowHeight = $(window).height();
    var offset;
  
    if (elHeight < windowHeight) {
      offset = elOffset - ((windowHeight / 2) - (elHeight / 2));
    }
    else {
      offset = elOffset;
    }
    var speed = 300;
    $('html, body').animate({scrollTop:offset}, speed);
  });