using ContextPool;

namespace GodModule
{
    internal interface IContextProvider
    {
        IModuleContext Get(ModuleContextNames contextName);
    }
}