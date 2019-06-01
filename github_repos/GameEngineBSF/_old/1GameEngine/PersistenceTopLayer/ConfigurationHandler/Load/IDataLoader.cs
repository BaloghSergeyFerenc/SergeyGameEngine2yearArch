using GameEngine.ContextPool.PersistenceTopLayer.ModelInstanceManager.Facade;
using GameEngine.ContextPool.RealPersistenceLayer.ConfigurationPersistence.Facade;

namespace GameEngine.PersistenceTopLayer.ConfigurationHandler.Load
{
    internal interface IDataLoader
    {
        void ProcessCreationalData(
            IReaderFacadeOfConfigurationPersistence persistenceaccess,
            ILoadFacadeOfModelInstanceManager modelaccess);
        void ProcessActionData(
            IReaderFacadeOfConfigurationPersistence persistenceaccess,
            ILoadFacadeOfModelInstanceManager modelaccess);
        void ProcessRelationData(
            IReaderFacadeOfConfigurationPersistence persistenceaccess,
            ILoadFacadeOfModelInstanceManager modelaccess);
        void ProcessPropertyData(
            IReaderFacadeOfConfigurationPersistence persistenceaccess,
            ILoadFacadeOfModelInstanceManager modelaccess);
    }
}
