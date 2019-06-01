using RealPersistenceLayer.ConfigurationPersistence.Facade;

namespace RealPersistenceLayer.ConfigurationPersistence
{
    public class CpStaticModule
    {
        public static IReaderFacadeOfConfigurationPersistence RCP = new ReaderFacadeOfConfigurationPersistence();
    }
}
