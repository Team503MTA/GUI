﻿namespace DatabaseDAL.Keys
{
    public class AreaQuantityKeys
    {
        #region Properties

        public string AreaId { get; set; }
        public string AgeId { get; set; }
        public string SexId { get; set; }
        public string JobId { get; set; }

        #endregion

        public override int GetHashCode()
        {
            unchecked
            {
                int result = AreaId.GetHashCode();
                result = (result * 397) ^ AgeId.GetHashCode();
                result = (result * 397) ^ SexId.GetHashCode();
                result = (result * 397) ^ JobId.GetHashCode();
                return result;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is AreaQuantityKeys)
            {
                var item = obj as AreaQuantityKeys;
                return AreaId == item.AreaId && AgeId == item.AgeId && SexId == item.SexId && JobId == item.JobId;
            }
            return false;
        }
    }
}
