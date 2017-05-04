$(document).ready(function () {
    $('.display-object').click(function () {
        $.ajax({
            type: 'GET',
            datatype: 'json',
            contentType: 'application/json',
            url:$(this).data('request-url'),
            success: function (result) {
                console.log(result);
                var resultString = 'Id: ' + result.id + '<br>Stock: ' + result.stock + '<br>Revenue: ' + result.revenue; 
                $('#result').html(resultString);
            }
        });
    });

    $('.click-details').click(function () {
        $.ajax({
            type: 'GET',
            datatype: 'html',
            url: 'Sales/Details/' + this.id,
            success: function (result) {
                $('.details').html(result);
            }
        })
    })
});
