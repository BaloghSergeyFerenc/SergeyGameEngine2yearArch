using GameEngine.ContextLayer.ContextPoolModule.ContextData;
using GameEngine.ContextLayer.ContextPoolModule.Enums;
using GameEngine.ContextLayer.ContextPool.Context;
using GameEngine.ContextPool.RealPersistenceLayer.ConfigurationPersistence.Facade;
using GameEngine.RealPersistenceLayer.ConfigurationPersistence.Facade;
using System;
using System.Collections.Generic;
using GameEngine.ContextLayer.ContextPoolModule;
using GameEngine.PersistenceTopLayer.ConfigurationHandler.Facade;
using GameEngine.ContextPool.PersistenceTopLayer.ConfigurationHandler.Facade;
using GameEngine.PersistenceTopLayer.ModelInstanceManager.Facade;
using GameEngine.PersistenceTopLayer.ModelInstanceManager.Model;
using GameEngine.ContextPool.PersistenceTopLayer.ModelInstanceManager.Facade;

namespace GameEngine.ContextLayer.ContextPoolModule.ModuleManager
{
    internal class ModuleFactory : IModuleFactory
    {
        private IDictionary<Type, EEngineModuleType> moduletypes;

        public ModuleFactory()
        {
            moduletypes = new Dictionary<Type, EEngineModuleType>()
            {
                {typeof(IReaderFacadeOfConfigurationPersistence), EEngineModuleType.ConfigurationPersistenceModule },
                {typeof(IMainFacadeOfConfigurationHandler), EEngineModuleType.ConfigurationHandlerModule },
                {typeof(IMainFacadeOfModelInstanceManager), EEngineModuleType.MainModelIntstanceManagerModule },
                {typeof(ILoadFacadeOfModelInstanceManager), EEngineModuleType.LoadModelInstanceManagerModule }
            };
        }

        public IEngineModule Create(Type enginemoduletype, IModuleStorage modulestorage, IContextDataReader contextdatareader)
        {
            EEngineModuleType engineModuleType;
            if(moduletypes.TryGetValue(enginemoduletype, out engineModuleType))
            {
                switch(engineModuleType)
                {
                    case EEngineModuleType.ConfigurationPersistenceModule:
                        return new ReaderFacadeOfConfigurationPersistence(new RfcpLocalContextProvider(modulestorage, contextdatareader));
                    case EEngineModuleType.ConfigurationHandlerModule:
                        return new MainFacadeOfConfigurationHandler(new MfchLocalContextProvider(modulestorage, contextdatareader));
                    case EEngineModuleType.LoadModelInstanceManagerModule:
                        return new LoadFacadeOfModelInstanceManager(new LfmimLocalContextProvider(modulestorage, contextdatareader));
                    case EEngineModuleType.MainModelIntstanceManagerModule:
                        return new MainFacadeOfModelInstanceManager(new MfmimLocalContextProvider(modulestorage, contextdatareader));
                    default:
                        return null;
                }
            }
            return null;
        }
    }
}
