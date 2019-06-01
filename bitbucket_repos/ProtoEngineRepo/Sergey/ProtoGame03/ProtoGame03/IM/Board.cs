using System;
using System.Collections.Generic;
using System.Text;


namespace ProtoGame03.IM
{
    class Board : IInstance
    {
        public uint Tid => throw new NotImplementedException();

        public uint Id => throw new NotImplementedException();

        public uint Parent => throw new NotImplementedException();

        public IEnumerable<uint> RelatedInstances => throw new NotImplementedException();

        public IDictionary<uint, object> Properties => throw new NotImplementedException();

        public IEnumerable<uint> Functions => throw new NotImplementedException();
    }
}
