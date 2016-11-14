using System;
using MongoDB.Bson;

namespace DatabaseManager.Entity
{
    public class ProvinceQuantity : MongoRepository.Entity
    {
        public override string Id { get; set; }

        public ObjectId ProvinceId { get; set; }

        public ObjectId AgeId { get; set; }

        public ObjectId SexId { get; set; }

        public ObjectId JobId { get; set; }

        public int Year { get; set; }

        public long Quantity { get; set; }
        
    }
}
