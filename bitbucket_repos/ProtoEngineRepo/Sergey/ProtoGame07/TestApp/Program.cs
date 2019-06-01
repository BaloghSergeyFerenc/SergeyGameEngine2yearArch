using PersistenceTopLayer.Fake;
using PersistenceTopLayer.Interface;
using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test App run.");

            Console.WriteLine("Loader ready.");
            Console.ReadLine();
            ILoader loader = new Loader();
            Console.WriteLine("Is OK: loading.");
            Console.ReadLine();
            IModelFacade facade = loader.Load(null);
            Console.WriteLine("Is OK: create.");
            Console.ReadLine();
            facade.Create(0);
            Console.WriteLine("Is OK: read.");
            Console.ReadLine();
            facade.Read(0);
            Console.WriteLine("Is OK: update.");
            Console.ReadLine();
            facade.Update(null);
            Console.WriteLine("Is OK: delete.");
            Console.ReadLine();
            facade.Delete(0);
            Console.WriteLine("Is OK: load2.");
            Console.ReadLine();
            IModelFacade facade2 = loader.Load(null);
            Console.WriteLine("Is OK: saving fail");
            Console.ReadLine();
            IPtlSavingContext savingContext = loader.Save(facade);
            Console.WriteLine("Is OK: save");
            Console.ReadLine();
            savingContext = loader.Save(facade2);
            Console.WriteLine("Is OK: SaveFileName ok.");
            Console.ReadLine();
            Console.WriteLine($"----------> { savingContext.SaveFileName == "MockSaveFileName"}");

            Console.WriteLine("Test App finished.");
            Console.ReadLine();

        }
    }
}
