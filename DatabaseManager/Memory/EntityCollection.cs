using DatabaseManager.Entity;
using MongoRepository;

namespace DatabaseManager.Memory
{
    class EntityCollection
    {
        public static MongoRepository<Age> AgeCollection = new MongoRepository<Age>();

        public static MongoRepository<Sex> SexCollection = new MongoRepository<Sex>();

        public static MongoRepository<Job> JobCollection = new MongoRepository<Job>();

        public static MongoRepository<Area> AreaCollection = new MongoRepository<Area>();

        public static MongoRepository<AreaQuantity> AreaQuantityCollection = new MongoRepository<AreaQuantity>();

        public static MongoRepository<Branch> BranchCollection = new MongoRepository<Branch>();

        public static MongoRepository<BranchQuantity> BranchQuantityCollection = new MongoRepository<BranchQuantity>();

        public static MongoRepository<Province> ProvinceCollection = new MongoRepository<Province>();

        public static MongoRepository<ProvinceQuantity> ProvinceQuantityCollection = new MongoRepository<ProvinceQuantity>();

        public static MongoRepository<District> DistrictCollection = new MongoRepository<District>();

        public static MongoRepository<DistrictQuantity> DistrictQuantityCollection = new MongoRepository<DistrictQuantity>();
    }
}
