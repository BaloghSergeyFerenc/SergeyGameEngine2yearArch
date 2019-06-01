namespace ConfigurationPersistence
{
    public interface IPropertyDataReader
    {
        bool Next();
        void Read(out uint ownerId, out uint propertyId, out string type_value_callbacks);
    }
}