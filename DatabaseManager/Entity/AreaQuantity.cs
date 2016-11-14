using MongoDB.Bson;

namespace DatabaseManager.Entity
{
    public class AreaQuantity : MongoRepository.Entity
    {
        public override string Id { get; set; }

        public ObjectId AreaId { get; set; }

        public ObjectId AgeId { get; set; }

        public ObjectId SexId { get; set; }

        public ObjectId JobId { get; set; }

        public int Year { get; set; }

        public long Quantity { get; set; }

    }
}
