using System.Collections.Generic;

namespace ConfigurationPersistence
{
    internal class ParentRelationDataReader : IParentRelationReader
    {
        #region Field
        private IDictionary<uint, uint> parentRelations;
        private IEnumerator<KeyValuePair<uint, uint>> enumarator;
        #endregion Field

        #region Interface
        public bool Next()
        {
            return enumarator.MoveNext();
        }

        public void Read(out uint childId, out uint parentId)
        {
            childId = enumarator.Current.Key;
            parentId = enumarator.Current.Value;
        }
        #endregion Interface

        #region CDIR
        internal ParentRelationDataReader()
        {
            parentRelations = new Dictionary<uint, uint>()
            {
                {1001, 0},
                {1002, 1001},
                {1003, 1002}
            };
            enumarator = parentRelations.GetEnumerator();
        }
        #endregion CDIR
    }
}