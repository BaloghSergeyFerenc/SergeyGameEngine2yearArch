using GameEngine.ContextPool.PersistenceTopLayer.ModelInstanceManager.Facade;
using GameEngine.ContextPool.RealPersistenceLayer.ConfigurationPersistence.Facade;
using GameEngine.PersistenceTopLayer.ConfigurationHandler.Context;

namespace GameEngine.PersistenceTopLayer.ConfigurationHandler.Load
{
    internal class LoadHandler : ILoadHandler
    {
        public void Load(IMfchLocalContextProvider mfchlocalcontextprovider)
        {
            ILoadFacadeOfModelInstanceManager modelAccess = mfchlocalcontextprovider.loadFacadeOfModelInstanceManager;// = MimStaticModule.LMIM;
            IReaderFacadeOfConfigurationPersistence persistenceAccess = mfchlocalcontextprovider.readerFacadeOfConfigurationPersistence;// = CpStaticModule.RCP;

            IDataLoader dataloader = new DataLoader();
            dataloader.ProcessCreationalData(persistenceAccess, modelAccess);
            dataloader.ProcessActionData(persistenceAccess, modelAccess);
            dataloader.ProcessRelationData(persistenceAccess, modelAccess);
            dataloader.ProcessPropertyData(persistenceAccess, modelAccess);
            modelAccess.FinalizeLoading();
        }
    }
}
