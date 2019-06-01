using GameEngine.ContextLayer.ContextPoolModule;
using GameEngine.ContextLayer.ContextPoolModule.ContextPoolController;
using GameEngine.ContextPool.PersistenceTopLayer.ConfigurationHandler.Facade;
using GameEngine.ContextPool.PersistenceTopLayer.ModelInstanceManager.Facade;
using GameEngine.ContextPool.RealPersistenceLayer.ConfigurationPersistence.Facade;
using GameEngine.ContextPool.RealPersistenceLayer.ConfigurationPersistence.ModelReader;
using System;

namespace FakeTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IMainContext mainContext = new MainContext();
            IMainFacadeOfConfigurationHandler loader = mainContext.GetModule<IMainFacadeOfConfigurationHandler>();
            loader.Load();
            IMainFacadeOfModelInstanceManager x = mainContext.GetModule<IMainFacadeOfModelInstanceManager>();
            Console.ReadLine();

            //IReaderFacadeOfConfigurationPersistence x = FakeTest.Get;
            //var a = x.ReadCreateData();
            //var b = x.ReadActionData();
        }
    }
}
