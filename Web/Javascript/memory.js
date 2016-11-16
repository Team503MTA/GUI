

var $db = {};


// #region Area__Memory

$db.DicArea = {};
var initArea = function (data) {
    if (!data || data.length <= 0) return;
    for (var i = 0; i < data.length; i++) {
        $db.DicArea[data[i].Id] = data[i];
    }
};
sendRequest($Controller.Dataprovider, $Action.GetAllArea, null, initArea);

// #endregion



// #region Branch__Memory

$db.DicBranch = {};
var initBranch = function (data) {
    if (!data || data.length <= 0) return;
    for (var i = 0; i < data.length; i++) {
        $db.DicBranch[data[i].Id] = data[i];
    }
};
sendRequest($Controller.Dataprovider, $Action.GetAllBranch, null, initBranch);

// #endregion



// #region Province__Memory

$db.DicProvince = {};
var initProvince = function (data) {
    if (!data || data.length <= 0) return;
    for (var i = 0; i < data.length; i++) {
        $db.DicProvince[data[i].Id] = data[i];
    }
};
sendRequest($Controller.Dataprovider, $Action.GetAllProvince, null, initProvince);

// #endregion



// #region District__Memory

$db.DicDistrict = {};
var initDistrict = function (data) {
    if (!data || data.length <= 0) return;
    for (var i = 0; i < data.length; i++) {
        $db.DicDistrict[data[i].Id] = data[i];
    }
};
sendRequest($Controller.Dataprovider, $Action.GetAllDistrict, null, initDistrict);

// #endregion


// #region Age__Memory

$db.DicAge = {};
var initAge = function (data) {
    if (!data || data.length <= 0) return;
    for (var i = 0; i < data.length; i++) {
        $db.DicAge[data[i].Id] = data[i];
    }
};
sendRequest($Controller.Dataprovider, $Action.GetAllAge, null, initAge);

// #endregion


// #region Sex__Memory

$db.DicSex = {};
var initSex = function (data) {
    if (!data || data.length <= 0) return;
    for (var i = 0; i < data.length; i++) {
        $db.DicSex[data[i].Id] = data[i];
    }
};
sendRequest($Controller.Dataprovider, $Action.GetAllSex, null, initSex);

// #endregion


// #region Job__Memory

$db.DicJob = {};
var initJob = function (data) {
    if (!data || data.length <= 0) return;
    for (var i = 0; i < data.length; i++) {
        $db.DicJob[data[i].Id] = data[i];
    }
};
sendRequest($Controller.Dataprovider, $Action.GetAllJob, null, initJob);

// #endregion




