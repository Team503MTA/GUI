

var $operator = {

    getAllDistrict: function () {
        var listKey = Object.keys($db.DicDistrict);
        var listData = [];
        for (var i = 0; i < listKey.length; i++) {
            var item = $appUtil.clone($db.DicDistrict[listKey[i]]);
            listData.push(item);
        }
        return listData;
    },

    getAllBranch: function () {
        var listKey = Object.keys($db.DicBranch);
        var listData = [];
        for (var i = 0; i < listKey.length; i++) {
            var item = $appUtil.clone($db.DicBranch[listKey[i]]);
            listData.push(item);
        }
        return listData;
    },

    getAllProvince: function () {
        var listKey = Object.keys($db.DicProvince);
        var listData = [];
        for (var i = 0; i < listKey.length; i++) {
            var item = $appUtil.clone($db.DicProvince[listKey[i]]);
            listData.push(item);
        }
        return listData;
    },

    getAllArea: function () {
        var listKey = Object.keys($db.DicArea);
        var listData = [];
        for (var i = 0; i < listKey.length; i++) {
            var item = $appUtil.clone($db.DicArea[listKey[i]]);
            listData.push(item);
        }
        return listData;
    },

    getAllAge: function () {
        var listKey = Object.keys($db.DicAge);
        var listData = [];
        for (var i = 0; i < listKey.length; i++) {
            var item = $appUtil.clone($db.DicAge[listKey[i]]);
            listData.push(item);
        }
        return listData;
    },

    getAllSex: function () {
        var listKey = Object.keys($db.DicSex);
        var listData = [];
        for (var i = 0; i < listKey.length; i++) {
            var item = $appUtil.clone($db.DicSex[listKey[i]]);
            listData.push(item);
        }
        return listData;
    },

    getAllJob: function () {
        var listKey = Object.keys($db.DicJob);
        var listData = [];
        for (var i = 0; i < listKey.length; i++) {
            var item = $appUtil.clone($db.DicJob[listKey[i]]);
            listData.push(item);
        }
        return listData;
    },

    getAllMemberType: function () {
        var listData = [];
        for (var i = 0; i < $ListMemberType.length; i++) {
            var item = $appUtil.clone($ListMemberType[i]);
            listData.push(item);
        }
        return listData;
    },

    getAgeByAgeId: function (ageId) {
        if ($db.DicAge.hasOwnProperty(ageId)) {
            return $appUtil.clone($db.DicAge[ageId]);
        }
        return null;
    }

};