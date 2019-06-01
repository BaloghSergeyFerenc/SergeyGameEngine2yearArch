namespace PersistenceTopLayer.ModelInstanceManager.Model
{
    internal class ModelRelation : IModelRelation, IModificationDetails
    {
        public ushort Rid { get; }

        public ushort Id { get; }

        public ModelRelation(ushort rid, ushort id)
        {
            Rid = rid;
            Id = id;
        }
    }
}
