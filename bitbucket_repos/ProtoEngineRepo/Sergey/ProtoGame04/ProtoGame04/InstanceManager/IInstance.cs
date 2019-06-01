using System.Collections.Generic;

namespace ProtoGame04.InstanceManager
{
    public interface IInstance
    {
        uint Tid { get; }
        uint Id { get; }
        uint Parent { get; }
        IList<uint> Children { get; }
        IDictionary<uint, string> Properties { get; }
        IList<uint> Functions { get; }
    }
}