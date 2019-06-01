using System.Collections.Generic;

namespace ConfigurationPersistence
{
    internal class ModelObjectDataReader : IModelObjectDataReader
    {
        #region Filed
        private IDictionary<uint, uint> modelIdTid;
        private IEnumerator<KeyValuePair<uint, uint>> enumarator;
        #endregion Field

        #region Interface
        public bool Next()
        {
            return enumarator.MoveNext();
        }

        public void Read(out uint id, out uint tid)
        {
            id = enumarator.Current.Key;
            tid = enumarator.Current.Value;
        }
        #endregion Interface

        #region CDI
        internal ModelObjectDataReader()
        {
            modelIdTid = new Dictionary<uint, uint>()
            {
                {1001, 1},
                {1002, 2},
                {1003, 3}
            };
            enumarator = modelIdTid.GetEnumerator();
        }
        #endregion CDI
    }
}