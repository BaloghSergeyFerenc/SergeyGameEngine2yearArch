namespace RealPersistenceLayer.ConfigurationPersistence.ModelReading
{
    public interface IBooleanPropertyData
    {
        ushort Id { get; }
        ushort Pid { get; }
        bool Value { get; }
    }
}