using DatabaseDAL.Config;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DatabaseDAL.Common
{
    public class Util
    {
        public static IMongoCollection<BsonDocument> GetCollection(string entityName)
        {
            //get host
            string connection = DatabaseConfig.GetHost();

            var client = new MongoClient(connection);

            //get database
            var dbMongo = client.GetDatabase(DatabaseConfig.GetDbName());

            var collection = dbMongo.GetCollection<BsonDocument>(entityName);

            return collection;
        }
    }
}
