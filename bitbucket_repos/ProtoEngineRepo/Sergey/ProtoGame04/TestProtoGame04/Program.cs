using ProtoGame04.InstanceManager;
using System;

namespace TestProtoGame04
{
    class Program
    {
        static void Main(string[] args)
        {
            InstanceManagerFacade imf = new InstanceManagerFacade(ConfigModel.ProtoModel1);
            IInstance x = imf.Read(1001);
            Console.WriteLine(x.ToString());
            Console.ReadLine();

            InstanceManagerFacade imf2 = new InstanceManagerFacade(ConfigModel.ProtoModel2);
            IInstance x2 = imf2.Read(1001);
            Console.WriteLine(x2.ToString());
            Console.ReadLine();
        }
    }
}
