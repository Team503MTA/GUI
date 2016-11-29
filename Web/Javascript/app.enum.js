

var $Controller = {

    Dataprovider: 'DataProvider',

    Home: 'Home',

    Upload: 'Upload'

};

var $Action = {

    GetAllDistrict: 'GetAllDistrict',

    GetAllProvince: 'GetAllProvince',

    GetAllArea: 'GetAllArea',

    GetAllBranch: 'GetAllBranch',

    GetAllAge: 'GetAllAge',

    GetAllSex: 'GetAllSex',

    GetAllJob: 'GetAllJob',

    UploadDistrictQuantity: 'UploadDistrictQuantity',

    GetDistrictQuantityByYear: 'GetDistrictQuantityByYear',

    GetCountOfDistrictQuantityByYear: 'GetCountOfDistrictQuantityByYear',

    GetProvinceQuantityByYear: 'GetProvinceQuantityByYear',

    GetCountOfProvinceQuantityByYear: 'GetCountOfProvinceQuantityByYear',

    GetBranchQuantityByYear: 'GetBranchQuantityByYear',

    GetCountOfBranchQuantityByYear: 'GetCountOfBranchQuantityByYear',

    GetAreaQuantityByYear: 'GetAreaQuantityByYear',

    GetCountOfAreaQuantityByYear: 'GetCountOfAreaQuantityByYear',

    GetDistrictQuantityCustom: 'GetDistrictQuantityCustom',

    GetBranchQuantityCustom: 'GetBranchQuantityCustom',

    GetProvinceQuantityCustom: 'GetProvinceQuantityCustom',

    GetAreaQuantityCustom: 'GetAreaQuantityCustom'

}

var $ListMemberType = [
    { Name: 'Miền', id: 1 },
    { Name: 'Vùng', id: 2 },
    { Name: 'Tỉnh', id: 3 },
    { Name: 'Huyện', id: 4 }
];

var MemberTypeEnum = {
    Area: 1,
    Branch: 2,
    Province: 3,
    District: 4
};

var CategoryEnum = {
    Sex: 1,
    Age: 2,
    Job: 3
};