using ClientAdapters.Interface.Adapter;
using System.Collections.Generic;

namespace ClientAdapters.Interface
{
    public interface IAdapterProvider
    {
        IList<uint> AvaibleAdapters { get; }
        IModelAdapter Get(uint id);
        bool Update(IModelAdapter adapter);
    }
}