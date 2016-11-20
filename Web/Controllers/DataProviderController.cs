using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using DatabaseManager.Entity;
using DatabaseManager.Memory;
using Newtonsoft.Json;

namespace Web.Controllers
{
    public class DataProviderController : Controller
    {

        #region GetAll

        public string GetAllArea()
        {
            var listData = MemoryOperator.GetAllArea();
            var data = JsonConvert.SerializeObject(listData);
            return data;
        }


        public string GetAllBranch()
        {
            var listData = MemoryOperator.GetAllBranch();
            var data = JsonConvert.SerializeObject(listData);
            return data;
        }


        public string GetAllProvince()
        {
            var listData = MemoryOperator.GetAllProvince();
            var data = JsonConvert.SerializeObject(listData);
            return data;
        }


        public string GetAllDistrict()
        {
            var listData = MemoryOperator.GetAllDistrict();
            var data = JsonConvert.SerializeObject(listData);
            return data;
        }


        public string GetAllAge()
        {
            var listData = MemoryOperator.GetAllAge();
            var data = JsonConvert.SerializeObject(listData);
            return data;
        }


        public string GetAllSex()
        {
            var listData = MemoryOperator.GetAllSex();
            var data = JsonConvert.SerializeObject(listData);
            return data;
        }

        public string GetAllJob()
        {
            var listData = MemoryOperator.GetAllJob();
            var data = JsonConvert.SerializeObject(listData);
            return data;
        }

        #endregion

        #region GetMemberQuantity

        public string GetDistrictQuantityByYear(List<int> listYear)
        {
            var listReturnData = new List<DistrictQuantity>();
            if (listYear.Count <= 0) return JsonConvert.SerializeObject(listReturnData);

            foreach (var year in listYear)
            {
                var childDatas = MemoryOperator.GetAllDistrictQuantities(year);
                listReturnData.AddRange(childDatas);
            }
            return JsonConvert.SerializeObject(listReturnData);
        }

        public string GetCountOfDistrictQuantityByYear(List<int> listYear)
        {
            long count = 0;
            if (listYear.Count <= 0) return JsonConvert.SerializeObject(count);

            count = listYear.Sum(year => MemoryOperator.GetCountOfDistrictQuantities(year));
            return JsonConvert.SerializeObject(count);
        }

        public string GetProvinceQuantityByYear(List<int> listYear)
        {
            var listReturnData = new List<ProvinceQuantity>();
            if (listYear.Count <= 0) return JsonConvert.SerializeObject(listReturnData);

            foreach (var year in listYear)
            {
                var childDatas = MemoryOperator.GetAllProvinceQuantities(year);
                listReturnData.AddRange(childDatas);
            }
            return JsonConvert.SerializeObject(listReturnData);
        }

        public string GetCountOfProvinceQuantityByYear(List<int> listYear)
        {
            long count = 0;
            if (listYear.Count <= 0) return JsonConvert.SerializeObject(count);

            count = listYear.Sum(year => MemoryOperator.GetCountOfProvinceQuantities(year));
            return JsonConvert.SerializeObject(count);
        }

        public string GetBranchQuantityByYear(List<int> listYear)
        {
            var listReturnData = new List<BranchQuantity>();
            if (listYear.Count <= 0) return JsonConvert.SerializeObject(listReturnData);

            foreach (var year in listYear)
            {
                var childDatas = MemoryOperator.GetAllBranchQuantities(year);
                listReturnData.AddRange(childDatas);
            }
            return JsonConvert.SerializeObject(listReturnData);
        }

        public string GetCountOfBranchQuantityByYear(List<int> listYear)
        {
            long count = 0;
            if (listYear.Count <= 0) return JsonConvert.SerializeObject(count);

            count = listYear.Sum(year => MemoryOperator.GetCountOfBranchQuantities(year));
            return JsonConvert.SerializeObject(count);
        }

        public string GetAreaQuantityByYear(List<int> listYear)
        {
            var listReturnData = new List<AreaQuantity>();
            if (listYear.Count <= 0) return JsonConvert.SerializeObject(listReturnData);

            foreach (var year in listYear)
            {
                var childDatas = MemoryOperator.GetAllAreaQuantities(year);
                listReturnData.AddRange(childDatas);
            }
            return JsonConvert.SerializeObject(listReturnData);
        }

        public string GetCountOfAreaQuantityByYear(List<int> listYear)
        {
            long count = 0;
            if (listYear.Count <= 0) return JsonConvert.SerializeObject(count);

            count = listYear.Sum(year => MemoryOperator.GetCountOfAreaQuantities(year));
            return JsonConvert.SerializeObject(count);
        }

        #endregion



    }
}