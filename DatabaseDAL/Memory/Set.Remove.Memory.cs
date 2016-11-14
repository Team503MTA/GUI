using System.Collections.Generic;
using DatabaseDAL.Entity;
using DatabaseDAL.Keys;

namespace DatabaseDAL.Memory
{
    public class SetMemory
    {
        #region Age
        public static void Set(Age age)
        {
            Memory.DicAge[age.AgeId] = age;
        }

        public static void Remove(Age age)
        {
            if (Memory.DicAge.ContainsKey(age.AgeId))
                Memory.DicAge.Remove(age.AgeId);
        }
        #endregion

        #region Job
        public static void Set(Job job)
        {
            Memory.DicJob[job.JobId] = job;
        }

        public static void Remove(Job job)
        {
            if (Memory.DicJob.ContainsKey(job.JobId))
                Memory.DicJob.Remove(job.JobId);
        }
        #endregion

        #region Sex
        public static void Set(Sex sex)
        {
            Memory.DicSex[sex.SexId] = sex;
        }

        public static void Remove(Sex sex)
        {
            if (Memory.DicSex.ContainsKey(sex.SexId))
                Memory.DicSex.Remove(sex.SexId);
        }
        #endregion

        #region Area
        public static void Set(Area area)
        {
            Memory.DicArea[area.AreaId] = area;
        }

        public static void Remove(Area area)
        {
            if (Memory.DicArea.ContainsKey(area.AreaId))
                Memory.DicArea.Remove(area.AreaId);
        }
        #endregion

        #region Branch
        public static void Set(Branch branch)
        {
            Memory.DicBranch[branch.BranchId] = branch;
        }

        public static void Remove(Branch branch)
        {
            if (Memory.DicBranch.ContainsKey(branch.BranchId))
                Memory.DicBranch.Remove(branch.BranchId);
        }
        #endregion

        #region Province
        public static void Set(Province province)
        {
            Memory.DicProvince[province.ProvinceId] = province;
        }

        public static void Remove(Province province)
        {
            if (Memory.DicProvince.ContainsKey(province.ProvinceId))
                Memory.DicProvince.Remove(province.ProvinceId);
        }
        #endregion

        #region District
        public static void Set(District district)
        {
            Memory.DicDistrict[district.DistrictId] = district;
        }

        public static void Remove(District district)
        {
            if (Memory.DicDistrict.ContainsKey(district.DistrictId))
                Memory.DicDistrict.Remove(district.DistrictId);
        }
        #endregion

        #region AreaQuantity
        public static void Set(AreaQuantity areaQuantity)
        {
            var key = new AreaQuantityKeys
            {
                AreaId = areaQuantity.AreaId,
                SexId = areaQuantity.SexId,
                JobId = areaQuantity.JobId,
                AgeId = areaQuantity.AgeId
            };
            if (!Memory.DicAreaQuantity.ContainsKey(areaQuantity.Year))
            {
                Memory.DicAreaQuantity[areaQuantity.Year] = new Dictionary<AreaQuantityKeys, AreaQuantity>();
            }
            Memory.DicAreaQuantity[areaQuantity.Year][key] = areaQuantity;
        }

        public static void Remove(AreaQuantity areaQuantity)
        {
            var key = new AreaQuantityKeys
            {
                AreaId = areaQuantity.AreaId,
                SexId = areaQuantity.SexId,
                JobId = areaQuantity.JobId,
                AgeId = areaQuantity.AgeId
            };
            if (Memory.DicAreaQuantity.ContainsKey(areaQuantity.Year))
            {
                if (Memory.DicAreaQuantity[areaQuantity.Year].ContainsKey(key))
                {
                    Memory.DicAreaQuantity[areaQuantity.Year].Remove(key);
                }
            }
        }
        #endregion

        #region BranchQuantity
        public static void Set(BranchQuantity branchQuantity)
        {
            var key = new BranchQuantityKeys
            {
                BranchId = branchQuantity.BranchId,
                SexId = branchQuantity.SexId,
                JobId = branchQuantity.JobId,
                AgeId = branchQuantity.AgeId
            };
            if (!Memory.DicBranchQuantity.ContainsKey(branchQuantity.Year))
            {
                Memory.DicBranchQuantity[branchQuantity.Year] = new Dictionary<BranchQuantityKeys, BranchQuantity>();
            }
            Memory.DicBranchQuantity[branchQuantity.Year][key] = branchQuantity;
        }

        public static void Remove(BranchQuantity branchQuantity)
        {
            var key = new BranchQuantityKeys
            {
                BranchId = branchQuantity.BranchId,
                SexId = branchQuantity.SexId,
                JobId = branchQuantity.JobId,
                AgeId = branchQuantity.AgeId
            };
            if (Memory.DicBranchQuantity.ContainsKey(branchQuantity.Year))
            {
                if (Memory.DicBranchQuantity[branchQuantity.Year].ContainsKey(key))
                {
                    Memory.DicBranchQuantity[branchQuantity.Year].Remove(key);
                }
            }
        }
        #endregion

        #region ProvinceQuantity
        public static void Set(ProvinceQuantity provinceQuantity)
        {
            var key = new ProvinceQuantityKeys
            {
                ProvinceId = provinceQuantity.ProvinceId,
                SexId = provinceQuantity.SexId,
                JobId = provinceQuantity.JobId,
                AgeId = provinceQuantity.AgeId
            };
            if (!Memory.DicProvinceQuantity.ContainsKey(provinceQuantity.Year))
            {
                Memory.DicProvinceQuantity[provinceQuantity.Year] = new Dictionary<ProvinceQuantityKeys, ProvinceQuantity>();
            }
            Memory.DicProvinceQuantity[provinceQuantity.Year][key] = provinceQuantity;
        }

        public static void Remove(ProvinceQuantity provinceQuantity)
        {
            var key = new ProvinceQuantityKeys
            {
                ProvinceId = provinceQuantity.ProvinceId,
                SexId = provinceQuantity.SexId,
                JobId = provinceQuantity.JobId,
                AgeId = provinceQuantity.AgeId
            };
            if (Memory.DicProvinceQuantity.ContainsKey(provinceQuantity.Year))
            {
                if (Memory.DicProvinceQuantity[provinceQuantity.Year].ContainsKey(key))
                {
                    Memory.DicProvinceQuantity[provinceQuantity.Year].Remove(key);
                }
            }
        }
        #endregion

        #region DistrictQuantity
        public static void Set(DistrictQuantity districtQuantity)
        {
            var key = new DistrictQuantityKeys
            {
                DistrictId = districtQuantity.DistrictId,
                SexId = districtQuantity.SexId,
                JobId = districtQuantity.JobId,
                AgeId = districtQuantity.AgeId
            };
            if (!Memory.DicDistrictQuantity.ContainsKey(districtQuantity.Year))
            {
                Memory.DicDistrictQuantity[districtQuantity.Year] = new Dictionary<DistrictQuantityKeys, DistrictQuantity>();
            }
            Memory.DicDistrictQuantity[districtQuantity.Year][key] = districtQuantity;
        }

        public static void Remove(DistrictQuantity districtQuantity)
        {
            var key = new DistrictQuantityKeys
            {
                DistrictId = districtQuantity.DistrictId,
                SexId = districtQuantity.SexId,
                JobId = districtQuantity.JobId,
                AgeId = districtQuantity.AgeId
            };
            if (Memory.DicDistrictQuantity.ContainsKey(districtQuantity.Year))
            {
                if (Memory.DicDistrictQuantity[districtQuantity.Year].ContainsKey(key))
                {
                    Memory.DicDistrictQuantity[districtQuantity.Year].Remove(key);
                }
            }
        }
        #endregion

    }
}
