using GameEngine.ContextLayer.ContextPoolModule._Impl;
using GameEngine.ContextPool.RealPersistenceLayer.ConfigurationPersistence.Facade;
using GameEngine.RealPersistenceLayer.ConfigurationPersistence.Facade;

namespace GameEngine.ContextLayer.ContextPoolModule
{
    public static class FakeTest
    {
        public static IReaderFacadeOfConfigurationPersistence Get = new ReaderFacadeOfConfigurationPersistence(new RfcpLocalConextProvider());
    }
}
