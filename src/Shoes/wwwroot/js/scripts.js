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
                        $('#delete-button').click(function () {
                            console.log("Hello");
                            $.ajax({
                                type: 'POST',
                                url: 'Sales/Delete/' + this.value,
                                success: function (result) {
                                    console.log(result);
                                    var SaleId = result.saleId;
                                    $('#' + SaleId).remove();
                                }
                            });
                        });

                    }
                });

            });
        }
    })
        //$('#delete-button').submit(function () {
        //    $.ajax({
        //        type: 'POST',
        //        url: 'Sales/Delete/' + this.value,
        //        success: function (result) {
        //            var SaleId = result.id.toString();
        //            $('.each-' + SaleId).remove();
        //        }
        //    });
     
        //});

        
        })
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
                var returnResult = result.shoeName;
                $('.newShoe').append('<p>' + returnResult + '</p>');
            }
        });
    });

    

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
