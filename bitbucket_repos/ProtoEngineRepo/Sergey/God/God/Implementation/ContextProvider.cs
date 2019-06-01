using ContextPool;
using System.Collections.Generic;

namespace GodModule
{
    internal class ContextProvider : IContextProvider
    {
        private IContextFactory contextFactory;
        private IDictionary<ModuleContextNames, IModuleContext> moduleContexts;

        public ContextProvider(IContextFactory contextFactory)
        {
            this.contextFactory = contextFactory;
            moduleContexts = new Dictionary<ModuleContextNames, IModuleContext>();
        }

        public IModuleContext Get(ModuleContextNames contextName)
        {
            IModuleContext moduleContext;
            if(!moduleContexts.TryGetValue(contextName, out moduleContext))
            {
                moduleContext = contextFactory.CreateContext(contextName);
                moduleContexts.Add(contextName, moduleContext);
            }
            return moduleContext;
        }
    }
}