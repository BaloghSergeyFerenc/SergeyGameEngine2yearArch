namespace GameEngine.ContextPool.RealPersistenceLayer.ConfigurationPersistence.ModelReader
{
    public interface IBooleanPropertyData
    {
        ushort Id { get; }
        ushort Pid { get; }
        bool Value { get; }
    }
}
