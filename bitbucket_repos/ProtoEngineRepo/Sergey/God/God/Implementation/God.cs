using ContextPool;

namespace GodModule
{
    internal class God : IContext
    {
        private IContextData contextData;
        private IContextProvider contextProvider;
        private IContextFactory contextFactory;

        public IModuleContext GetContext(ModuleContextNames contextName)
        {
            return contextProvider.Get(contextName);
        }

        internal God(string contextDataString)
        {
            //fix creat ContextData
            contextFactory = new ContextFactory(contextData);
            contextProvider = new ContextProvider(contextFactory);
        }
    }
}
