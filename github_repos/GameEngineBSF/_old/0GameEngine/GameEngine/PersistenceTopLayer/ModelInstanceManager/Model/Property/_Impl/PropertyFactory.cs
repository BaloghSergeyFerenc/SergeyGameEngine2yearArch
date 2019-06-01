namespace PersistenceTopLayer.ModelInstanceManager.Model
{
    internal class PropertyFactory : IPropertyFactory
    {
        public IModelProperty Create(ushort pid, string value)
        {
            return new ModelProperty(pid, ModelPropertyType.mpString, new StringPropertyValue(value));
        }

        public IModelProperty Create(ushort pid, int value)
        {
            return new ModelProperty(pid, ModelPropertyType.mpString, new IntegerPropertyValue(value));
        }

        public IModelProperty Create(ushort pid, bool value)
        {
            return new ModelProperty(pid, ModelPropertyType.mpString, new BooleanPropertyValue(value));
        }
    }
}
