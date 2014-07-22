//load the dom into the jquery object, .ready waits for it to load to run function()//
$(document).ready(function () {
    $(".whoLink").on("click", function () {
        var url = $(this).data("url");
        $.get(url, function (data) {
            $("#content").html(data);
        });
    });
    $(".whatLink").on("click", function () {
        var url = $(this).data("url");
        $.get(url, function (data) {
            $("#content").html(data);
        });
    });
    $(".whyLink").on("click", function () {
        var url = $(this).data("url");
        $.get(url, function (data) {
            $("#content").html(data);
        });
    });
    $(".howLink").on("click", function () {
        var url = $(this).data("url");
        $.get(url, function (data) {
            $("#content").html(data);
        });
    });
    $(".whereLink").on("click", function () {
        var url = $(this).data("url");
        $.get(url, function (data) {
            $("#content").html(data);
        });
    });
});