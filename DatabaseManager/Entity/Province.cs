using System;
using MongoDB.Bson;

namespace DatabaseManager.Entity
{
    public class Province : MongoRepository.Entity
    {

        public override string Id { get; set; }

        public string ProvinceName { get; set; }

        public ObjectId BranchId { get; set; }
        

    }
}
