using GameEngine.ContextLayer.ContextPool.Context;
using GameEngine.ContextPool.PersistenceTopLayer.ModelInstanceManager.Model;

namespace GameEngine.ContextPool.PersistenceTopLayer.ModelInstanceManager.Facade
{
    public interface IMainFacadeOfModelInstanceManager : IEngineModule
    {
        void Create(ushort tid, ushort parentid);
        IModelObject Read(ushort id);
        void Update(IModificationDataCarrier modificationdata);
        void Delete(ushort id);
        IModificationDataCarrier GetNewModificationDataCarrier();
    }
}
