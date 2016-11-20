using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using DatabaseDAL.Keys;
using DatabaseManager.Entity;
using DatabaseManager.Keys;

namespace DatabaseManager.Memory
{
    public class MemoryOperator
    {

        #region Get All

        public static List<DistrictQuantity> GetAllDistrictQuantities(int year)
        {
            return EntityDic.DistrictQuantityDic[year].Select(obj => obj.Value.Clone() as DistrictQuantity).ToList();
        }

        public static List<ProvinceQuantity> GetAllProvinceQuantities(int year)
        {
            return EntityDic.ProvinceQuantityDic[year].Select(obj => obj.Value.Clone() as ProvinceQuantity).ToList();
        }

        public static List<BranchQuantity> GetAllBranchQuantities(int year)
        {
            return EntityDic.BranchQuantityDic[year].Select(obj => obj.Value.Clone() as BranchQuantity).ToList();
        }

        public static List<AreaQuantity> GetAllAreaQuantities(int year)
        {
            return EntityDic.AreaQuantityDic[year].Select(obj => obj.Value.Clone() as AreaQuantity).ToList();
        }

        public static List<District> GetAllDistrict()
        {
            return EntityDic.DistrictDic.Select(obj => obj.Value.Clone() as District).ToList();
        }

        public static List<Area> GetAllArea()
        {
            return EntityDic.AreaDic.Select(obj => obj.Value.Clone() as Area).ToList();
        }

        public static List<Branch> GetAllBranch()
        {
            return EntityDic.BranchDic.Select(obj => obj.Value.Clone() as Branch).ToList();
        }

        public static List<Province> GetAllProvince()
        {
            return EntityDic.ProvinceDic.Select(obj => obj.Value.Clone() as Province).ToList();
        }

        public static List<Age> GetAllAge()
        {
            return EntityDic.AgeDic.Select(obj => obj.Value.Clone() as Age).ToList();
        }

        public static List<Sex> GetAllSex()
        {
            return EntityDic.SexDic.Select(obj => obj.Value.Clone() as Sex).ToList();
        }

        public static List<Job> GetAllJob()
        {
            return EntityDic.JobDic.Select(obj => obj.Value.Clone() as Job).ToList();
        }

        #endregion


        #region GetCustom

        public static District GetDistrictByName(string districtName)
        {
            return
                EntityDic.DistrictDic.Values.ToList().
                    Where(p => p.DistrictName.Equals(districtName)).
                    Select(obj => obj.Clone() as District).
                    FirstOrDefault();
        }

        public static List<District> GetDistrictsInProvince(string provinceId)
        {
            return EntityDic.DistrictDic.Values.ToList().
                            Where(p => p.ProvinceId.ToString() == provinceId).
                            Select(obj => obj.Clone() as District).
                            ToList();
        }

        public static List<Province> GetProvincesInBranch(string branchId)
        {
            return EntityDic.ProvinceDic.Values.ToList().
                            Where(p => p.BranchId.ToString() == branchId).
                            Select(obj => obj.Clone() as Province).
                            ToList();
        }

        public static List<Branch> GetBranchesInArea(string areaId)
        {
            return EntityDic.BranchDic.Values.ToList().
                            Where(p => p.AreaId.ToString() == areaId).
                            Select(obj => obj.Clone() as Branch).
                            ToList();
        }

        public static Age GetAgeByAgeStart(string ageStart)
        {
            int ageStartFormat;
            if (Int32.TryParse(ageStart, out ageStartFormat))
            {
                return
                    EntityDic.AgeDic.Values.ToList().
                        Where(p => p.AgeStart == ageStartFormat).
                        Select(obj => obj.Clone() as Age).
                        FirstOrDefault();
            }
            return null;
        }

        public static Sex GetSexBySexName(string sexName)
        {
            return
                EntityDic.SexDic.Values.ToList().
                            Where(p => p.SexName == sexName).
                            Select(obj => obj.Clone() as Sex).
                            FirstOrDefault();

        }

        public static Job GetJobByJobName(string jobName)
        {
            return
                EntityDic.JobDic.Values.ToList().
                                Where(p => p.JobName == jobName).
                                Select(obj => obj.Clone() as Job).
                                FirstOrDefault();

        }

        public static DistrictQuantity GetDistrictQuantityByDoubleKey(int year, DistrictQuantityKeys key)
        {
            if (!EntityDic.DistrictQuantityDic.ContainsKey(year)) return null;
            if (!EntityDic.DistrictQuantityDic[year].ContainsKey(key)) return null;
            return EntityDic.DistrictQuantityDic[year][key].Clone() as DistrictQuantity;
        }

        public static ProvinceQuantity GetProvinceQuantityByDoubleKey(int year, ProvinceQuantityKeys key)
        {
            if (!EntityDic.ProvinceQuantityDic.ContainsKey(year)) return null;
            if (!EntityDic.ProvinceQuantityDic[year].ContainsKey(key)) return null;
            return EntityDic.ProvinceQuantityDic[year][key].Clone() as ProvinceQuantity;
        }

        public static BranchQuantity GetBranchQuantityByDoubleKey(int year, BranchQuantityKeys key)
        {
            if (!EntityDic.BranchQuantityDic.ContainsKey(year)) return null;
            if (!EntityDic.BranchQuantityDic[year].ContainsKey(key)) return null;
            return EntityDic.BranchQuantityDic[year][key].Clone() as BranchQuantity;
        }

        public static long GetCountOfDistrictQuantities(int year)
        {
            return EntityDic.DistrictQuantityDic[year].Sum(obj => obj.Value.Quantity);
        }

        public static long GetCountOfProvinceQuantities(int year)
        {
            return EntityDic.ProvinceQuantityDic[year].Sum(obj => obj.Value.Quantity);
        }

        public static long GetCountOfBranchQuantities(int year)
        {
            return EntityDic.BranchQuantityDic[year].Sum(obj => obj.Value.Quantity);
        }

        public static long GetCountOfAreaQuantities(int year)
        {
            return EntityDic.AreaQuantityDic[year].Sum(obj => obj.Value.Quantity);
        }

        #endregion


        #region Insert

        public static void InsertDistrictQuantity(List<DistrictQuantity> listData)
        {
            foreach (var districtQuantity in listData)
            {
                EntityCollection.DistrictQuantityCollection.Add(districtQuantity);

                //add to memory ram
                if (!EntityDic.DistrictQuantityDic.ContainsKey(districtQuantity.Year))
                {
                    EntityDic.DistrictQuantityDic[districtQuantity.Year] = new Dictionary<DistrictQuantityKeys, DistrictQuantity>();
                }
                var key = new DistrictQuantityKeys
                {
                    DistrictId = districtQuantity.DistrictId,
                    AgeId = districtQuantity.AgeId,
                    JobId = districtQuantity.JobId,
                    SexId = districtQuantity.SexId
                };
                EntityDic.DistrictQuantityDic[districtQuantity.Year][key] = districtQuantity;
            }
        }

        public static void InsertProvinceQuantity(List<ProvinceQuantity> listData)
        {
            foreach (var provinceQuantity in listData)
            {
                EntityCollection.ProvinceQuantityCollection.Add(provinceQuantity);

                //add to memory ram
                if (!EntityDic.ProvinceQuantityDic.ContainsKey(provinceQuantity.Year))
                {
                    EntityDic.ProvinceQuantityDic[provinceQuantity.Year] = new Dictionary<ProvinceQuantityKeys, ProvinceQuantity>();
                }
                var key = new ProvinceQuantityKeys
                {
                    ProvinceId = provinceQuantity.ProvinceId,
                    AgeId = provinceQuantity.AgeId,
                    JobId = provinceQuantity.JobId,
                    SexId = provinceQuantity.SexId
                };
                EntityDic.ProvinceQuantityDic[provinceQuantity.Year][key] = provinceQuantity;
            }
        }

        public static void InsertBranchQuantity(List<BranchQuantity> listData)
        {
            foreach (var branchQuantity in listData)
            {
                EntityCollection.BranchQuantityCollection.Add(branchQuantity);

                //add to memory ram
                if (!EntityDic.BranchQuantityDic.ContainsKey(branchQuantity.Year))
                {
                    EntityDic.BranchQuantityDic[branchQuantity.Year] = new Dictionary<BranchQuantityKeys, BranchQuantity>();
                }
                var key = new BranchQuantityKeys
                {
                    BranchId = branchQuantity.BranchId,
                    AgeId = branchQuantity.AgeId,
                    JobId = branchQuantity.JobId,
                    SexId = branchQuantity.SexId
                };
                EntityDic.BranchQuantityDic[branchQuantity.Year][key] = branchQuantity;
            }
        }

        public static void InsertAreaQuantity(List<AreaQuantity> listData)
        {
            foreach (var areaQuantity in listData)
            {
                EntityCollection.AreaQuantityCollection.Add(areaQuantity);

                //add to memory ram
                if (!EntityDic.AreaQuantityDic.ContainsKey(areaQuantity.Year))
                {
                    EntityDic.AreaQuantityDic[areaQuantity.Year] = new Dictionary<AreaQuantityKeys, AreaQuantity>();
                }
                var key = new AreaQuantityKeys
                {
                    AreaId = areaQuantity.AreaId,
                    AgeId = areaQuantity.AgeId,
                    JobId = areaQuantity.JobId,
                    SexId = areaQuantity.SexId
                };
                EntityDic.AreaQuantityDic[areaQuantity.Year][key] = areaQuantity;
            }
        }

        #endregion


        #region Update

        public static void UpdateDistrictQuantity(List<DistrictQuantity> listData)
        {
            foreach (var districtQuantity in listData)
            {
                EntityCollection.DistrictQuantityCollection.Update(districtQuantity);

                var key = new DistrictQuantityKeys
                {
                    DistrictId = districtQuantity.DistrictId,
                    AgeId = districtQuantity.AgeId,
                    JobId = districtQuantity.JobId,
                    SexId = districtQuantity.SexId
                };
                EntityDic.DistrictQuantityDic[districtQuantity.Year][key] = districtQuantity;
            }
        }

        public static void UpdateProvinceQuantity(List<ProvinceQuantity> listData)
        {
            foreach (var provinceQuantity in listData)
            {
                EntityCollection.ProvinceQuantityCollection.Update(provinceQuantity);

                //update to ram
                var key = new ProvinceQuantityKeys
                {
                    ProvinceId = provinceQuantity.ProvinceId,
                    AgeId = provinceQuantity.AgeId,
                    JobId = provinceQuantity.JobId,
                    SexId = provinceQuantity.SexId
                };
                EntityDic.ProvinceQuantityDic[provinceQuantity.Year][key] = provinceQuantity;
            }
        }

        public static void UpdateBranchQuantity(List<BranchQuantity> listData)
        {
            foreach (var branchQuantity in listData)
            {
                EntityCollection.BranchQuantityCollection.Update(branchQuantity);

                //update to ram
                var key = new BranchQuantityKeys
                {
                    BranchId = branchQuantity.BranchId,
                    AgeId = branchQuantity.AgeId,
                    JobId = branchQuantity.JobId,
                    SexId = branchQuantity.SexId
                };
                EntityDic.BranchQuantityDic[branchQuantity.Year][key] = branchQuantity;
            }
        }

        public static void UpdateAreaQuantity(List<AreaQuantity> listData)
        {
            foreach (var areaQuantity in listData)
            {
                EntityCollection.AreaQuantityCollection.Update(areaQuantity);

                //update to ram
                var key = new AreaQuantityKeys
                {
                    AreaId = areaQuantity.AreaId,
                    AgeId = areaQuantity.AgeId,
                    JobId = areaQuantity.JobId,
                    SexId = areaQuantity.SexId
                };
                EntityDic.AreaQuantityDic[areaQuantity.Year][key] = areaQuantity;
            }
        }

        public static void UpdateMember(List<DistrictQuantity> listDistrictQuantitiesUpdate, List<DistrictQuantity> listDistrictQuantitiesInsert)
        {

            if (listDistrictQuantitiesInsert.Count > 0)
                InsertDistrictQuantity(listDistrictQuantitiesInsert);
            if (listDistrictQuantitiesUpdate.Count > 0)
                UpdateDistrictQuantity(listDistrictQuantitiesUpdate);

            Dictionary<int, bool> listYear = new Dictionary<int, bool>();
            foreach (var districtQuantity in listDistrictQuantitiesInsert)
            {
                if (!listYear.ContainsKey(districtQuantity.Year))
                {
                    listYear[districtQuantity.Year] = true;
                }
            }
            foreach (var districtQuantity in listDistrictQuantitiesUpdate)
            {
                if (!listYear.ContainsKey(districtQuantity.Year))
                {
                    listYear[districtQuantity.Year] = true;
                }
            }

            UpdateProvinceQuantity(listYear.Keys.ToList());

            UpdateBranchQuantity(listYear.Keys.ToList());

            UpdateAreaQuantity(listYear.Keys.ToList());
        }

        public static void UpdateMemberThread(List<DistrictQuantity> listDistrictQuantitiesUpdate, List<DistrictQuantity> listDistrictQuantitiesInsert)
        {
            ThreadStart threadStart = () => MemoryOperator.UpdateMember(listDistrictQuantitiesUpdate, listDistrictQuantitiesInsert);
            Thread thread = new Thread(threadStart);
            thread.Start();
        }

        public static void UpdateProvinceQuantity(List<int> listYear)
        {
            var provinces = GetAllProvince();
            var ages = GetAllAge();
            var sexs = GetAllSex();
            var jobs = GetAllJob();

            foreach (var year in listYear)
            {

                foreach (var province in provinces)
                {
                    var districts = GetDistrictsInProvince(province.Id);

                    foreach (var age in ages)
                    {
                        foreach (var sex in sexs)
                        {
                            foreach (var job in jobs)
                            {
                                long total = 0;

                                foreach (var district in districts)
                                {
                                    var key = new DistrictQuantityKeys
                                    {
                                        DistrictId = district.Id,
                                        AgeId = age.Id,
                                        SexId = sex.Id,
                                        JobId = job.Id
                                    };
                                    var districtQuantity = GetDistrictQuantityByDoubleKey(year, key);
                                    if (districtQuantity != null)
                                    {
                                        total += districtQuantity.Quantity;
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
                                var listInsert = new List<ProvinceQuantity>();
                                var listUpdate = new List<ProvinceQuantity>();
                                var checkProvinceQuantity = CheckExistProvinceQuantity(provinceQuantity);
                                if (checkProvinceQuantity == null)
                                {
                                    if (provinceQuantity.Quantity > 0)
                                        listInsert.Add(provinceQuantity);
                                }
                                else
                                {
                                    provinceQuantity.Id = checkProvinceQuantity.Id;
                                    listUpdate.Add(provinceQuantity);
                                }

                                if (listInsert.Count > 0)
                                {
                                    InsertProvinceQuantity(listInsert);
                                }
                                if (listUpdate.Count > 0)
                                {
                                    UpdateProvinceQuantity(listUpdate);
                                }

                            }
                        }
                    }
                }
            }

        }

        public static void UpdateBranchQuantity(List<int> listYear)
        {
            var branches = GetAllBranch();
            var ages = GetAllAge();
            var sexs = GetAllSex();
            var jobs = GetAllJob();

            foreach (var year in listYear)
            {

                foreach (var branch in branches)
                {
                    var provinces = GetProvincesInBranch(branch.Id);

                    foreach (var age in ages)
                    {
                        foreach (var sex in sexs)
                        {
                            foreach (var job in jobs)
                            {
                                long total = 0;

                                foreach (var province in provinces)
                                {
                                    var key = new ProvinceQuantityKeys
                                    {
                                        ProvinceId = province.Id,
                                        AgeId = age.Id,
                                        SexId = sex.Id,
                                        JobId = job.Id
                                    };
                                    var provinceQuantity = GetProvinceQuantityByDoubleKey(year, key);
                                    if (provinceQuantity != null)
                                    {
                                        total += provinceQuantity.Quantity;
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
                                var listInsert = new List<BranchQuantity>();
                                var listUpdate = new List<BranchQuantity>();
                                var checkBranchQuantity = CheckExistBranchQuantity(branchQuantity);
                                if (checkBranchQuantity == null)
                                {
                                    if (branchQuantity.Quantity > 0)
                                        listInsert.Add(branchQuantity);
                                }
                                else
                                {
                                    branchQuantity.Id = checkBranchQuantity.Id;
                                    listUpdate.Add(branchQuantity);
                                }

                                if (listInsert.Count > 0)
                                {
                                    InsertBranchQuantity(listInsert);
                                }
                                if (listUpdate.Count > 0)
                                {
                                    UpdateBranchQuantity(listUpdate);
                                }

                            }
                        }
                    }
                }
            }

        }

        public static void UpdateAreaQuantity(List<int> listYear)
        {
            var areas = GetAllArea();
            var ages = GetAllAge();
            var sexs = GetAllSex();
            var jobs = GetAllJob();

            foreach (var year in listYear)
            {

                foreach (var area in areas)
                {
                    var branches = GetBranchesInArea(area.Id);

                    foreach (var age in ages)
                    {
                        foreach (var sex in sexs)
                        {
                            foreach (var job in jobs)
                            {
                                long total = 0;

                                foreach (var branch in branches)
                                {
                                    var key = new BranchQuantityKeys
                                    {
                                        BranchId = branch.Id,
                                        AgeId = age.Id,
                                        SexId = sex.Id,
                                        JobId = job.Id
                                    };
                                    var branchQuantity = GetBranchQuantityByDoubleKey(year, key);
                                    if (branchQuantity != null)
                                    {
                                        total += branchQuantity.Quantity;
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
                                var listInsert = new List<AreaQuantity>();
                                var listUpdate = new List<AreaQuantity>();
                                var checkAreaQuantity = CheckExistAreaQuantity(areaQuantity);
                                if (checkAreaQuantity == null)
                                {
                                    if (areaQuantity.Quantity > 0)
                                        listInsert.Add(areaQuantity);
                                }
                                else
                                {
                                    areaQuantity.Id = checkAreaQuantity.Id;
                                    listUpdate.Add(areaQuantity);
                                }

                                if (listInsert.Count > 0)
                                {
                                    InsertAreaQuantity(listInsert);
                                }
                                if (listUpdate.Count > 0)
                                {
                                    UpdateAreaQuantity(listUpdate);
                                }

                            }
                        }
                    }
                }
            }

        }

        #endregion


        #region Check

        public static DistrictQuantity CheckExistDistrictQuantity(DistrictQuantity districtQuantity)
        {
            if (!EntityDic.DistrictQuantityDic.ContainsKey(districtQuantity.Year)) return null;
            DistrictQuantityKeys key = new DistrictQuantityKeys
            {
                DistrictId = districtQuantity.DistrictId,
                AgeId = districtQuantity.AgeId,
                SexId = districtQuantity.SexId,
                JobId = districtQuantity.JobId
            };
            if (EntityDic.DistrictQuantityDic[districtQuantity.Year].ContainsKey(key))
            {
                return EntityDic.DistrictQuantityDic[districtQuantity.Year][key].Clone() as DistrictQuantity;
            }
            return null;
        }


        public static ProvinceQuantity CheckExistProvinceQuantity(ProvinceQuantity provinceQuantity)
        {
            if (!EntityDic.ProvinceQuantityDic.ContainsKey(provinceQuantity.Year)) return null;
            ProvinceQuantityKeys key = new ProvinceQuantityKeys
            {
                ProvinceId = provinceQuantity.ProvinceId,
                AgeId = provinceQuantity.AgeId,
                SexId = provinceQuantity.SexId,
                JobId = provinceQuantity.JobId
            };
            if (EntityDic.ProvinceQuantityDic[provinceQuantity.Year].ContainsKey(key))
            {
                return EntityDic.ProvinceQuantityDic[provinceQuantity.Year][key].Clone() as ProvinceQuantity;
            }
            return null;
        }

        public static BranchQuantity CheckExistBranchQuantity(BranchQuantity branchQuantity)
        {
            if (!EntityDic.BranchQuantityDic.ContainsKey(branchQuantity.Year)) return null;
            BranchQuantityKeys key = new BranchQuantityKeys
            {
                BranchId = branchQuantity.BranchId,
                AgeId = branchQuantity.AgeId,
                SexId = branchQuantity.SexId,
                JobId = branchQuantity.JobId
            };
            if (EntityDic.BranchQuantityDic[branchQuantity.Year].ContainsKey(key))
            {
                return EntityDic.BranchQuantityDic[branchQuantity.Year][key].Clone() as BranchQuantity;
            }
            return null;
        }

        public static AreaQuantity CheckExistAreaQuantity(AreaQuantity areaQuantity)
        {
            if (!EntityDic.AreaQuantityDic.ContainsKey(areaQuantity.Year)) return null;
            AreaQuantityKeys key = new AreaQuantityKeys
            {
                AreaId = areaQuantity.AreaId,
                AgeId = areaQuantity.AgeId,
                SexId = areaQuantity.SexId,
                JobId = areaQuantity.JobId
            };
            if (EntityDic.AreaQuantityDic[areaQuantity.Year].ContainsKey(key))
            {
                return EntityDic.AreaQuantityDic[areaQuantity.Year][key].Clone() as AreaQuantity;
            }
            return null;
        }

        #endregion


    }
}
