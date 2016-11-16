using System.Collections.Generic;
using System.Linq;
using DatabaseManager.Entity;

namespace DatabaseManager.Memory
{
    public class MemoryOperator
    {

        #region Get All

        public static List<DistrictQuantity> GetAllDistrictQuantities(int year)
        {
            return EntityDic.DistrictQuantityDic[year].Values.ToList();
        }

        public static List<ProvinceQuantity> GetAllProvinceQuantities(int year)
        {
            return EntityDic.ProvinceQuantityDic[year].Values.ToList();
        }

        public static List<BranchQuantity> GetAllBranchQuantities(int year)
        {
            return EntityDic.BranchQuantityDic[year].Values.ToList();
        }

        public static List<AreaQuantity> GetAllAreaQuantities(int year)
        {
            return EntityDic.AreaQuantityDic[year].Values.ToList();
        }

        public static List<District> GetAllDistrict()
        {
            return EntityDic.DistrictDic.Values.ToList();
        }

        public static List<Area> GetAllArea()
        {
            return EntityDic.AreaDic.Values.ToList();
        }

        public static List<Branch> GetAllBranch()
        {
            return EntityDic.BranchDic.Values.ToList();
        }

        public static List<Province> GetAllProvince()
        {
            return EntityDic.ProvinceDic.Values.ToList();
        }

        public static List<Age> GetAllAge()
        {
            return EntityDic.AgeDic.Values.ToList();
        }

        public static List<Sex> GetAllSex()
        {
            return EntityDic.SexDic.Values.ToList();
        }

        public static List<Job> GetAllJob()
        {
            return EntityDic.JobDic.Values.ToList();
        }

        #endregion




        public static void InsertDistrictQuantity(List<DistrictQuantity> listData)
        {
            foreach (var districtQuantity in listData)
            {
                EntityCollection.DistrictQuantityCollection.Add(districtQuantity);
            }
        }
    }
}
