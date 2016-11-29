using System.Collections.Generic;
using System.Web.Mvc;
using DatabaseManager.CustomObject;
using DatabaseManager.Entity;
using DatabaseManager.Memory;

namespace Web.Controllers
{
    public class UploadController : Controller
    {

        public string UploadDistrictQuantity(List<DistrictQuantityExcel> listDistrictQuantityExcels)
        {
            List<DistrictQuantity> listInsert = new List<DistrictQuantity>();
            List<DistrictQuantity> listUpdate = new List<DistrictQuantity>();

            foreach (var districtQuantityExcel in listDistrictQuantityExcels)
            {
                DistrictQuantity districtQuantity = new DistrictQuantity();

                //set DistrictId
                District district = MemoryOperator.GetDistrictByName(districtQuantityExcel.Name);
                if (district == null) continue;
                districtQuantity.DistrictId = district.Id;

                //set AgeId
                Age age = MemoryOperator.GetAgeByAgeStart(districtQuantityExcel.Age);
                if (age == null) continue;
                districtQuantity.AgeId = age.Id;

                //set SexId
                Sex sex = MemoryOperator.GetSexBySexName(districtQuantityExcel.Sex);
                if (sex == null) continue;
                districtQuantity.SexId = sex.Id;

                //set JobId
                Job job = MemoryOperator.GetJobByJobName(districtQuantityExcel.Job);
                if (job == null) continue;
                districtQuantity.JobId = job.Id;

                //set year
                int year;
                if (int.TryParse(districtQuantityExcel.Year, out year))
                {
                    districtQuantity.Year = year;
                }
                else
                {
                    continue;
                }

                //set quantity
                long quantity;
                if (long.TryParse(districtQuantityExcel.Quantity, out quantity))
                {
                    districtQuantity.Quantity = quantity;
                }
                else
                {
                    continue;
                }

                //check insert or update
                var checkDistrictQuantity = MemoryOperator.CheckExistDistrictQuantity(districtQuantity);
                if (checkDistrictQuantity == null)
                {
                    listInsert.Add(districtQuantity);
                }
                else
                {
                    districtQuantity.Id = checkDistrictQuantity.Id;
                    listUpdate.Add(districtQuantity);
                }
            }

            MemoryOperator.UpdateMemberThread(listUpdate, listInsert);

            return "1";
        }

        public ActionResult Index()
        {
            return View();
        }

    }
}