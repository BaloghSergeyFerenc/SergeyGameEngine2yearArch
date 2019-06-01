using GameEngine.ContextPool.PersistenceTopLayer.ModelInstanceManager.Model;

namespace GameEngine.PersistenceTopLayer.ModelInstanceManager.Model
{
    internal interface IModelRepository
    {
        ushort Add(IModelObject modelobject);
        IModelObject Get(ushort id);
        void Remove(ushort id);
    }
}
