using GameEngine.ContextLayer.ContextPoolModule.ContextData;
using GameEngine.ContextLayer.ContextPoolModule.ModuleManager;
using GameEngine.ContextPool.PersistenceTopLayer.ModelInstanceManager.Facade;
using GameEngine.PersistenceTopLayer.ModelInstanceManager.Context;
using GameEngine.PersistenceTopLayer.ModelInstanceManager.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine.ContextLayer.ContextPoolModule
{
    class MfmimLocalContextProvider : IMfmimLocalContextProvider
    {
        private IModuleStorage moduleStorage;
        private IContextDataReader contextDataReader;
        private IModelManager modelManager = null;
        private IPropertyFactory propertyFactory = null;

        public MfmimLocalContextProvider(IModuleStorage modulestorage, IContextDataReader contextdatareader)
        {
            moduleStorage = modulestorage;
            contextDataReader = contextdatareader;
        }

        public IModelManager GetModelManager
        {
            get
            {
                return moduleStorage.GetModule<ILoadFacadeOfModelInstanceManager>().GetLocalContextPovider<ILfmimLocalContextProvider>().GetModelManager;
            }
        }

        public IPropertyFactory GetPropertyFactory
        {
            get
            {
                return moduleStorage.GetModule<ILoadFacadeOfModelInstanceManager>().GetLocalContextPovider<ILfmimLocalContextProvider>().GetPropertyFactory;
            }
        }
    }
}
