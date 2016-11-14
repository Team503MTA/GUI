using System;
using MongoDB.Bson;

namespace DatabaseManager.Entity
{
    public class District : MongoRepository.Entity
    {
        public override string Id { get; set; }

        public string DistrictName { get; set; }

        public ObjectId ProvinceId { get; set; }
        

    }
}
