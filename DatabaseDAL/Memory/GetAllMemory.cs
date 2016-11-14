using System.Collections.Generic;
using System.Linq;
using DatabaseDAL.Entity;

namespace DatabaseDAL.Memory
{
    public class GetAllMemory
    {
        public static List<Age> GetAllAge()
        {
            return Memory.DicAge.Values.ToList();
        }
        
        public static List<Sex> GetAllSex()
        {
            return Memory.DicSex.Values.ToList();
        }

        public static List<Job> GetAllJob()
        {
            return Memory.DicJob.Values.ToList();
        }

        public static List<Area> GetAllArea()
        {
            return Memory.DicArea.Values.ToList();
        }

        public static List<Branch> GetAllBranch()
        {
            return Memory.DicBranch.Values.ToList();
        }

        public static List<Province> GetAllProvince()
        {
            return Memory.DicProvince.Values.ToList();
        }

        public static List<District> GetAllDistrict()
        {
            return Memory.DicDistrict.Values.ToList();
        }
        
         
    }
}
