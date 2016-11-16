using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace DatabaseManager.Entity
{
    public class AreaQuantity : MongoRepository.Entity
    {

        [JsonProperty(Required = Required.Always)]
        public override string Id { get; set; }


        [JsonProperty(Required = Required.Always)]
        [BsonRepresentation(BsonType.ObjectId)]
        public string AreaId { get; set; }


        [JsonProperty(Required = Required.Always)]
        [BsonRepresentation(BsonType.ObjectId)]
        public string AgeId { get; set; }


        [JsonProperty(Required = Required.Always)]
        [BsonRepresentation(BsonType.ObjectId)]
        public string SexId { get; set; }


        [JsonProperty(Required = Required.Always)]
        [BsonRepresentation(BsonType.ObjectId)]
        public string JobId { get; set; }


        [JsonProperty(Required = Required.Always)]
        public int Year { get; set; }


        [JsonProperty(Required = Required.Always)]
        public long Quantity { get; set; }

    }
}
