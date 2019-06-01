using PersistenceTopLayer.ModelInstanceManager.Facade;
using RealPersistenceLayer.ConfigurationPersistence.Facade;

namespace PersistenceTopLayer.ConfigurationHandler.Load
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
