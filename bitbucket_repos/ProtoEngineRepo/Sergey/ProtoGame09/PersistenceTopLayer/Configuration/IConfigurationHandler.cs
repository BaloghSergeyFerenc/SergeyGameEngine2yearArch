using PersistenceTopLayer.Model;

namespace PersistenceTopLayer.Configuration
{
    interface IConfigurationHandler
    {
        IModelFacade Load();
        void Save(IModelFacade modelFacade);
    }
}
