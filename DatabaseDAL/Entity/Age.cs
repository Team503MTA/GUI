using System;
using MongoDB.Bson;

namespace DatabaseDAL.Entity
{
    public class Age : ICloneable
    {
        public enum AgeFields
        {
            AgeId,
            AgeStart,
            AgeEnd
        }

        public ObjectId AgeId { get; set; }

        public int AgeStart { get; set; }

        public int AgeEnd { get; set; }

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
