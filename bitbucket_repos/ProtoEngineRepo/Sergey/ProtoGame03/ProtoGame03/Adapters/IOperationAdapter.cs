using System.Collections.Generic;

namespace ProtoGame03.Adapters
{
    public interface IOperationAdapter
    {
        string Name { get; }
        uint Otid { get; }
        IModelAdapter Parent { get; }
        bool Run(IEnumerable<IModelAdapter> toDo);
    }
}