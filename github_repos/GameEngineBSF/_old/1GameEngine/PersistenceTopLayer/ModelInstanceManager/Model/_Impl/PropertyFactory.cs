using GameEngine.ContextPool.Enums;
using GameEngine.ContextPool.PersistenceTopLayer.ModelInstanceManager.Model;

namespace GameEngine.PersistenceTopLayer.ModelInstanceManager.Model
{
    internal class PropertyFactory : IPropertyFactory
    {
        public IModelProperty Create(ushort pid, string value)
        {
            return new ModelProperty(pid, EModelPropertyType.mpString, new StringPropertyValue(value));
        }

        public IModelProperty Create(ushort pid, int value)
        {
            return new ModelProperty(pid, EModelPropertyType.mpString, new IntegerPropertyValue(value));
        }

        public IModelProperty Create(ushort pid, bool value)
        {
            return new ModelProperty(pid, EModelPropertyType.mpString, new BooleanPropertyValue(value));
        }
    }
}
