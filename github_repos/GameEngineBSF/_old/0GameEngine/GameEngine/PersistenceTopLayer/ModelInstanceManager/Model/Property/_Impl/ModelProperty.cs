namespace PersistenceTopLayer.ModelInstanceManager.Model
{
    internal class ModelProperty : IModelProperty, IModificationDetails
    {
        public ushort Pid { get; }

        public ModelPropertyType PropertyType { get; }

        public IPropertyValue Value { get; }

        public ModelProperty(ushort pid, ModelPropertyType modelPropertyType, IPropertyValue propertyValue)
        {
            Pid = pid;
            PropertyType = modelPropertyType;
            Value = propertyValue;
        }
    }
}
