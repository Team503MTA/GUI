using Newtonsoft.Json;

namespace DatabaseManager.CustomObject
{
    public class DistrictQuantityExcel
    {

        [JsonProperty(Required = Required.Always)]
        public string Name { get; set; }


        [JsonProperty(Required = Required.Always)]
        public string Age { get; set; }


        [JsonProperty(Required = Required.Always)]
        public string Sex { get; set; }


        [JsonProperty(Required = Required.Always)]
        public string Job { get; set; }


        [JsonProperty(Required = Required.Always)]
        public string Quantity { get; set; }


        [JsonProperty(Required = Required.Always)]
        public string Year { get; set; }
    }
}
