using PersistenceTopLayer.ConfigurationHandler;
using PersistenceTopLayer.ModelProvier;
using System;

namespace TestModel
{
    class Program
    {
        static void Main(string[] args)
        {
            IModelFacade facade = (new ConfigurationHandler()).Load();
            IModelObject x = facade.Read(1001);
            Console.WriteLine(x.ToString());
            Console.ReadLine();


        }
    }
}
