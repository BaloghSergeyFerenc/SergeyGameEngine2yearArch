using GameEngine.ContextPool.PersistenceTopLayer.ModelInstanceManager.Model;

namespace GameEngine.PersistenceTopLayer.ModelInstanceManager.Model
{
    internal interface IModelModifier
    {
        void Update(IModelObject modelobject, IModificationDataCarrierInternal modificationdata, IModelRepository repository);
    }
}
