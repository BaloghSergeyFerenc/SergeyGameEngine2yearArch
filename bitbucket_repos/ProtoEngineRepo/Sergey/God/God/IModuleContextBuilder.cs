using ContextPool;

namespace GodModule
{
    internal interface IModuleContextBuilder
    {
        ModuleContextNames Name { get; }
        IModuleContext Build(IContextData contextData);
    }
}