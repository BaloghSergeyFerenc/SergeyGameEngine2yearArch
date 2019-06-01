using GameEngine.ContextPool.Enums;
using GameEngine.ContextPool.PersistenceTopLayer.ModelInstanceManager.Model;

namespace GameEngine.PersistenceTopLayer.ModelInstanceManager.Model
{
    internal class ModelProperty : IModelProperty, IModificationDetails
    {
        public ushort Pid { get; }

        public EModelPropertyType PropertyType { get; }

        public IPropertyValue Value { get; }

        public ModelProperty(ushort pid, EModelPropertyType modelPropertyType, IPropertyValue propertyValue)
        {
            Pid = pid;
            PropertyType = modelPropertyType;
            Value = propertyValue;
        }
    }
}
