using System;
using System.Collections.Generic;
using System.Text;

namespace PersistenceTopLayer.Model
{
    public interface IModelObject
    {
        uint Tid { get; }
        uint Id { get; }
        uint Parent { get; }
        IList<uint> Children { get; }
        IDictionary<uint, string> Properties { get; }
        IList<uint> Actions { get; }
    }
}
