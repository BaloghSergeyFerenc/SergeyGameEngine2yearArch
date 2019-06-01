using GameEngine.ContextPool.PersistenceTopLayer.ModelInstanceManager.Model;

namespace GameEngine.PersistenceTopLayer.ModelInstanceManager.Model
{
    internal interface IModelFactory
    {
        IModelObject Create(ushort id, ushort tid, ushort parentid);
        IModelObject Create(ushort tid, ushort parentid);
    }
}
