using GameEngine.ContextPool.PersistenceTopLayer.ModelInstanceManager.Model;

namespace GameEngine.PersistenceTopLayer.ModelInstanceManager.Model
{
    internal interface IModelManager
    {
        IModelObject Create(ushort id, ushort tid, ushort parentid);
        IModelObject Create(ushort tid, ushort parentid);
        IModelObject Read(ushort id);
        void Update(IModificationDataCarrierInternal modificationdata);
        void Delete(ushort id);
    }
}
