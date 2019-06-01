namespace RealPersistenceLayer.ConfigurationPersistence.ModelReading
{
    public interface ICreateData
    {
        ushort Id { get; }
        ushort Tid { get; }
        ushort ParentId { get; }
    }
}