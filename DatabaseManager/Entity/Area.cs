using MongoDB.Bson;

namespace DatabaseManager.Entity
{
    public class Area : MongoRepository.Entity
    {

        public override string Id { get; set; }

        public string AreaName { get; set; }
        

    }
}
