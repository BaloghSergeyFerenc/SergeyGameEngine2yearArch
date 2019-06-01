using GameEngine.ContextPool.PersistenceTopLayer.ModelInstanceManager.Model;

namespace GameEngine.PersistenceTopLayer.ModelInstanceManager.Model
{
    internal interface IModelActionsInternal : IModelActions
    {
        void Add(ushort aid);
        void Remove(ushort aid);
    }
}
