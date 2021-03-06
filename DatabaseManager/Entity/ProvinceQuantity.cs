﻿using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace DatabaseManager.Entity
{
    public class ProvinceQuantity : MongoRepository.Entity, ICloneable
    {


        [JsonProperty(Required = Required.Always)]
        public override string Id { get; set; }



        [JsonProperty(Required = Required.Always)]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProvinceId { get; set; }



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

        public object Clone()
        {
            return MemberwiseClone();
        }


    }
}
