namespace PersistenceTopLayer.ModelInstanceManager.Model
{
    internal interface IModelChildrenInternal : IModelChildren
    {
        void Add(ushort id);
        void Remove(ushort id);
    }
}
