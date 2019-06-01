namespace RealPersistenceLayer.ConfigurationPersistence.ModelReading
{
    public interface IIntegerPropertyData
    {
        ushort Id { get; }
        ushort Pid { get; }
        int Value { get; }
    }
}