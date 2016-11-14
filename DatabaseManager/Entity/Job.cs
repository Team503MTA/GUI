using System;
using MongoDB.Bson;

namespace DatabaseManager.Entity
{
    public class Job : MongoRepository.Entity
    {
        public override string Id { get; set; }

        public string JobName { get; set; }
        

    }
}
