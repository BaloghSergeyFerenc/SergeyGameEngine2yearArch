namespace GameEngine.ContextPool.RealPersistenceLayer.ConfigurationPersistence.ModelReader
{
    public interface ICreateData
    {
        ushort Id { get; }
        ushort Tid { get; }
        ushort ParentId { get; }
    }
}
