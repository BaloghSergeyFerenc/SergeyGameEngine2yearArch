namespace RealPersistenceLayer.ConfigurationPersistence.ModelReading
{
    public interface IRelationData
    {
        ushort Id { get; }
        ushort Rid { get; }
        ushort RelatedId { get; }
    }
}