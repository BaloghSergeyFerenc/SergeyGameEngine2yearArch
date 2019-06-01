namespace RealPersistenceLayer.ConfigurationPersistence.ModelReading
{
    public interface IStringPropertyData
    {
        ushort Id { get; }
        ushort Pid { get; }
        string Value { get; }
    }
}