using DatabaseDAL.Entity;
using MongoDB.Bson;

namespace DatabaseDAL.Common
{
    public class BsonCustom
    {

        public BsonDocument GetBson(Age age)
        {
            return new BsonDocument
            {
                { Age.AgeFields.AgeId.ToString(),age.AgeId},

                { Age.AgeFields.AgeStart.ToString(),age.AgeStart},

                { Age.AgeFields.AgeEnd.ToString(),age.AgeEnd}
            };
        }

        public BsonDocument GetBson(Sex sex)
        {
            return new BsonDocument
            {
                { Sex.SexFields.SexId.ToString(),sex.SexId},

                { Sex.SexFields.SexName.ToString(),sex.SexName}
            };
        }

        public BsonDocument GetBson(Job job)
        {
            return new BsonDocument
            {
                { Job.JobFields.JobId.ToString(),job.JobId},
                { Job.JobFields.JobName.ToString(),job.JobName}
            };
        }

        public BsonDocument GetBson(Area area)
        {
            return new BsonDocument
            {
                { Area.AreaFields.AreaId.ToString(),area.AreaId},
                { Area.AreaFields.AreaName.ToString(),area.AreaName}
            };
        }

        public BsonDocument GetBson(Branch branch)
        {
            return new BsonDocument
            {
                { Branch.BranchFields.BranchId.ToString(),branch.BranchId},

                { Branch.BranchFields.BranchName.ToString(),branch.BranchName},

                { Branch.BranchFields.AreaId.ToString(),branch.AreaId}
            };
        }

        public BsonDocument GetBson(Province province)
        {
            return new BsonDocument
            {
                { Province.ProvinceFields.ProvinceId.ToString(),province.ProvinceId},

                { Province.ProvinceFields.ProvinceName.ToString(),province.ProvinceName},

                { Province.ProvinceFields.BranchId.ToString(),province.BranchId}
            };
        }

        public BsonDocument GetBson(District district)
        {
            return new BsonDocument
            {
                { District.DistrictFields.DistrictId.ToString(),district.DistrictId},

                { District.DistrictFields.DistrictName.ToString(),district.DistrictName},

                { District.DistrictFields.ProvinceId.ToString(),district.ProvinceId}
            };
        }

        public BsonDocument GetBson(AreaQuantity areaQuantity)
        {
            return new BsonDocument
            {
                { AreaQuantity.AreaQuantityFields.AreaId.ToString(),areaQuantity.AreaId},

                { AreaQuantity.AreaQuantityFields.AgeId.ToString(),areaQuantity.AgeId},

                { AreaQuantity.AreaQuantityFields.SexId.ToString(),areaQuantity.SexId},

                { AreaQuantity.AreaQuantityFields.JobId.ToString(),areaQuantity.JobId},

                { AreaQuantity.AreaQuantityFields.Year.ToString(),areaQuantity.Year},

                { AreaQuantity.AreaQuantityFields.Quantity.ToString(),areaQuantity.Quantity}
            };
        }

        public BsonDocument GetBson(BranchQuantity branchQuantity)
        {
            return new BsonDocument
            {
                { BranchQuantity.BranchQuantityFields.BranchId.ToString(),branchQuantity.BranchId},

                { BranchQuantity.BranchQuantityFields.AgeId.ToString(),branchQuantity.AgeId},

                { BranchQuantity.BranchQuantityFields.SexId.ToString(),branchQuantity.SexId},

                { BranchQuantity.BranchQuantityFields.JobId.ToString(),branchQuantity.JobId},

                { BranchQuantity.BranchQuantityFields.Year.ToString(),branchQuantity.Year},

                { BranchQuantity.BranchQuantityFields.Quantity.ToString(),branchQuantity.Quantity}
            };
        }

        public BsonDocument GetBson(ProvinceQuantity provinceQuantity)
        {
            return new BsonDocument
            {
                { ProvinceQuantity.ProvinceQuantityFields.ProvinceId.ToString(),provinceQuantity.ProvinceId},

                { ProvinceQuantity.ProvinceQuantityFields.AgeId.ToString(),provinceQuantity.AgeId},

                { ProvinceQuantity.ProvinceQuantityFields.SexId.ToString(),provinceQuantity.SexId},

                { ProvinceQuantity.ProvinceQuantityFields.JobId.ToString(),provinceQuantity.JobId},

                { ProvinceQuantity.ProvinceQuantityFields.Year.ToString(),provinceQuantity.Year},

                { ProvinceQuantity.ProvinceQuantityFields.Quantity.ToString(),provinceQuantity.Quantity}
            };
        }

        public BsonDocument GetBson(DistrictQuantity districtQuantity)
        {
            return new BsonDocument
            {
                { DistrictQuantity.DistrictQuantityFields.DistrictId.ToString(),districtQuantity.DistrictId},

                { DistrictQuantity.DistrictQuantityFields.AgeId.ToString(),districtQuantity.AgeId},

                { DistrictQuantity.DistrictQuantityFields.SexId.ToString(),districtQuantity.SexId},

                { DistrictQuantity.DistrictQuantityFields.JobId.ToString(),districtQuantity.JobId},

                { DistrictQuantity.DistrictQuantityFields.Year.ToString(),districtQuantity.Year},

                { DistrictQuantity.DistrictQuantityFields.Quantity.ToString(),districtQuantity.Quantity}
            };
        }

    }
}
