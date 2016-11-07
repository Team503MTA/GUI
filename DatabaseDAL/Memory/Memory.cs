using System.Collections.Generic;
using DatabaseDAL.Entity;
using MongoDB.Bson;
using Population.Models.Entity;
using Population.Models.Keys;

namespace DatabaseDAL.Memory
{
    public class Memory
    {
        public static Dictionary<ObjectId, Area> DicArea = new Dictionary<ObjectId, Area>();

        public static Dictionary<ObjectId, Branch> DicBranch = new Dictionary<ObjectId, Branch>();

        public static Dictionary<ObjectId, Province> DicProvince = new Dictionary<ObjectId, Province>();

        public static Dictionary<ObjectId, District> DicDistrict = new Dictionary<ObjectId, District>();

        public static Dictionary<ObjectId, Age> DicAge = new Dictionary<ObjectId, Age>();

        public static Dictionary<ObjectId, Job> DicJob = new Dictionary<ObjectId, Job>();

        public static Dictionary<ObjectId, Sex> DicSex = new Dictionary<ObjectId, Sex>();

        public static Dictionary<int, Dictionary<DistrictQuantityKeys, DistrictQuantity>> DicDistrictQuantity = new Dictionary<int, Dictionary<DistrictQuantityKeys, DistrictQuantity>>();

        public static Dictionary<int, Dictionary<ProvinceQuantityKeys, ProvinceQuantity>> DicProvinceQuantity = new Dictionary<int, Dictionary<ProvinceQuantityKeys, ProvinceQuantity>>();

        public static Dictionary<int, Dictionary<BranchQuantityKeys, BranchQuantity>> DicBranchQuantity = new Dictionary<int, Dictionary<BranchQuantityKeys, BranchQuantity>>();

        public static Dictionary<int, Dictionary<AreaQuantityKeys, AreaQuantity>> DicAreaQuantity = new Dictionary<int, Dictionary<AreaQuantityKeys, AreaQuantity>>();

    }
}
