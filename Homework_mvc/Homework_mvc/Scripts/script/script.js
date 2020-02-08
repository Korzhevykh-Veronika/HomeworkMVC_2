jQuery(document).ready(function () {

    var btn = $('#button');

    $(window).scroll(function () {
        if ($(window).scrollTop() > 100) {
            btn.addClass('show');
        } else {
            btn.removeClass('show');
        }
    });

    btn.on('click', function (e) {
        e.preventDefault();
        $('html, body').animate({ scrollTop: 0 }, '100');
    });

});

$(document).ready(function () {
    $("#showHideContent").click(function () {
        if ($("#form-review").is(":hidden")) {
            $("#form-review").show("slow");
        } else {
            $("#form-review").hide("slow");
        }
        return false;
    });
});
