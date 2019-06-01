namespace RealPersistenceLayer.ConfigurationPersistence.ModelReading
{
    internal class IntegerPropertyData : IIntegerPropertyData
    {
        public ushort Id { get; }
        public ushort Pid { get; }
        public int Value { get; }

        public IntegerPropertyData(ushort id, ushort pid, int value)
        {
            Id = id;
            Pid = pid;
            Value = value;
        }
    }
}
