using System.Collections.Generic;

namespace ClientAdapters.Interface.Adapter
{
    public interface IPropertyAdapter
    {
        uint Id { get; }
        IModelAdapter Owner { get; }
        IList<uint> AdapterOperations { get; }
        IValue AdapterValue { get; }
        bool InvokeAdapterOperation(uint AdapterOperation, IValue value = null);
    }
}