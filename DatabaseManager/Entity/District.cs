﻿using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace DatabaseManager.Entity
{
    public class District : MongoRepository.Entity, ICloneable
    {

        [JsonProperty(Required = Required.Always)]
        public override string Id { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string DistrictName { get; set; }

        [JsonProperty(Required = Required.Always)]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProvinceId { get; set; }


        public object Clone()
        {
            return MemberwiseClone();
        }

    }
}
