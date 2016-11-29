namespace DatabaseDAL.Keys
{
    public class DistrictQuantityKeys
    {
        #region Properties

        public string DistrictId { get; set; }
        public string AgeId { get; set; }
        public string SexId { get; set; }
        public string JobId { get; set; }

        #endregion

        public override int GetHashCode()
        {
            unchecked
            {
                int result = DistrictId.GetHashCode();
                result = (result * 397) ^ AgeId.GetHashCode();
                result = (result * 397) ^ SexId.GetHashCode();
                result = (result * 397) ^ JobId.GetHashCode();
                return result;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is DistrictQuantityKeys)
            {
                var item = obj as DistrictQuantityKeys;
                return DistrictId == item.DistrictId && AgeId == item.AgeId && SexId == item.SexId && JobId == item.JobId;
            }
            return false;
        }
    }
}
