namespace GameEngine.ContextPool.RealPersistenceLayer.ConfigurationPersistence.ModelReader
{
    public interface IIntegerPropertyData
    {
        ushort Id { get; }
        ushort Pid { get; }
        int Value { get; }
    }
}
