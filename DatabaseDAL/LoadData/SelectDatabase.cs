using System.Collections.Generic;
using DatabaseDAL.Common;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DatabaseDAL.LoadData
{
    public class SelectDatabase
    {
        public static List<BsonDocument> Select(string entityName)
        {
            IMongoCollection<BsonDocument> collection = Util.GetCollection(entityName); 
            return collection.Find(new BsonDocument()).ToList();
        }
    }
}
