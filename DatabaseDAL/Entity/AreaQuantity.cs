using System;
using MongoDB.Bson;

namespace DatabaseDAL.Entity
{
    public class AreaQuantity : ICloneable
    {
        public enum AreaQuantityFields
        {
            AreaId,
            AgeId,
            SexId,
            JobId,
            Year,
            Quantity
        }

        public ObjectId AreaId { get; set; }

        public ObjectId AgeId { get; set; }

        public ObjectId SexId { get; set; }

        public ObjectId JobId { get; set; }

        public int Year { get; set; }

        public long Quantity { get; set; }

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
