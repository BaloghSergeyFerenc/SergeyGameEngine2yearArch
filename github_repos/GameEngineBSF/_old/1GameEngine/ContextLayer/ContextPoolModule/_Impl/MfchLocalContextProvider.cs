using GameEngine.ContextLayer.ContextPoolModule.ContextData;
using GameEngine.ContextLayer.ContextPoolModule.ModuleManager;
using GameEngine.ContextPool.PersistenceTopLayer.ModelInstanceManager.Facade;
using GameEngine.ContextPool.RealPersistenceLayer.ConfigurationPersistence.Facade;
using GameEngine.PersistenceTopLayer.ConfigurationHandler.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine.ContextLayer.ContextPoolModule
{
    class MfchLocalContextProvider : IMfchLocalContextProvider
    {
        public IReaderFacadeOfConfigurationPersistence readerFacadeOfConfigurationPersistence { get; }

        public ILoadFacadeOfModelInstanceManager loadFacadeOfModelInstanceManager { get; }

        public MfchLocalContextProvider(IModuleStorage modulestorage, IContextDataReader contextdatareader)
        {
            readerFacadeOfConfigurationPersistence = modulestorage.GetModule<IReaderFacadeOfConfigurationPersistence>();
            loadFacadeOfModelInstanceManager = modulestorage.GetModule<ILoadFacadeOfModelInstanceManager>();
        }
    }
}
