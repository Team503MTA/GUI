using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace DatabaseManager.Entity
{
    public class Province : MongoRepository.Entity
    {



        [JsonProperty(Required = Required.Always)]
        public override string Id { get; set; }



        [JsonProperty(Required = Required.Always)]
        public string ProvinceName { get; set; }



        [JsonProperty(Required = Required.Always)]
        [BsonRepresentation(BsonType.ObjectId)]
        public string BranchId { get; set; }
        

    }
}
