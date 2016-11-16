using Newtonsoft.Json;

namespace DatabaseManager.Entity
{
    public class Age : MongoRepository.Entity
    {

        [JsonProperty(Required = Required.Always)]
        public override string Id { get; set; }

        [JsonProperty(Required = Required.Always)]
        public int AgeStart { get; set; }

        [JsonProperty(Required = Required.Always)]
        public int AgeEnd { get; set; }

    }
}
