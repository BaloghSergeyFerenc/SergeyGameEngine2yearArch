namespace GameEngine.ContextPool.RealPersistenceLayer.ConfigurationPersistence.ModelReader
{
    public interface IStringPropertyData
    {
        ushort Id { get; }
        ushort Pid { get; }
        string Value { get; }
    }
}
