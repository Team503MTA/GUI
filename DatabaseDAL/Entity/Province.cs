using System;
using MongoDB.Bson;

namespace DatabaseDAL.Entity
{
    public class Province : ICloneable
    {
        public enum ProvinceFields
        {
            ProvinceId,
            ProvinceName,
            BranchId
        }

        public ObjectId ProvinceId { get; set; }

        public string ProvinceName { get; set; }

        public ObjectId BranchId { get; set; }

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
