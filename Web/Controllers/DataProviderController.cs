using System.Web.Mvc;
using DatabaseManager.Entity;
using DatabaseManager.Memory;
using Newtonsoft.Json;

namespace Web.Controllers
{
    public class DataProviderController : Controller
    {


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

    }
}