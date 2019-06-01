using PersistenceTopLayer.Model;

namespace PersistenceTopLayer.Configuration
{
    interface IConfigurationLoader
    {
        IModelFacade CreatedModel { get; }
        void Load();
    }
}
