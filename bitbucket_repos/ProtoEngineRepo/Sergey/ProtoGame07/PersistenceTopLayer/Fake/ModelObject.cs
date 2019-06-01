using PersistenceTopLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersistenceTopLayer.Fake
{
    class ModelObject : IModelObject
    {
        public uint Tid => throw new NotImplementedException();

        public uint Id => throw new NotImplementedException();

        public uint Parent => throw new NotImplementedException();

        public IList<uint> Children => throw new NotImplementedException();

        public IDictionary<uint, string> Properties => throw new NotImplementedException();

        public IList<uint> Actions => throw new NotImplementedException();
    }
}
