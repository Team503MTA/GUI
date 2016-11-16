var oFileIn;
var dataUpload;

$(function () {
    oFileIn = document.getElementById('my_file_input');
    if (oFileIn.addEventListener) {
        oFileIn.addEventListener('change', filePicked, false);
    }
});


function filePicked(oEvent) {
    // Get The File From The Input
    var oFile = oEvent.target.files[0];
    // Create A File Reader HTML5
    var reader = new FileReader();

    // Ready The Event For When A File Gets Selected
    reader.onload = function (e) {
        var data = e.target.result;
        var cfb = XLS.CFB.read(data, { type: 'binary' });
        var wb = XLS.parse_xlscfb(cfb);
        // Loop Over Each Sheet
        wb.SheetNames.forEach(function (sheetName) {
            // Obtain The Current Row As CSV
            var sCsv = XLS.utils.make_csv(wb.Sheets[sheetName]);
            var oJs = XLS.utils.sheet_to_row_object_array(wb.Sheets[sheetName]);

            $("#my_file_output").html(sCsv);
            console.log(oJs);
            dataUpload = oJs;
        });
    };

    // Tell JS To Start Reading The File.. You could delay this if desired
    reader.readAsBinaryString(oFile);
}

function FormatDistrict(listData) {
    var listNewData = [];
    for (var i = 0; i < listData.length; i++) {
        var item = {};
    }
}

function UpdateDistrict() {
    $.ajax({
        url: '@Url.Action("UpdateDistrict", "Home")',
        dataType: 'json',
        type: 'POST',
        contentType: 'application/json; charset=utf-8',
        data: data,
        success: function (data) {
            debugger;
        }
    });
}