using ContextPool;

namespace GodModule
{
    internal interface IContextFactory
    {
        IModuleContext CreateContext(ModuleContextNames contextName);
    }
}