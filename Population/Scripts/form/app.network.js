
var $appNetwork = {
    send: function (control, action, data) {
        $.ajax({
            url: '../' + control + '/' + action,
            type: 'POST',
            dataType: 'json',
            data: data,
            contentType: 'application/json; charset=utf-8',
            success: function (data) {
                return data;
            },
            error: function (e) {
                console.log(e);
            }
        });
    }
};

