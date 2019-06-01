using PersistenceTopLayer.ModelInstanceManager;
using PersistenceTopLayer.ModelInstanceManager.Facade;
using RealPersistenceLayer.ConfigurationPersistence;
using RealPersistenceLayer.ConfigurationPersistence.Facade;

namespace PersistenceTopLayer.ConfigurationHandler.Load
{
    internal class LoadHandler : ILoadHandler
    {
        public void Load()
        {
            ILoadFacadeOfModelInstanceManager modelAccess = MimStaticModule.LMIM;
            IReaderFacadeOfConfigurationPersistence persistenceAccess = CpStaticModule.RCP;

            modelAccess.Init();
            IDataLoader dataloader = new DataLoader();
            dataloader.ProcessCreationalData(persistenceAccess, modelAccess);
            dataloader.ProcessActionData(persistenceAccess, modelAccess);
            dataloader.ProcessRelationData(persistenceAccess, modelAccess);
            dataloader.ProcessPropertyData(persistenceAccess, modelAccess);
            modelAccess.FinalizeLoading();
        }
    }
}
