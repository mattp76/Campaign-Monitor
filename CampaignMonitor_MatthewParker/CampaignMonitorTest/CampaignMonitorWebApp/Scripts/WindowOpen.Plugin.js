(function ($) {

    $.fn.openNewWindow = function (options) {

        // This is the easiest way to have default options.
        //The windows should open according to its group, ie: all Apple products open in same window. The others have their own.
        var settings = $.extend({
            // These are the defaults.
            height: "500",
            width: "700",
            scrollbars: "no",
            left: screen.width/2 - 700/2,
            top: screen.height/2 - 450/2,
            resizable: "no"
        }, options);

        var group = this.data('window-group');
        var url = this.attr('href');

        window.open(url, group, 'width=' + settings.width + ', height=' + settings.height + ', scrollbars= ' + settings.scrollbars + ', resizable=' + settings.resizable + ',left=' + settings.left + ',top=' + settings.top + '');


    };

})(jQuery);


$(document).ready(function () {
    $('a.popup').click(function (event) {
        event.preventDefault();
        $(this).openNewWindow();
    });
});
