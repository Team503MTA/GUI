using System;
using MongoDB.Bson;

namespace DatabaseDAL.Entity
{
    public class District : ICloneable
    {
        public enum DistrictFields
        {
            DistrictId,
            DistrictName,
            ProvinceId
        }

        public ObjectId DistrictId { get; set; }

        public string DistrictName { get; set; }

        public ObjectId ProvinceId { get; set; }

        public string EntityName()
        {
            return GetType().Name;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

    }
}
