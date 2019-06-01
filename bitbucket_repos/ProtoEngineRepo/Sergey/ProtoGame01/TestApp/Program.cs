using ProtoGame01;
using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientServer cls = new ClientServer();
            int id = cls.GetCreatorAdapter.Create;
            FakeAdapterInstance fai = cls.GetGetterAdapter.GetInstance(id);
            Console.WriteLine("Id of new instance: " + fai.Id);
            Console.WriteLine("Tid of new instance: " + fai.TypeId);
            Console.WriteLine("Property of new instance: " + fai.PropertyToChange);

            fai.PropertyToChange = "something";
            Console.WriteLine("Property of changed instance: " + fai.PropertyToChange);

            cls.DeletionAdapter.Delete(fai.Id);
            fai = cls.GetGetterAdapter.GetInstance(fai.Id);
            Console.WriteLine("Adapter of deleted instance" + fai);

            id = cls.GetCreatorAdapter.Create;
            fai = cls.GetGetterAdapter.GetInstance(id);
            Console.WriteLine("Id of new instance: " + fai.Id);
            fai.Delete();
            fai = cls.GetGetterAdapter.GetInstance(fai.Id);
            Console.WriteLine("Adapter of deleted instance" + fai);

            Console.ReadLine();
        }
    }
}
