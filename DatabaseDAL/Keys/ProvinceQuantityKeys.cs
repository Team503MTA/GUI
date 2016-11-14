using MongoDB.Bson;

namespace DatabaseDAL.Keys
{
    public class ProvinceQuantityKeys
    {
        #region Properties

        public ObjectId ProvinceId { get; set; }
        public ObjectId AgeId { get; set; }
        public ObjectId SexId { get; set; }
        public ObjectId JobId { get; set; }

        #endregion

        public override int GetHashCode()
        {
            unchecked
            {
                int result = ProvinceId.GetHashCode();
                result = (result * 397) ^ AgeId.GetHashCode();
                result = (result * 397) ^ SexId.GetHashCode();
                result = (result * 397) ^ JobId.GetHashCode();
                return result;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is ProvinceQuantityKeys)
            {
                var item = obj as ProvinceQuantityKeys;
                return ProvinceId == item.ProvinceId && AgeId == item.AgeId && SexId == item.SexId && JobId == item.JobId;
            }
            return false;
        }
    }
}
