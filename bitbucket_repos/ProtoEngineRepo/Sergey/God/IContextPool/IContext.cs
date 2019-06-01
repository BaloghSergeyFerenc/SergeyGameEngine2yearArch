namespace ContextPool
{
    public interface IContext
    {
        IModuleContext GetContext(ModuleContextNames contextName);
    }
}
