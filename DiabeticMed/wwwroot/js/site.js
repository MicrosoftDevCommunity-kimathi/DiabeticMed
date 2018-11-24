// Write your JavaScript code.
$(window).on('load',function(){//make sure that the page is full loaded
    $('#status').fadeOut();
    $('#preloader').delay(350).fadeOut();
});

//owl-calosel
$(function(){
    $('#team-members').owlCarousel({
        items:2,
        autoplay:true,
        smartSpeed:700,
        loop:true,
        autoplayHoverPause:true,
        nav:true,
        dots:false,
        navText:['<i class="fa fa-angle-left"></i>',
                 '<i class="fa fa-angle-right"></i>']
    });
});