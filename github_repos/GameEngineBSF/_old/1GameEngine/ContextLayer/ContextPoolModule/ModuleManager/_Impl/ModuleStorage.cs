using GameEngine.ContextLayer.ContextPoolModule.ContextData;
using GameEngine.ContextLayer.ContextPool.Context;
using System;
using System.Collections.Generic;

namespace GameEngine.ContextLayer.ContextPoolModule.ModuleManager
{
    internal class ModuleStorage : IModuleStorage
    {
        private IModuleFactory moduleFactory;
        private IContextDataReader contextDataReader;
        private IDictionary<Type, IEngineModule> modules;

        public ModuleStorage(IModuleFactory modulefactory, IContextDataReader contextdatareader)
        {
            moduleFactory = modulefactory;
            contextDataReader = contextdatareader;
            modules = new Dictionary<Type, IEngineModule>();
        }

        public T GetModule<T>() where T : IEngineModule
        {
            Type genericType = typeof(T);
            IEngineModule module;
            if(!modules.TryGetValue(genericType, out module))
            {
                module = moduleFactory.Create(genericType, this, contextDataReader);
                modules.Add(genericType, module);
            }
            return (T)module;
        }

        public void FinalizeModule<T>(T enginemodule) where T : IEngineModule
        {
            modules.Remove(typeof(T));
        }

        public void FinalizeAllModules()
        {
            modules.Clear();
        }
    }
}
