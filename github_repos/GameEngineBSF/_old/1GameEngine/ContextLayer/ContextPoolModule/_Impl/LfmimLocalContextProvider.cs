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
    class LfmimLocalContextProvider : ILfmimLocalContextProvider
    {
        private IModuleStorage moduleStorage = null;
        private IContextDataReader contextDataReader = null;
        private IModelManager modelManager = null;
        private IPropertyFactory propertyFactory = null;

        public IMainFacadeOfModelInstanceManager GetMainFacadeOfModelInstanceManager
        {
            get
            {
                return moduleStorage.GetModule<IMainFacadeOfModelInstanceManager>();
            }
        }

        public IModelManager GetModelManager
        {
            get
            {
                if (modelManager == null)
                {
                    modelManager = new ModelManager();
                }
                return modelManager;
            }
        }

        public IPropertyFactory GetPropertyFactory
        {
            get
            {
                if (propertyFactory == null)
                {
                    propertyFactory = new PropertyFactory();
                }
                return propertyFactory;
            }
        }

        public LfmimLocalContextProvider(IModuleStorage modulestorage, IContextDataReader contextdatareader)
        {
            moduleStorage = modulestorage;
            contextDataReader = contextdatareader;
        }
    }
}
