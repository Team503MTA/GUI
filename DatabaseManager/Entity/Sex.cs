using System;
using MongoDB.Bson;

namespace DatabaseManager.Entity
{
    public class Sex : MongoRepository.Entity
    {
        public override string Id { get; set; }

        public string SexName { get; set; }
        

    }
}
