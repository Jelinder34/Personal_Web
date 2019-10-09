$('.nav.navbar-nav > li').on('click', function () {
    $('.navbar-nav > li').removeClass('active');
    $(this).addClass('active');
});

$(document).ready(function () {
    $('#mailbutton').click(function (event) {
        window.location = "mailto:john.linder@waystar.com";
    });
});