using PersistenceTopLayer.ModelInstanceManager.Facade;
using System.Collections.Generic;

namespace PersistenceTopLayer.ModelInstanceManager
{
    public class MimStaticModule
    {
        public static IMainFacadeOfModelInstanceManager MIM;
        public static ILoadFacadeOfModelInstanceManager LMIM = new LoadFacadeOfModelInstanceManager();
    }
}
