using System;
using System.Collections.Generic;
using System.Linq;
using DatabaseManager.Entity;
using MongoDB.Bson;
using MongoRepository;

namespace DatabaseManager
{
    class Program
    {
        static void Main(string[] args)
        {
            AddProvinceQuantity();

        }

        public static void AddProvinceQuantity()
        {
            MongoRepository<Province> provinces = new MongoRepository<Province>();
            MongoRepository<District> districts = new MongoRepository<District>();
            MongoRepository<Age> ages = new MongoRepository<Age>();
            MongoRepository<Sex> sexs = new MongoRepository<Sex>();
            MongoRepository<Job> jobs = new MongoRepository<Job>();

            List<DistrictQuantity> districtQuantities = new MongoRepository<DistrictQuantity>().ToList();


            MongoRepository<ProvinceQuantity> provinceQuantities = new MongoRepository<ProvinceQuantity>();
            var year = 2016;
            foreach (var province in provinces)
            {

                var listDistrict = districts.ToList().Where(p => p.ProvinceId.ToString() == province.Id).ToList();

                foreach (var age in ages)
                {
                    foreach (var sex in sexs)
                    {
                        foreach (var job in jobs)
                        {
                            long total = 0;

                            foreach (var district in listDistrict)
                            {
                                var districtQuantity =
                                    districtQuantities.ToList().FirstOrDefault(p => p.DistrictId.ToString() == district.Id &&
                                                                  p.AgeId.ToString() == age.Id &&
                                                                  p.SexId.ToString() == sex.Id &&
                                                                  p.JobId.ToString() == job.Id &&
                                                                  p.Year == year);
                                if (districtQuantity != null)
                                {
                                    total += districtQuantity.Quantity;
                                }
                            }
                            ProvinceQuantity provinceQuantity = new ProvinceQuantity
                            {
                                ProvinceId = new ObjectId(province.Id),
                                AgeId = new ObjectId(age.Id),
                                SexId = new ObjectId(sex.Id),
                                JobId = new ObjectId(job.Id),
                                Year = year,
                                Quantity = total
                            };
                            provinceQuantities.Add(provinceQuantity);
                        }
                    }
                }
            }
        }

        public void AddDistricQuantity()
        {
            MongoRepository<District> districts = new MongoRepository<District>();
            MongoRepository<Age> ages = new MongoRepository<Age>();
            MongoRepository<Sex> sexs = new MongoRepository<Sex>();
            MongoRepository<Job> jobs = new MongoRepository<Job>();
            MongoRepository<DistrictQuantity> districtQuantities = new MongoRepository<DistrictQuantity>();
            var year = 2016;
            Random rnd = new Random();

            foreach (var district in districts)
            {
                foreach (var age in ages)
                {
                    foreach (var sex in sexs)
                    {
                        foreach (var job in jobs)
                        {
                            DistrictQuantity item = new DistrictQuantity
                            {
                                DistrictId = new ObjectId(district.Id),
                                AgeId = new ObjectId(age.Id),
                                SexId = new ObjectId(sex.Id),
                                JobId = new ObjectId(job.Id),
                                Year = year,
                                Quantity = rnd.Next(1, 50)
                            };
                            districtQuantities.Add(item);
                        }
                    }
                }
            }
        }

    }
}
