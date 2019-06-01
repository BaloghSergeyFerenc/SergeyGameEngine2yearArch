using PersistenceTopLayer.ConfigurationHandler;
using PersistenceTopLayer.ConfigurationHandler.Facade;
using PersistenceTopLayer.ConfigurationHandler.Load;
using PersistenceTopLayer.ModelInstanceManager;
using PersistenceTopLayer.ModelInstanceManager.Facade;
using RealPersistenceLayer.ConfigurationPersistence.Facade;
using RealPersistenceLayer.ConfigurationPersistence.ModelReading;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IMainFacadeOfConfigurationHandler loadHandler = ChStaticModule.load;//PersistenceTopLayer.ConfigurationHandler.Load.Module.load;
            loadHandler.Load();
            IMainFacadeOfModelInstanceManager mim = MimStaticModule.MIM;//PersistenceTopLayer.ModelInstanceManager.Facade.Module.MIM;

            Console.ReadLine();
        }
    }
}
