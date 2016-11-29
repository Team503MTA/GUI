
(function () {


    var createChart = function (data) {
        var chartPie = new CanvasJS.Chart("chartContainer",
	    {
	        theme: "theme2",
	        title: {
	            text: "Gaming Consoles Sold in 2012"
	        },
	        backgroundColor: "#ecf0f1",
	        data: [
		    {
		        type: "pie",
		        showInLegend: true,
		        toolTipContent: "{y} - #percent %",
		        yValueFormatString: "#0.#,,. Million",
		        legendText: "{indexLabel}",
		        dataPoints: data
		    }
	        ]
	    });
        chartPie.render();
    }


    var appIndex = angular.module('myApp', []);

    appIndex.controller('indexCtrl', function ($scope) {

        $scope.ListMemberType = $operator.getAllMemberType();

        $scope.ListYear = [];

        for (var i = 2015; i < 2018; i++) {
            $scope.ListYear.push(i);
        }
        $scope.MemberTypeSelected = { id: 0 };

        $scope.ListArea = $operator.getAllArea();
        $scope.ListBranch = $operator.getAllBranch();
        $scope.ListProvince = $operator.getAllProvince();
        $scope.ListDistrict = $operator.getAllDistrict();
        $scope.ListAge = $operator.getAllAge();
        $scope.ListSex = $operator.getAllSex();
        $scope.ListJob = $operator.getAllJob();
        $scope.MemberTypeEnum = $appUtil.clone(MemberTypeEnum);
        $scope.MemberSelected = {};
        $scope.Category = $appUtil.clone(CategoryEnum);
        $scope.CatSelected = $scope.Category.Sex;

        $scope.onResponseGetDistrictQuantity = function (objectData) {
            
            createChart(dicChart);
        };

        $scope.DataChartByAge = function(objectData) {
            var dicData = [];
            for (var j = 0; j < $scope.ListAge.length; j++) {
                dicData[$scope.ListAge[j].Id] = 0;
            }

            for (var k = 0; k < objectData.length; k++) {
                dicData[objectData[k].AgeId] += objectData[k].Quantity;
            }

            $scope.DicChartByAge = [];
            for (var l = 0; l < $scope.ListAge.length; l++) {
                var item = {};
                item.y = dicData[$scope.ListAge[l].Id];
                var age = $operator.getAgeByAgeId($scope.ListAge[l].Id);
                item.indexLabel = age.AgeStart + '-' + age.AgeEnd;
                $scope.DicChartByAge.push(item);
            }
        }

        $scope.DataChartBySex = function (objectData) {
            var dicData = [];
            for (var j = 0; j < $scope.ListSex.length; j++) {
                dicData[$scope.ListSex[j].Id] = 0;
            }

            for (var k = 0; k < objectData.length; k++) {
                dicData[objectData[k].SexId] += objectData[k].Quantity;
            }

            $scope.DicChartByAge = [];
            for (var l = 0; l < $scope.ListSex.length; l++) {
                var item = {};
                item.y = dicData[$scope.ListSex[l].Id];
                var age = $operator.getAgeByAgeId($scope.ListSex[l].Id);
                item.indexLabel = age.AgeStart + '-' + age.AgeEnd;
                $scope.DicChartByAge.push(item);
            }
        }

        $scope.View = function () {
            var action = "";
            var data = {};



            data.Year = $scope.YearSelected;
            if ($scope.MemberTypeSelected.id === $scope.MemberTypeEnum.Area) {
                action = $Action.GetAreaQuantityCustom;
                data.areaName = $scope.MemberSelected.AreaName;
            }
            else if ($scope.MemberTypeSelected.id === $scope.MemberTypeEnum.Branch) {
                action = $Action.GetBranchQuantityCustom;
                data.branchName = $scope.MemberSelected.BranchName;
            } else if ($scope.MemberTypeSelected.id === $scope.MemberTypeEnum.Province) {
                action = $Action.GetProvinceQuantityCustom;
                data.provinceName = $scope.MemberSelected.ProvinceName;
            } else if ($scope.MemberTypeSelected.id === $scope.MemberTypeEnum.District) {
                action = $Action.GetDistrictQuantityCustom;
                data.districtName = $scope.MemberSelected.DistrictName;
            }
            sendRequest($Controller.Dataprovider, action, data, $scope.onResponseGetDistrictQuantity);
        };

    });

}()
);













































//var oFileIn;
//var dataUpload;
//
//$(function () {
//    oFileIn = document.getElementById('my_file_input');
//    if (oFileIn.addEventListener) {
//        oFileIn.addEventListener('change', filePicked, false);
//    }
//});
//
//
//function filePicked(oEvent) {
//    // Get The File From The Input
//    var oFile = oEvent.target.files[0];
//    // Create A File Reader HTML5
//    var reader = new FileReader();
//
//    // Ready The Event For When A File Gets Selected
//    reader.onload = function (e) {
//        var data = e.target.result;
//        var cfb = XLS.CFB.read(data, { type: 'binary' });
//        var wb = XLS.parse_xlscfb(cfb);
//        // Loop Over Each Sheet
//        wb.SheetNames.forEach(function (sheetName) {
//            // Obtain The Current Row As CSV
//            var sCsv = XLS.utils.make_csv(wb.Sheets[sheetName]);
//            var oJs = XLS.utils.sheet_to_row_object_array(wb.Sheets[sheetName]);
//
//            $("#my_file_output").html(sCsv);
//            console.log(oJs);
//            dataUpload = oJs;
//        });
//    };
//
//    // Tell JS To Start Reading The File.. You could delay this if desired
//    reader.readAsBinaryString(oFile);
//}
//
//function FormatDistrict(listData) {
//    var listNewData = [];
//    for (var i = 0; i < listData.length; i++) {
//        var item = {};
//    }
//}
//
//function UpdateDistrict() {
//    $.ajax({
//        url: '@Url.Action("UpdateDistrict", "Home")',
//        dataType: 'json',
//        type: 'POST',
//        contentType: 'application/json; charset=utf-8',
//        data: data,
//        success: function (data) {
//            debugger;
//        }
//    });
//}