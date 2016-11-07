using System;
using MongoDB.Bson;

namespace DatabaseDAL.Entity
{
    public class Area : ICloneable
    {
        public enum AreaFields
        {
            AreaId,
            AreaName
        }

        public ObjectId AreaId { get; set; }

        public string AreaName { get; set; }

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
