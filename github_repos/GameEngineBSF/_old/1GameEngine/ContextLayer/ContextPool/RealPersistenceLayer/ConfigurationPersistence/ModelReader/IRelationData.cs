namespace GameEngine.ContextPool.RealPersistenceLayer.ConfigurationPersistence.ModelReader
{
    public interface IRelationData
    {
        ushort Id { get; }
        ushort Rid { get; }
        ushort RelatedId { get; }
    }
}
