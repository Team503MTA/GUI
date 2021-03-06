﻿using System;
using MongoDB.Bson;

namespace DatabaseDAL.Entity
{
    public class BranchQuantity : ICloneable
    {

        public enum BranchQuantityFields
        {
            BranchId,
            AgeId,
            SexId,
            JobId,
            Year,
            Quantity
        }

        public ObjectId BranchId { get; set; }

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
