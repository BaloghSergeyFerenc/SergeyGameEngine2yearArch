using PersistenceTopLayer.ConfigurationHandler.Facade;

namespace PersistenceTopLayer.ConfigurationHandler
{
    public class ChStaticModule
    {
        public static IMainFacadeOfConfigurationHandler load = new MainFacadeOfConfigurationHandler();
    }
}
