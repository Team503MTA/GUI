using System;
using MongoDB.Bson;

namespace DatabaseDAL.Entity
{
    public class Job : ICloneable
    {
        public enum JobFields
        {
            JobId,
            JobName
        }

        public ObjectId JobId { get; set; }

        public string JobName { get; set; }

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
