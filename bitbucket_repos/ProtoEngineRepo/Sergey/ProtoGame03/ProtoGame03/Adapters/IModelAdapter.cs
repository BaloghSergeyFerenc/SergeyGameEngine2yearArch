using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoGame03.Adapters
{
    public interface IModelAdapter
    {
        uint Tid { get; }
        uint Id { get; }
        IModelAdapter Parent { get; }
        IList<IModelAdapter> RelatedInstances { get; }
        IDictionary<IPropertyAdapter, string> Properties { get; }
        IEnumerable<IOperationAdapter> Functions { get; }
    }
}
