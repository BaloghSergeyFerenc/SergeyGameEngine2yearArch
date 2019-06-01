using GameEngine.ContextPool.RealPersistenceLayer.ConfigurationPersistence.ModelReader;

namespace GameEngine.RealPersistenceLayer.ConfigurationPersistence.ModelReader
{
    internal class RelationData : IRelationData
    {
        public ushort Id { get; }
        public ushort Rid { get; }
        public ushort RelatedId { get; }

        public RelationData(ushort id, ushort rid, ushort relatedid)
        {
            Id = id;
            Rid = rid;
            RelatedId = relatedid;
        }
    }
}
