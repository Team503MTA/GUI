using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using DatabaseDAL.Entity;
using DatabaseDAL.Memory;
using MongoDB.Bson;

namespace Population.Controllers
{
    public class DataProviderController : Controller
    {
        // GET: DataProvider

        public ActionResult Test()
        {
            District district = GetAllMemory.GetAllDistrict().OrderBy(x => Guid.NewGuid()).FirstOrDefault();
            List<Age> listAge = GetAllMemory.GetAllAge();
            Dictionary<ObjectId, long> quantityAge = new Dictionary<ObjectId, long>();
            foreach (var age in listAge)
            {
                quantityAge[age.AgeId] = GetCustomMemory.GetQuantityDistrictByYearAndAgeAndDistrictId(district.DistrictId,
                    age.AgeId, 2016);
            }
            return Json(quantityAge.Values.ToList());
        }

    }
}