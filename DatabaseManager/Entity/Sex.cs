using Newtonsoft.Json;

namespace DatabaseManager.Entity
{
    public class Sex : MongoRepository.Entity
    {

        [JsonProperty(Required = Required.Always)]
        public override string Id { get; set; }



        [JsonProperty(Required = Required.Always)]
        public string SexName { get; set; }
        

    }
}
