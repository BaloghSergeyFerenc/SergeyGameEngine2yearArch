namespace RealPersistenceLayer.ConfigurationPersistence.ModelReading
{
    internal class BooleanPropertyData : IBooleanPropertyData
    {
        public ushort Id { get; }
        public ushort Pid { get; }
        public bool Value { get; }

        public BooleanPropertyData(ushort id, ushort pid, bool value)
        {
            Id = id;
            Pid = pid;
            Value = value;
        }
    }
}
