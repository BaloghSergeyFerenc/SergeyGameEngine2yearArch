using System;
using System.Collections.Generic;

namespace ConfigurationPersistence
{
    internal class PropertyDataReader : IPropertyDataReader
    {
        #region Field
        private IList<Tuple<uint, uint, string>> properties;
        IEnumerator<Tuple<uint, uint, string>> enumerator;
        #endregion Field

        #region Interface
        public bool Next()
        {
            return enumerator.MoveNext();
        }

        public void Read(out uint ownerId, out uint propertyId, out string type_value_callbacks)
        {
            ownerId = enumerator.Current.Item1;
            propertyId = enumerator.Current.Item2;
            type_value_callbacks = enumerator.Current.Item3;
        }
        #endregion Interface

        #region CDIR
        internal PropertyDataReader()
        {
            properties = new List<Tuple<uint, uint, string>>()
            {
                new Tuple<uint, uint, string>(1001, 2001, "1"),
                new Tuple<uint, uint, string>(1001, 2002, "1"),
                new Tuple<uint, uint, string>(1001, 2003, "1"),
                new Tuple<uint, uint, string>(1002, 2004, "1"),
                new Tuple<uint, uint, string>(1002, 2005, "1"),
                new Tuple<uint, uint, string>(1002, 2006, "true"),
                new Tuple<uint, uint, string>(1003, 2007, "Green")
            };
            enumerator = properties.GetEnumerator();
        }
        #endregion CDIR
    }
}