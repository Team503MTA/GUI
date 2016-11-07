using System.Collections.Generic;
using System.Linq;
using DatabaseDAL.Entity;
using MongoDB.Bson;
using Population.Models.Keys;

namespace DatabaseDAL.Memory
{
    public class GetCustomMemory
    {
        public static List<District> GetListDistrictByProvinceId(ObjectId proviceId)
        {
            return Memory.DicDistrict.Values.Where(p => p.ProvinceId == proviceId).Select(p => p.Clone() as District).ToList();
        }

        public static long GetQuantityDistrictByYear(DistrictQuantityKeys key, int year)
        {
            if (Memory.DicDistrictQuantity.ContainsKey(year))
            {
                if (Memory.DicDistrictQuantity[year].ContainsKey(key))
                {
                    return Memory.DicDistrictQuantity[year][key].Quantity;
                }
            }
            return 0;
        }

        public static long GetQuantityProvinceByYear(ProvinceQuantityKeys key, int year)
        {
            if (Memory.DicProvinceQuantity.ContainsKey(year))
            {
                if (Memory.DicProvinceQuantity[year].ContainsKey(key))
                {
                    return Memory.DicProvinceQuantity[year][key].Quantity;
                }
            }
            return 0;
        }

        public static long GetQuantityBranchByYear(BranchQuantityKeys key, int year)
        {
            if (Memory.DicBranchQuantity.ContainsKey(year))
            {
                if (Memory.DicBranchQuantity[year].ContainsKey(key))
                {
                    return Memory.DicBranchQuantity[year][key].Quantity;
                }
            }
            return 0;
        }

        public static long GetQuantityDistrictByYearAndAgeAndDistrictId(ObjectId districtId, ObjectId ageId, int year)
        {
            long quantity = 0;
            if (Memory.DicDistrictQuantity.ContainsKey(year))
            {
                var listSex = GetAllMemory.GetAllSex();
                var listJob = GetAllMemory.GetAllJob();

                foreach (var job in listJob)
                {
                    foreach (var sex in listSex)
                    {
                        DistrictQuantityKeys key = new DistrictQuantityKeys
                        {
                            AgeId = ageId,
                            DistrictId = districtId,
                            JobId = job.JobId,
                            SexId = sex.SexId
                        };
                        if (Memory.DicDistrictQuantity[year].ContainsKey(key))
                        {
                            quantity += Memory.DicDistrictQuantity[year][key].Quantity;
                        }
                    }
                }
            }
            return quantity;
        } 

    }
}
