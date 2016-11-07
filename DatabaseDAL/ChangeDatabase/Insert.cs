using System.Collections.Generic;
using DatabaseDAL.Common;
using DatabaseDAL.Entity;
using DatabaseDAL.Memory;
using MongoDB.Bson;
using MongoDB.Driver;
using Population.Models.Entity;

namespace DatabaseDAL.ChangeDatabase
{
    public class Insert
    {
        readonly BsonCustom _bsonCustom;

        public Insert(BsonCustom bsonCustom)
        {
            _bsonCustom = bsonCustom;
        }

        public bool Area(List<Area> listArea)
        {
            IMongoCollection<BsonDocument> collection = Util.GetCollection(typeof (Area).Name);

            List<BsonDocument> listAreaBson = new List<BsonDocument>();

            foreach (var area in listArea)
            {
                listAreaBson.Add(_bsonCustom.GetBson(area));

                if (listAreaBson.Count >= 500)
                {
                    //update database
                    collection.InsertMany(listAreaBson);
                }

                //update memory
                SetMemory.Set(area);
            }

            collection.InsertMany(listAreaBson);

            return true;
        }

        public bool Branch(List<Branch> listBranch)
        {
            IMongoCollection<BsonDocument> collection = Util.GetCollection(typeof(Branch).Name);

            List<BsonDocument> listBranchBson = new List<BsonDocument>();

            foreach (var branch in listBranch)
            {
                listBranchBson.Add(_bsonCustom.GetBson(branch));

                if (listBranchBson.Count >= 500)
                {
                    //update database
                    collection.InsertMany(listBranchBson);
                }

                //update memory
                SetMemory.Set(branch);
            }

            collection.InsertMany(listBranchBson);

            return true;
        }

        public bool Province(List<Province> listProvince)
        {
            IMongoCollection<BsonDocument> collection = Util.GetCollection(typeof(Province).Name);

            List<BsonDocument> listProvinceBson = new List<BsonDocument>();

            foreach (var province in listProvince)
            {
                listProvinceBson.Add(_bsonCustom.GetBson(province));

                if (listProvinceBson.Count >= 500)
                {
                    //update database
                    collection.InsertMany(listProvinceBson);
                }

                //update memory
                SetMemory.Set(province);
            }

            collection.InsertMany(listProvinceBson);

            return true;
        }

        public bool District(List<District> listDistrict)
        {
            IMongoCollection<BsonDocument> collection = Util.GetCollection(typeof(District).Name);

            List<BsonDocument> listDistrictBson = new List<BsonDocument>();

            foreach (var district in listDistrict)
            {
                listDistrictBson.Add(_bsonCustom.GetBson(district));

                if (listDistrictBson.Count >= 500)
                {
                    //update database
                    collection.InsertMany(listDistrictBson);
                }

                //update memory
                SetMemory.Set(district);
            }

            collection.InsertMany(listDistrictBson);

            return true;
        }


        public bool Age(List<Age> listAge)
        {
            IMongoCollection<BsonDocument> collection = Util.GetCollection(typeof(Age).Name);

            List<BsonDocument> listAgeBson = new List<BsonDocument>();

            foreach (var age in listAge)
            {
                listAgeBson.Add(_bsonCustom.GetBson(age));

                if (listAgeBson.Count >= 500)
                {
                    //update database
                    collection.InsertMany(listAgeBson);
                }

                //update memory
                SetMemory.Set(age);
            }

            collection.InsertMany(listAgeBson);

            return true;
        }

        public bool Sex(List<Sex> listSex)
        {
            IMongoCollection<BsonDocument> collection = Util.GetCollection(typeof(Sex).Name);

            List<BsonDocument> listSexBson = new List<BsonDocument>();

            foreach (var sex in listSex)
            {
                listSexBson.Add(_bsonCustom.GetBson(sex));

                if (listSexBson.Count >= 500)
                {
                    //update database
                    collection.InsertMany(listSexBson);
                }

                //update memory
                SetMemory.Set(sex);
            }

            collection.InsertMany(listSexBson);

            return true;
        }

        public bool Job(List<Job> listJob)
        {
            IMongoCollection<BsonDocument> collection = Util.GetCollection(typeof(Job).Name);

            List<BsonDocument> listJobBson = new List<BsonDocument>();

            foreach (var job in listJob)
            {
                listJobBson.Add(_bsonCustom.GetBson(job));

                if (listJobBson.Count >= 500)
                {
                    //update database
                    collection.InsertMany(listJobBson);
                }

                //update memory
                SetMemory.Set(job);
            }

            collection.InsertMany(listJobBson);

            return true;
        }

    }
}
