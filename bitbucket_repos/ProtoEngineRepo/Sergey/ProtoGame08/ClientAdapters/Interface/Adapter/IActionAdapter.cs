using System.Collections.Generic;

namespace ClientAdapters.Interface.Adapter
{
    public interface IActionAdapter
    {
        uint Id { get; }
        IModelAdapter Owner { get; }
        bool Run(IList<IModelAdapter> effectedModels = null);
    }
}