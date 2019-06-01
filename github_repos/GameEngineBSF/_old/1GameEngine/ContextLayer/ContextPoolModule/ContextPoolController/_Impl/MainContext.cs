using System;
using System.Runtime.CompilerServices;
using GameEngine.ContextLayer.ContextPoolModule.ContextData;
using GameEngine.ContextLayer.ContextPoolModule.ModuleManager;
using GameEngine.ContextLayer.ContextPool.Context;

[assembly: InternalsVisibleTo("FakeTestApp")]
namespace GameEngine.ContextLayer.ContextPoolModule.ContextPoolController
{
    internal class MainContext : IMainContext
    {
        private IModuleStorage moduleStorage;
        private IContextDataReader contextDataReader;
        //private IContextProviderManager contextProviderManager;

        public MainContext()
        {
            moduleStorage = new ModuleStorage(new ModuleFactory(), contextDataReader);
            //contextProviderManager = new ContextProviderManager(moduleStorage, contextDataReader);
        }

        public object GetApi()
        {
            throw new NotImplementedException();
        }

        public T GetModule<T>() where T : IEngineModule
        {
            return moduleStorage.GetModule<T>();
        }

        public bool Pause()
        {
            throw new NotImplementedException();
        }

        public bool SetUp(IContextDataContainerForSetUp contextdata)
        {
            //return contextProviderManager.SetUpContext(contextdata);
            throw new NotImplementedException();
        }

        public bool Start()
        {
            throw new NotImplementedException();
        }

        public bool TearDown(out IContextDataContainerForTearDown contextdata)
        {
            //return contextProviderManager.TearDownContext(out contextdata);
            throw new NotImplementedException();
        }
    }
}
