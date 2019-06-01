namespace PersistenceTopLayer.ModelInstanceManager.Model
{
    internal interface IModelPropertiesInternal : IModelProperties
    {
        void Add(IModelProperty modelProperty);
        void Remove(ushort pid);
    }
}
