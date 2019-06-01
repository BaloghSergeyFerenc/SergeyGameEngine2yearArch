namespace PersistenceTopLayer.ModelInstanceManager.Model
{
    internal interface IModelModifier
    {
        void Update(IModelObject modelobject, IModificationDataCarrierInternal modificationdata, IModelRepository repository);
    }
}
