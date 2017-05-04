$(document).ready(function () {

    $.ajax({
        type: 'GET',
        dataType: 'html',
        url: 'Sales/SaleList',
        success: function (result) {
            $('.list').html(result);
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
        }
    });

    $('.display-object').click(function () {
        $.ajax({
            type: 'GET',
            datatype: 'json',
            contentType: 'application/json',
            url: $(this).data('request-url'),
            success: function (result) {
                console.log(result);
                var resultString = 'Id: ' + result.id + '<br>Stock: ' + result.stock + '<br>Revenue: ' + result.revenue;
                $('#result').html(resultString);
            }
        });
    });
    $('.click-create').click(function () {
        $.ajax({
            type: 'GET',
            datatype: 'html',
            url: "Sales/Create",
            success: function (result) {
                console.log(result); 
                $('.create').html(result);
            }
        });
    });
    $('.new-sale').submit(function (event) {
        event.preventDefault();
        $.ajax({
            type: 'POST',
            dataType: 'json',
            url: 'Sales/Create',
            data: $(this).serialize(), 
            success: function (result) {
                var returnResult = result.ShoeName;
                $('.newShoe').append('<p>' + returnResult + '</p>');
            }
        });
    });


    $('.click-delete').click(function () {
        $.ajax({
            type: 'GET',
            url: 'Sales/Delete/' + this.id,
            success: function (result) {
                $('.delete-sale').html(result);
            }
        });
    })

    //$('.display-view').ready(function () {
    //    console.log("inside ajax");
    //    $.ajax({
    //        type: 'GET',
    //        dataType: 'html',
    //        url: 'Sales/SaleList',
    //        success: function (result) {
    //            $('.list').html(result);
    //        }
    //    });
    //});
});