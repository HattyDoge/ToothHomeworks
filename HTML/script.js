$().ready(function () {
    $(".btn-outline-primary").click(function () {
        $(".card").hide();
        $("." + $(this).attr('id')).show();
        if ($(this).attr('id') == "allCategories") {
            $(".card").show();
        }
    });
})