using ProtoGame03.Adapters;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoGame03.OR
{
    class ModelAdapter : IModelAdapter
    {
        public uint Tid { get; private set; }
        public uint Id { get; private set; }
        public IModelAdapter Parent { get; private set; }
        public IEnumerable<IModelAdapter> RelatedInstances { get; private set; }
        public IDictionary<IPropertyAdapter, string> Properties { get; private set; }
        public IEnumerable<IOperationAdapter> Functions { get; private set; }
        public ModelAdapter(uint tid, uint id, IModelAdapter parent)
        {
            Tid = tid;
            Id = id;
            Parent = parent;
        }
    }
}
