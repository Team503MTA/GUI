var $appRequest = {

    requestGetListDistrict: function (data) {
        debugger;
        return $appNetwork.send($controller.dataProvider, $action.test, data);
    }

};