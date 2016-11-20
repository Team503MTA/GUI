using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace DatabaseManager.Entity
{
    public class Branch : MongoRepository.Entity, ICloneable
    {


        [JsonProperty(Required = Required.Always)]
        public override string Id { get; set; }


        [JsonProperty(Required = Required.Always)]
        public string BranchName { get; set; }


        [JsonProperty(Required = Required.Always)]
        [BsonRepresentation(BsonType.ObjectId)]
        public string AreaId { get; set; }


        public object Clone()
        {
            return MemberwiseClone();
        }

    }
}
