namespace GameEngine.ContextPool.PersistenceTopLayer.ModelInstanceManager.Model
{
    interface IModelObject
    {
        ushort Id { get; }
        ushort Tid { get; }
        ushort Parent { get; }
        IModelChildren ModelChildren { get; }
        IModelActions ModelActions { get; }
        IModelRelations ModelRelations { get; }
        IModelProperties ModelProperties { get; }
    }
}
