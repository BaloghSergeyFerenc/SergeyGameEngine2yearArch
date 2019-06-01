using PersistenceTopLayer.IdentifierManager.Facade;

namespace PersistenceTopLayer.IdentifierManager
{
    public static class IdmStaticModule
    {
        public static ILoadFacadeOfIdentifierManager LIDM = new LoadFacadeOfIdentifierManager();
        public static IMainFacadeOfIdentifierManager MIDM;
    }
}
