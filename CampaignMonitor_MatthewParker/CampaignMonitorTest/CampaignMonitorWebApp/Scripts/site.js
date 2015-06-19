$(document).ready(function () {

    try {
        //First JS requirement
        $('#startsWith1').text(("hang the dj").startsWith("hang"));
        $('#startsWith2').text(("hang the dj").startsWith("Hang"));
        $('#startsWith3').text(("hang the dj").startsWith("I’ve got a room for rent"));
        $('#startsWith4').text(("hang the dj").startsWith(""));
        $('#startsWith5').text(("hang the dj").startsWith("hang the"));
        $('#startsWith6').text(("hang the dj").startsWith(42));
        $('#startsWith7').text(("hang the dj").startsWith({ first: "johnny" }));

        $('#endsWith1').text(("hang the dj").endsWith("dj"));
        $('#endsWith2').text(("hang the dj").endsWith("panic on the streets"));
        $('#endsWith3').text(("hang the dj").endsWith(""));
        $('#endsWith4').text(("hang the dj").endsWith("the dj"));
        $('#endsWith5').text(("hang the dj").endsWith(42));
        $('#endsWith6').text(("hang the dj").endsWith({ first: "johnny" }));
    }
    catch (err) {
        console.log(err.message);
    }

    try {
        //Second JS requirement - stripHtml extension method.
        var htmlStr1 = "<p>Shoplifters of the World <em>Unite</em>!</p>";
        var htmlStr2 = "1 &lt; 2";

        $('#htmlStr1').text(htmlStr1.stripHtml());
        $('#htmlStr2').text(htmlStr2.stripHtml());

    }
    catch (err) {
        console.log(err.message);
    }


    $('.loadlist').click(function () {
        // the JSON data we want to render
        //JSON files were not being picked up so I needed to add entry into the web.config to allow for these - system.Webserver
        //The JSONP file did not parse, so I made small alternation to get it parsing. The cb( ... ) needed to be removed. I checked using a generic online jquery parser
        $.getJSON("/Scripts/test.json", function (data) {
            $('#results').slideToggle(function () {
                var template = $.templates("#theIssueTmpl");
                var htmlOutput = template.render(data);
                $("#template-container").html(htmlOutput);
            });
        }).error(function (jqXhr, textStatus, error) {
            console.log("ERROR: " + textStatus + ", " + error);
        }); 
    })


});


//Extension method for String.stripHtml using a regEx to pull out those HTML tags
String.prototype.stripHtml = function () {
    var _self = this.replace(/(<([^>]+)>)/ig, '');
    return _self;
}



