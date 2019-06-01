using GameEngine.ContextLayer.ContextPool.Context;
using GameEngine.ContextPool.PersistenceTopLayer.ModelInstanceManager.Model;

namespace GameEngine.ContextPool.PersistenceTopLayer.ModelInstanceManager.Facade
{
    public interface ILoadFacadeOfModelInstanceManager : IEngineModule
    {
        void Create(ushort id, ushort tid, ushort parentid);
        void Update(IModificationDataCarrier modificationdata);
        void FinalizeLoading();
        IModificationDataCarrier GetNewModificationDataCarrier();
    }
}
