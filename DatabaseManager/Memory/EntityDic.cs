using System.Collections.Generic;
using System.Linq;
using DatabaseDAL.Keys;
using DatabaseManager.Entity;
using MongoRepository;

namespace DatabaseManager.Memory
{
    public class EntityDic
    {
        public static Dictionary<string, Age> AgeDic = new Dictionary<string, Age>();

        public static Dictionary<string, Sex> SexDic = new Dictionary<string, Sex>();

        public static Dictionary<string, Job> JobDic = new Dictionary<string, Job>();

        public static Dictionary<string, Area> AreaDic = new Dictionary<string, Area>();

        public static Dictionary<int, Dictionary<AreaQuantityKeys, AreaQuantity>> AreaQuantityDic = new Dictionary<int, Dictionary<AreaQuantityKeys, AreaQuantity>>();

        public static Dictionary<string, Branch> BranchDic = new Dictionary<string, Branch>();

        public static Dictionary<int, Dictionary<BranchQuantityKeys, BranchQuantity>> BranchQuantityDic = new Dictionary<int, Dictionary<BranchQuantityKeys, BranchQuantity>>();

        public static Dictionary<string, Province> ProvinceDic = new Dictionary<string, Province>();

        public static Dictionary<int, Dictionary<ProvinceQuantityKeys, ProvinceQuantity>> ProvinceQuantityDic = new Dictionary<int, Dictionary<ProvinceQuantityKeys, ProvinceQuantity>>();

        public static Dictionary<string, District> DistrictDic = new Dictionary<string, District>();

        public static Dictionary<int, Dictionary<DistrictQuantityKeys, DistrictQuantity>> DistrictQuantityDic = new Dictionary<int, Dictionary<DistrictQuantityKeys, DistrictQuantity>>();


        public static void LoadAge()
        {
            var listAge = EntityCollection.AgeCollection.ToList();

            foreach (var age in listAge)
            {
                AgeDic[age.Id] = age;
            }
        }

        public static void LoadSex()
        {
            var listSex = EntityCollection.SexCollection.ToList();

            foreach (var sex in listSex)
            {
                SexDic[sex.Id] = sex;
            }
        }

        public static void LoadJob()
        {
            var listJob = EntityCollection.JobCollection.ToList();

            foreach (var job in listJob)
            {
                JobDic[job.Id] = job;
            }
        }

        public static void LoadArea()
        {
            var listArea = EntityCollection.AreaCollection.ToList();

            foreach (var area in listArea)
            {
                AreaDic[area.Id] = area;
            }
        }

        public static void LoadBranch()
        {
            var listBranch = EntityCollection.BranchCollection.ToList();

            foreach (var branch in listBranch)
            {
                BranchDic[branch.Id] = branch;
            }
        }

        public static void LoadProvince()
        {
            var listProvince = EntityCollection.ProvinceCollection.ToList();

            foreach (var province in listProvince)
            {
                ProvinceDic[province.Id] = province;
            }
        }

        public static void LoadDistrict()
        {
            var listDistrict = EntityCollection.DistrictCollection.ToList();

            foreach (var district in listDistrict)
            {
                DistrictDic[district.Id] = district;
            }
        }

        public static void LoadAreaQuantity()
        {
            var listAreaQuantity = EntityCollection.AreaQuantityCollection.ToList();

            foreach (var areaQuantity in listAreaQuantity)
            {
                var key = new AreaQuantityKeys
                {
                    AreaId = areaQuantity.AreaId,
                    AgeId = areaQuantity.AgeId,
                    JobId = areaQuantity.JobId,
                    SexId = areaQuantity.SexId
                };
                if (!AreaQuantityDic.ContainsKey(areaQuantity.Year))
                {
                    AreaQuantityDic[areaQuantity.Year] = new Dictionary<AreaQuantityKeys, AreaQuantity>();
                }
                AreaQuantityDic[areaQuantity.Year][key] = areaQuantity;
            }
        }

        public static void LoadBranchQuantity()
        {
            var listBranchQuantity = EntityCollection.BranchQuantityCollection.ToList();

            foreach (var branchQuantity in listBranchQuantity)
            {
                var key = new BranchQuantityKeys
                {
                    BranchId = branchQuantity.BranchId,
                    AgeId = branchQuantity.AgeId,
                    JobId = branchQuantity.JobId,
                    SexId = branchQuantity.SexId
                };
                if (!BranchQuantityDic.ContainsKey(branchQuantity.Year))
                {
                    BranchQuantityDic[branchQuantity.Year] = new Dictionary<BranchQuantityKeys, BranchQuantity>();
                }
                BranchQuantityDic[branchQuantity.Year][key] = branchQuantity;
            }
        }

        public static void LoadProvinceQuantity()
        {
            var listProvinceQuantity = EntityCollection.ProvinceQuantityCollection.ToList();

            foreach (var provinceQuantity in listProvinceQuantity)
            {
                var key = new ProvinceQuantityKeys
                {
                    ProvinceId = provinceQuantity.ProvinceId,
                    AgeId = provinceQuantity.AgeId,
                    JobId = provinceQuantity.JobId,
                    SexId = provinceQuantity.SexId
                };
                if (!ProvinceQuantityDic.ContainsKey(provinceQuantity.Year))
                {
                    ProvinceQuantityDic[provinceQuantity.Year] = new Dictionary<ProvinceQuantityKeys, ProvinceQuantity>();
                }
                ProvinceQuantityDic[provinceQuantity.Year][key] = provinceQuantity;
            }
        }

        public static void LoadDistrictQuantity()
        {
            var listDistrictQuantity = EntityCollection.DistrictQuantityCollection.ToList();

            foreach (var districtQuantity in listDistrictQuantity)
            {
                var key = new DistrictQuantityKeys
                {
                    DistrictId = districtQuantity.DistrictId,
                    AgeId = districtQuantity.AgeId,
                    JobId = districtQuantity.JobId,
                    SexId = districtQuantity.SexId
                };
                if (!DistrictQuantityDic.ContainsKey(districtQuantity.Year))
                {
                    DistrictQuantityDic[districtQuantity.Year] = new Dictionary<DistrictQuantityKeys, DistrictQuantity>();
                }
                DistrictQuantityDic[districtQuantity.Year][key] = districtQuantity;
            }
        }

        public static void LoadAll()
        {
            LoadAge();

            LoadSex();

            LoadJob();

            LoadArea();

            LoadBranch();

            LoadProvince();

            LoadDistrict();

            LoadAreaQuantity();

            LoadBranchQuantity();

            LoadProvinceQuantity();

            LoadDistrictQuantity();
        }

    }
}
