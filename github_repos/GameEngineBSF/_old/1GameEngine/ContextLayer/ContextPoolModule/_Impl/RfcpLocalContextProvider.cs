using GameEngine.ContextLayer.ContextPoolModule.ContextData;
using GameEngine.ContextLayer.ContextPool.Context;
using GameEngine.RealPersistenceLayer.ConfigurationPersistence.Context;
using System;
using GameEngine.ContextLayer.ContextPoolModule.ModuleManager;

namespace GameEngine.ContextLayer.ContextPoolModule
{
    internal class RfcpLocalContextProvider : IRfcpLocalContextProvider
    {
        private IModuleStorage moduleStorage;
        private IContextDataReader contextDataReader;

        private IDataBaseLocalContext dataBaseLocalContext;

        public RfcpLocalContextProvider(IModuleStorage modulestorage, IContextDataReader contextdatareader)
        {
            moduleStorage = modulestorage;
            contextDataReader = contextdatareader;
        }

        public IDataBaseLocalContext Get
        {
            get
            {
                if (dataBaseLocalContext == null)
                {
                    dataBaseLocalContext = new DataBaseLocalContext();
                }
                return dataBaseLocalContext;
            }
        }
    }
}
