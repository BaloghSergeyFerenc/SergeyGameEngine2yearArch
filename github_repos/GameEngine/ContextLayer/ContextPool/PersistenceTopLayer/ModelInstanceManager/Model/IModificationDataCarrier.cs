namespace GameEngine.ContextPool.PersistenceTopLayer.ModelInstanceManager.Model
{
    public interface IModificationDataCarrier
    {
        bool IsInitialized { get; }
        void InitForParentChange(
            ushort id,
            ushort targetid
            );
        void InitForActionChange(
            ushort id,
            ushort aid,
            ModificationType modificationtype
            );
        void InitForRelationChange(
            ushort id,
            ushort rid,
            ushort relatedid,
            ModificationType modificationtype
            );
        void InitForStringPropertyChange(
            ushort id,
            ushort pid,
            ModelPropertyType modelpropertytype,
            ModificationType modificationtype,
            string value
            );
        void InitForBooleanPropertyChange(
            ushort id,
            ushort pid,
            ModelPropertyType modelpropertytype,
            ModificationType modificationtype,
            bool value
            );
        void InitForIntegerPropertyChange(
            ushort id,
            ushort pid,
            ModelPropertyType modelpropertytype,
            ModificationType modificationtype,
            int value
            );
    }
}
