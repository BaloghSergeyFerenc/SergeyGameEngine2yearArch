namespace PersistenceTopLayer.ModelInstanceManager.Model
{
    internal interface IPropertyFactory
    {
        IModelProperty Create(ushort pid, string value);
        IModelProperty Create(ushort pid, int value);
        IModelProperty Create(ushort pid, bool value);
    }
}
