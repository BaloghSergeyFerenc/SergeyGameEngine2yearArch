namespace PersistenceTopLayer.ModelInstanceManager.Model
{
    public interface IModelProperty
    {
        ushort Pid { get; }
        ModelPropertyType PropertyType { get; }
        IPropertyValue Value { get; }
    }
}