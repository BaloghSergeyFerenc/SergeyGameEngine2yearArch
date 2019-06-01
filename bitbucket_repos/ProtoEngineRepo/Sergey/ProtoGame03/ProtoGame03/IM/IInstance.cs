using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoGame03.IM
{
    interface IInstance
    {
        uint Tid { get; }
        uint Id { get; }
        uint Parent { get; }
        IList<uint> RelatedInstances { get; }
        IDictionary<uint, object> Properties { get; }
        IEnumerable<uint> Functions { get; }
    }
}
