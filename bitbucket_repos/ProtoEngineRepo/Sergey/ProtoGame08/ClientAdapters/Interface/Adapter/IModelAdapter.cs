using System.Collections.Generic;

namespace ClientAdapters.Interface.Adapter
{
    public interface IModelAdapter
    {
        uint TypeId { get; }
        uint OwnId { get; }
        uint Parent { get; }
        IList<uint> Children { get; }
        IList<IPropertyAdapter> Properties { get; }
        IList<IActionAdapter> Actions { get; }
    }
}