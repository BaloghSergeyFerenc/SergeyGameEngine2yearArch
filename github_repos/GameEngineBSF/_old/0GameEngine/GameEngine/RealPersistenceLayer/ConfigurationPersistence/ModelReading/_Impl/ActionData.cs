namespace RealPersistenceLayer.ConfigurationPersistence.ModelReading
{
    internal class ActionData : IActionData
    {
        public ushort Id { get; }
        public ushort Aid { get; }

        public ActionData(ushort id, ushort aid)
        {
            Id = id;
            Aid = aid;
        }
    }
}
