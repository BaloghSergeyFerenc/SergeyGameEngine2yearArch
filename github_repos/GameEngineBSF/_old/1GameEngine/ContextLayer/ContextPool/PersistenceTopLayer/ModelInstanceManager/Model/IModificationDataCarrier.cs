using GameEngine.ContextPool.Enums;

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
            EModificationType modificationtype
            );
        void InitForRelationChange(
            ushort id,
            ushort rid,
            ushort relatedid,
            EModificationType modificationtype
            );
        void InitForStringPropertyChange(
            ushort id,
            ushort pid,
            EModelPropertyType modelpropertytype,
            EModificationType modificationtype,
            string value
            );
        void InitForBooleanPropertyChange(
            ushort id,
            ushort pid,
            EModelPropertyType modelpropertytype,
            EModificationType modificationtype,
            bool value
            );
        void InitForIntegerPropertyChange(
            ushort id,
            ushort pid,
            EModelPropertyType modelpropertytype,
            EModificationType modificationtype,
            int value
            );
    }
}
