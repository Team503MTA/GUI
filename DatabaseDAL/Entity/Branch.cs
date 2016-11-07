using System;
using MongoDB.Bson;

namespace DatabaseDAL.Entity
{
    public class Branch : ICloneable
    {
        public enum BranchFields
        {
            BranchId,
            BranchName,
            AreaId
        }

        public ObjectId BranchId { get; set; }

        public string BranchName { get; set; }

        public ObjectId AreaId { get; set; }

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
