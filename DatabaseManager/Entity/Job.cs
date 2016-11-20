using System;
using Newtonsoft.Json;

namespace DatabaseManager.Entity
{
    public class Job : MongoRepository.Entity, ICloneable
    {


        [JsonProperty(Required = Required.Always)]
        public override string Id { get; set; }


        [JsonProperty(Required = Required.Always)]
        public string JobName { get; set; }


        public object Clone()
        {
            return MemberwiseClone();
        }

    }
}
