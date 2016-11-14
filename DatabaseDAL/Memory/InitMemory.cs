using DatabaseDAL.Entity;
using DatabaseDAL.LoadData;

namespace DatabaseDAL.Memory
{
    public class InitMemory
    {
        public static void Init()
        {
            #region Age

            var listAge = SelectDatabase.Select(new Age().EntityName());
            foreach (var item in listAge)
            {
                Age age = new Age
                {
                    AgeId = item[0].AsObjectId,
                    AgeStart = item[1].AsInt32,
                    AgeEnd = item[2].AsInt32
                };
                SetMemory.Set(age);
            }

            #endregion

            #region Sex

            var listSex = SelectDatabase.Select(new Sex().EntityName());
            foreach (var item in listSex)
            {
                Sex sex = new Sex
                {
                    SexId = item[0].AsObjectId,
                    SexName = item[1].AsString
                };
                SetMemory.Set(sex);
            }

            #endregion

            #region Job

            var listJob = SelectDatabase.Select(new Job().EntityName());
            foreach (var item in listJob)
            {
                Job job = new Job
                {
                    JobId = item[0].AsObjectId,
                    JobName = item[1].AsString
                };
                SetMemory.Set(job);
            }

            #endregion

            #region Area

            var listArea = SelectDatabase.Select(new Area().EntityName());
            foreach (var item in listArea)
            {
                Area area = new Area
                {
                    AreaId = item[0].AsObjectId,
                    AreaName = item[1].AsString
                };
                SetMemory.Set(area);
            }

            #endregion

            #region AreaQuantity

            var listAreaQuantity = SelectDatabase.Select(new AreaQuantity().EntityName());
            foreach (var item in listAreaQuantity)
            {
                AreaQuantity areaQuantity = new AreaQuantity
                {
                    AreaId = item[1].AsObjectId,
                    AgeId = item[2].AsObjectId,
                    SexId = item[3].AsObjectId,
                    JobId = item[4].AsObjectId,
                    Year = item[5].AsInt32,
                    Quantity = item[6].AsInt64
                };
                SetMemory.Set(areaQuantity);
            }

            #endregion

            #region Branch

            var listBranch = SelectDatabase.Select(new Branch().EntityName());
            foreach (var item in listBranch)
            {
                Branch branch = new Branch
                {
                    BranchId = item[0].AsObjectId,
                    BranchName = item[1].AsString,
                    AreaId = item[3].AsObjectId
                };
                SetMemory.Set(branch);
            }

            #endregion

            #region BranchQuantity

            var listBranchQuantity = SelectDatabase.Select(new BranchQuantity().EntityName());
            foreach (var item in listBranchQuantity)
            {
                BranchQuantity branchQuantity = new BranchQuantity
                {
                    BranchId = item[1].AsObjectId,
                    AgeId = item[2].AsObjectId,
                    SexId = item[3].AsObjectId,
                    JobId = item[4].AsObjectId,
                    Year = item[5].AsInt32,
                    Quantity = item[6].AsInt64
                };
                SetMemory.Set(branchQuantity);
            }

            #endregion

            #region Province

            var listProvince = SelectDatabase.Select(new Province().EntityName());
            foreach (var item in listProvince)
            {
                Province province = new Province
                {
                    ProvinceId = item[0].AsObjectId,
                    ProvinceName = item[1].AsString,
                    BranchId = item[3].AsObjectId
                };
                SetMemory.Set(province);
            }

            #endregion

            #region ProvinceQuantity

            var listProvinceQuantity = SelectDatabase.Select(new ProvinceQuantity().EntityName());
            foreach (var item in listProvinceQuantity)
            {
                ProvinceQuantity provinceQuantity = new ProvinceQuantity
                {
                    ProvinceId = item[1].AsObjectId,
                    AgeId = item[2].AsObjectId,
                    SexId = item[3].AsObjectId,
                    JobId = item[4].AsObjectId,
                    Year = item[5].AsInt32,
                    Quantity = item[6].AsInt64
                };
                SetMemory.Set(provinceQuantity);
            }

            #endregion

            #region District

            var listDistrict = SelectDatabase.Select(new District().EntityName());
            foreach (var item in listDistrict)
            {
                District district = new District
                {
                    DistrictId = item[0].AsObjectId,
                    DistrictName = item[1].AsString,
                    ProvinceId = item[3].AsObjectId
                };
                SetMemory.Set(district);
            }

            #endregion

            #region DistrictQuantity

            var listDistrictQuantity = SelectDatabase.Select(new DistrictQuantity().EntityName());
            foreach (var item in listDistrictQuantity)
            {
                DistrictQuantity districtQuantity = new DistrictQuantity
                {
                    DistrictId = item[1].AsObjectId,
                    AgeId = item[2].AsObjectId,
                    SexId = item[3].AsObjectId,
                    JobId = item[4].AsObjectId,
                    Year = item[5].ToInt32(),
                    Quantity = item[6].ToInt64()
                };
                SetMemory.Set(districtQuantity);
            }

            #endregion

        }
    }
}
