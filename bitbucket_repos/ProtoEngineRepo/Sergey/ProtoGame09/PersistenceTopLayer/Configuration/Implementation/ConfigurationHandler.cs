using PersistenceTopLayer.Model;

namespace PersistenceTopLayer.Configuration
{
    internal class ConfigurationHandler : IConfigurationHandler
    {
        public IModelFacade Load()
        {
            IConfigurationLoader configurationLoader = new ConfigurationLoader();
            configurationLoader.Load();
            return configurationLoader.CreatedModel;
        }

        public void Save(IModelFacade modelFacade)
        {
            //fix
        }
    }
}
