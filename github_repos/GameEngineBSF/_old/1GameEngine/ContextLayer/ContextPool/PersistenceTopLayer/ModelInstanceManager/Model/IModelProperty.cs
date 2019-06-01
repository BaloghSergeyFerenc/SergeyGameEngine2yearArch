using GameEngine.ContextPool.Enums;

namespace GameEngine.ContextPool.PersistenceTopLayer.ModelInstanceManager.Model
{
    public interface IModelProperty
    {
        ushort Pid { get; }
        EModelPropertyType PropertyType { get; }
        IPropertyValue Value { get; }
    }
}
