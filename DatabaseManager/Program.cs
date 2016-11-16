using System;
using System.Collections.Generic;
using System.Linq;
using DatabaseDAL.Keys;
using DatabaseManager.Entity;
using DatabaseManager.Memory;
using MongoDB.Bson;
using MongoRepository;

namespace DatabaseManager
{
    class Program
    {
        static void Main(string[] args)
        {
            //EntityDic.LoadAll();

        }

        public static void AddProvinceQuantity()
        {
            MongoRepository<Province> provinces = new MongoRepository<Province>();
            MongoRepository<District> districts = new MongoRepository<District>();
            MongoRepository<Age> ages = new MongoRepository<Age>();
            MongoRepository<Sex> sexs = new MongoRepository<Sex>();
            MongoRepository<Job> jobs = new MongoRepository<Job>();

            List<DistrictQuantity> districtQuantities = new MongoRepository<DistrictQuantity>().ToList();

            Dictionary<DistrictQuantityKeys, DistrictQuantity> districtQuantityDic = new Dictionary<DistrictQuantityKeys, DistrictQuantity>();

            foreach (var districtQuantity in districtQuantities)
            {
                var keys = new DistrictQuantityKeys
                {
                    DistrictId = districtQuantity.DistrictId,
                    AgeId = districtQuantity.AgeId,
                    SexId = districtQuantity.SexId,
                    JobId = districtQuantity.JobId
                };
                districtQuantityDic[keys] = districtQuantity;

            }

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
                                var key = new DistrictQuantityKeys
                                {
                                    DistrictId = district.Id,
                                    AgeId = age.Id,
                                    SexId = sex.Id,
                                    JobId = job.Id
                                };
                                if (districtQuantityDic.ContainsKey(key))
                                {
                                    total += districtQuantityDic[key].Quantity;
                                }
                            }
                            ProvinceQuantity provinceQuantity = new ProvinceQuantity
                            {
                                ProvinceId = province.Id,
                                AgeId = age.Id,
                                SexId = sex.Id,
                                JobId = job.Id,
                                Year = year,
                                Quantity = total
                            };
                            provinceQuantities.Add(provinceQuantity);
                        }
                    }
                }
            }
        }


        public static void AddBranchQuantity()
        {
            MongoRepository<Branch> branches = new MongoRepository<Branch>();
            MongoRepository<Province> provinces = new MongoRepository<Province>();

            MongoRepository<Age> ages = new MongoRepository<Age>();
            MongoRepository<Sex> sexs = new MongoRepository<Sex>();
            MongoRepository<Job> jobs = new MongoRepository<Job>();

            List<ProvinceQuantity> provinceQuantities = new MongoRepository<ProvinceQuantity>().ToList();

            Dictionary<ProvinceQuantityKeys, ProvinceQuantity> provinceQuantitiesDic = new Dictionary<ProvinceQuantityKeys, ProvinceQuantity>();

            foreach (var provinceQuantity in provinceQuantities)
            {
                var keys = new ProvinceQuantityKeys
                {
                    ProvinceId = provinceQuantity.ProvinceId,
                    AgeId = provinceQuantity.AgeId,
                    SexId = provinceQuantity.SexId,
                    JobId = provinceQuantity.JobId
                };
                provinceQuantitiesDic[keys] = provinceQuantity;

            }

            MongoRepository<BranchQuantity> branchQuantities = new MongoRepository<BranchQuantity>();
            var year = 2016;
            foreach (var branch in branches)
            {

                var listProvince = provinces.ToList().Where(p => p.BranchId.ToString() == branch.Id).ToList();

                foreach (var age in ages)
                {
                    foreach (var sex in sexs)
                    {
                        foreach (var job in jobs)
                        {
                            long total = 0;

                            foreach (var province in listProvince)
                            {
                                var key = new ProvinceQuantityKeys
                                {
                                    ProvinceId = province.Id,
                                    AgeId = age.Id,
                                    SexId = sex.Id,
                                    JobId = job.Id
                                };
                                if (provinceQuantitiesDic.ContainsKey(key))
                                {
                                    total += provinceQuantitiesDic[key].Quantity;
                                }
                            }
                            BranchQuantity branchQuantity = new BranchQuantity
                            {
                                BranchId = branch.Id,
                                AgeId = age.Id,
                                SexId = sex.Id,
                                JobId = job.Id,
                                Year = year,
                                Quantity = total
                            };
                            branchQuantities.Add(branchQuantity);
                        }
                    }
                }
            }
        }

        public static void AddAreaQuantity()
        {
            MongoRepository<Area> areas = new MongoRepository<Area>();
            MongoRepository<Branch> branches = new MongoRepository<Branch>();

            MongoRepository<Age> ages = new MongoRepository<Age>();
            MongoRepository<Sex> sexs = new MongoRepository<Sex>();
            MongoRepository<Job> jobs = new MongoRepository<Job>();

            List<BranchQuantity> branchQuantities = new MongoRepository<BranchQuantity>().ToList();

            Dictionary<BranchQuantityKeys, BranchQuantity> branchQuantitiesDic = new Dictionary<BranchQuantityKeys, BranchQuantity>();

            foreach (var branchQuantity in branchQuantities)
            {
                var keys = new BranchQuantityKeys
                {
                    BranchId = branchQuantity.BranchId,
                    AgeId = branchQuantity.AgeId,
                    SexId = branchQuantity.SexId,
                    JobId = branchQuantity.JobId
                };
                branchQuantitiesDic[keys] = branchQuantity;

            }

            MongoRepository<AreaQuantity> areaQuantities = new MongoRepository<AreaQuantity>();
            var year = 2016;
            foreach (var area in areas)
            {

                var listBranch = branches.ToList().Where(p => p.AreaId.ToString() == area.Id).ToList();

                foreach (var age in ages)
                {
                    foreach (var sex in sexs)
                    {
                        foreach (var job in jobs)
                        {
                            long total = 0;

                            foreach (var branch in listBranch)
                            {
                                var key = new BranchQuantityKeys
                                {
                                    BranchId = branch.Id,
                                    AgeId = age.Id,
                                    SexId = sex.Id,
                                    JobId = job.Id
                                };
                                if (branchQuantitiesDic.ContainsKey(key))
                                {
                                    total += branchQuantitiesDic[key].Quantity;
                                }
                            }
                            AreaQuantity areaQuantity = new AreaQuantity
                            {
                                AreaId = area.Id,
                                AgeId = age.Id,
                                SexId = sex.Id,
                                JobId = job.Id,
                                Year = year,
                                Quantity = total
                            };
                            areaQuantities.Add(areaQuantity);
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
                                DistrictId = district.Id,
                                AgeId = age.Id,
                                SexId = sex.Id,
                                JobId = job.Id,
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
