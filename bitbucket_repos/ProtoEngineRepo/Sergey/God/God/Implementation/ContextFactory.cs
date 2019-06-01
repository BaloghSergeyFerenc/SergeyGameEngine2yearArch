using ContextPool;
using System;
using System.Collections.Generic;

namespace GodModule
{
    internal class ContextFactory : IContextFactory
    {
        private IContextData contextData;
        private IDictionary<ModuleContextNames, Func<IContextData, IModuleContext>> builders;

        public ContextFactory(IContextData contextData)
        {
            this.contextData = contextData;
            IEnumerator<IModuleContextBuilder> cdEnum = contextData.GetEnumerator();
            while(cdEnum.MoveNext())
            {
                builders.Add(cdEnum.Current.Name, cdEnum.Current.Build);
            }
        }

        public IModuleContext CreateContext(ModuleContextNames contextName)
        {
            return builders[contextName].Invoke(contextData);
            //fix InvalidConfig exception
        }
    }
}