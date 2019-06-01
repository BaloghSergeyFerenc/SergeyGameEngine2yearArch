using PersistenceTopLayer.ConfigurationHandler.Load;

namespace PersistenceTopLayer.ConfigurationHandler.Facade
{
    internal class MainFacadeOfConfigurationHandler : IMainFacadeOfConfigurationHandler
    {
        public void Load()
        {
            ILoadHandler loadHandler = new LoadHandler();
            loadHandler.Load();
        }

        public void Save()
        {
            //fix
        }
    }
}
