using System;
using System.Collections.Generic;

namespace ConfigurationPersistence
{
    internal class ActionDataReader : IActionDataReader
    {
        #region Field
        private IList<Tuple<uint, uint>> actionsOfModels;
        IEnumerator<Tuple<uint, uint>> enumerator;
        #endregion Field

        #region Interface
        public bool Next()
        {
            return enumerator.MoveNext();
        }

        public void Read(out uint ownerId, out uint actionId)
        {
            ownerId = enumerator.Current.Item1;
            actionId = enumerator.Current.Item2;
        }
        #endregion Interface

        #region CDIR
        internal ActionDataReader()
        {
            actionsOfModels = new List<Tuple<uint, uint>>()
            {
                new Tuple<uint, uint>(1001, 3001),
                new Tuple<uint, uint>(1002, 3001),
                new Tuple<uint, uint>(1003, 3001),
                new Tuple<uint, uint>(1003, 3002)
            };
            enumerator = actionsOfModels.GetEnumerator();
        }
        #endregion CDIR
    }
}