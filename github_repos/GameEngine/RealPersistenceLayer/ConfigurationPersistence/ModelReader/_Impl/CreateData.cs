using GameEngine.ContextPool.RealPersistenceLayer.ConfigurationPersistence.ModelReader;

namespace GameEngine.RealPersistenceLayer.ConfigurationPersistence.ModelReader
{
    internal class CreateData : ICreateData
    {
        public ushort Id { get; }
        public ushort Tid { get; }
        public ushort ParentId { get; }

        public CreateData(ushort id, ushort tid, ushort parentid)
        {
            Id = id;
            Tid = tid;
            ParentId = parentid;
        }
    }
}
