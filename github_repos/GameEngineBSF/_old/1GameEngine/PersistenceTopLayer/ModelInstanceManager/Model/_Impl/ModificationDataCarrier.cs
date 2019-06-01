using GameEngine.ContextPool.Enums;

namespace GameEngine.PersistenceTopLayer.ModelInstanceManager.Model
{
    internal class ModificationDataCarrier : IModificationDataCarrierInternal
    {
        private IPropertyFactory propertyFactory;

        public ushort Id { get; private set; }
        public ETargetItemType TargetItemType { get; private set; }
        public ushort TargetId { get; private set; }
        public EModificationType ModificationType { get; private set; }
        public IModificationDetails ModificationDetails { get; private set; }

        public ModificationDataCarrier(IPropertyFactory propertyfactory)
        {
            propertyFactory = propertyfactory;
            IsInitialized = false;
        }

        public bool IsInitialized { get; private set; }

        public void InitForParentChange(ushort id, ushort targetid)
        {
            if (!IsInitialized)
            {
                Id = id;
                TargetId = targetid;
                TargetItemType = ETargetItemType.Parent;
                ModificationType = EModificationType.Add;

                IsInitialized = true;
            }
        }

        public void InitForActionChange(ushort id, ushort aid, EModificationType modificationtype)
        {
            if (!IsInitialized)
            {
                Id = id;
                TargetId = aid;
                TargetItemType = ETargetItemType.Action;
                ModificationType = modificationtype;

                IsInitialized = true;
            }
        }

        public void InitForRelationChange(ushort id, ushort rid, ushort relatedid, EModificationType modificationtype)
        {
            if (!IsInitialized)
            {
                Id = id;
                TargetId = rid;
                TargetItemType = ETargetItemType.Relation;
                ModificationType = modificationtype;

                ModificationDetails = new ModelRelation(rid, relatedid);

                IsInitialized = true;
            }
        }

        public void InitForBooleanPropertyChange(ushort id, ushort pid, EModelPropertyType modelpropertytype, EModificationType modificationtype, bool value)
        {
            if (!IsInitialized)
            {
                Id = id;
                TargetId = pid;
                TargetItemType = ETargetItemType.Property;
                ModificationType = modificationtype;

                ModificationDetails = (IModificationDetails)propertyFactory.Create(pid, value);

                IsInitialized = true;
            }
        }

        public void InitForIntegerPropertyChange(ushort id, ushort pid, EModelPropertyType modelpropertytype, EModificationType modificationtype, int value)
        {
            if (!IsInitialized)
            {
                Id = id;
                TargetId = pid;
                TargetItemType = ETargetItemType.Property;
                ModificationType = modificationtype;

                ModificationDetails = (IModificationDetails)propertyFactory.Create(pid, value);

                IsInitialized = true;
            }
        }

        public void InitForStringPropertyChange(ushort id, ushort pid, EModelPropertyType modelpropertytype, EModificationType modificationtype, string value)
        {
            if (!IsInitialized)
            {
                Id = id;
                TargetId = pid;
                TargetItemType = ETargetItemType.Property;
                ModificationType = modificationtype;

                ModificationDetails = (IModificationDetails)propertyFactory.Create(pid, value);

                IsInitialized = true;
            }
        }
    }
}
