namespace RealPersistenceLayer.ConfigurationPersistence.ModelReading
{
    internal class StringPropertyData : IStringPropertyData
    {
        public ushort Id { get; }
        public ushort Pid { get; }
        public string Value { get; }

        public StringPropertyData(ushort id, ushort pid, string value)
        {
            Id = id;
            Pid = pid;
            Value = value;
        }
    }
}
