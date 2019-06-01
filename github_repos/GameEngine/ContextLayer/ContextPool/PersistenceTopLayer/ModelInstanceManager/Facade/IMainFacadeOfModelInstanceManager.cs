using GameEngine.ContextPool.PersistenceTopLayer.ModelInstanceManager.Model;

namespace GameEngine.ContextPool.PersistenceTopLayer.ModelInstanceManager.Facade
{
    public interface IMainFacadeOfModelInstanceManager
    {
        void Create(ushort tid, ushort parentid);
        IModelObject Read(ushort id);
        void Update(IModificationDataCarrier modificationdata);
        void Delete(ushort id);
        IModificationDataCarrier GetNewModificationDataCarrier();
    }
}
