using System;
using MongoDB.Bson;

namespace DatabaseDAL.Entity
{
    public class Sex : ICloneable
    {
        public enum SexFields
        {
            SexId,
            SexName
        }

        public ObjectId SexId { get; set; }

        public string SexName { get; set; }

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
