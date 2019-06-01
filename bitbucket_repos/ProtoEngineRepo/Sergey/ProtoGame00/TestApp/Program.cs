using ProtoGame00;
using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            byte tid;
            int id;
            object ins;
            UIfacade ui = new UIfacade();

            tid = 4;
            id = -1;
            ins = null;

            id = ui.adapterCreate.Create(tid);
            ins = ui.adapterGet.Get(id);
            Console.WriteLine("Creation experiment with: {0} \nInstance id (should not be 0): {1}", tid, id);
            Console.WriteLine("Getting experiment with: {0} \nInstance id (should not be null): {1}", tid, ins == null ? "null" : ins.ToString());

            tid = 5;
            id = -1;
            ins = null;

            id = ui.adapterCreate.Create(tid);
            ins = ui.adapterGet.Get(id);
            Console.WriteLine("Creation experiment with: {0} \nInstance id (should not be 0): {1}", tid, id);
            Console.WriteLine("Getting experiment with: {0} \nInstance id (should not be null): {1}", tid, ins == null ? "null" : ins.ToString());
        }
    }
}
