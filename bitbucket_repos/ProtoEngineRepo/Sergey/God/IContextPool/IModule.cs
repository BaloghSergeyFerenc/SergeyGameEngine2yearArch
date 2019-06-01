using System.Collections.Generic;

namespace ContextPool
{
    public interface IModule : IEnumerator<ModuleContextNames>
    {
        IContext ContextPool { get; }
    }
}
