namespace DatabaseDAL.Keys
{
    public class BranchQuantityKeys
    {
        #region Properties

        public string BranchId { get; set; }
        public string AgeId { get; set; }
        public string SexId { get; set; }
        public string JobId { get; set; }

        #endregion

        public override int GetHashCode()
        {
            unchecked
            {
                int result = BranchId.GetHashCode();
                result = (result * 397) ^ AgeId.GetHashCode();
                result = (result * 397) ^ SexId.GetHashCode();
                result = (result * 397) ^ JobId.GetHashCode();
                return result;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is BranchQuantityKeys)
            {
                var item = obj as BranchQuantityKeys;
                return BranchId == item.BranchId && AgeId == item.AgeId && SexId == item.SexId && JobId == item.JobId;
            }
            return false;
        }
    }
}
