namespace DatabaseManager.Entity
{
    public class Age : MongoRepository.Entity
    {

        public override string Id { get; set; }

        public int AgeStart { get; set; }

        public int AgeEnd { get; set; }

    }
}
