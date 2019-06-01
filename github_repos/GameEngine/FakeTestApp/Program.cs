using GameEngine.ContextLayer.ContextPoolModule;
using GameEngine.ContextPool.RealPersistenceLayer.ConfigurationPersistence.Facade;
using System;

namespace FakeTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IReaderFacadeOfConfigurationPersistence x = FakeTest.Get;
            var a = x.ReadCreateData();
            var b = x.ReadActionData();
        }
    }
}
