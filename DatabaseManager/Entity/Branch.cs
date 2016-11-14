using System;
using MongoDB.Bson;

namespace DatabaseManager.Entity
{
    public class Branch : MongoRepository.Entity
    {

        public override string Id { get; set; }

        public string BranchName { get; set; }

        public ObjectId AreaId { get; set; }


    }
}
