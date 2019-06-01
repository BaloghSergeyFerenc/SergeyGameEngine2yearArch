namespace PersistenceTopLayer.ModelInstanceManager.Model
{
    internal class ModificationDataCarrier : IModificationDataCarrierInternal
    {
        private IPropertyFactory propertyFactory;

        public ushort Id { get; private set; }
        public TargetItemType TargetItemType { get; private set; }
        public ushort TargetId { get; private set; }
        public ModificationType ModificationType { get; private set; }
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
                TargetItemType = TargetItemType.Parent;
                ModificationType = ModificationType.Add;

                IsInitialized = true;
            }
        }

        public void InitForActionChange(ushort id, ushort aid, ModificationType modificationtype)
        {
            if(!IsInitialized)
            {
                Id = id;
                TargetId = aid;
                TargetItemType = TargetItemType.Action;
                ModificationType = modificationtype;

                IsInitialized = true;
            }
        }

        public void InitForRelationChange(ushort id, ushort rid, ushort relatedid, ModificationType modificationtype)
        {
            if(!IsInitialized)
            {
                Id = id;
                TargetId = rid;
                TargetItemType = TargetItemType.Relation;
                ModificationType = modificationtype;

                ModificationDetails = new ModelRelation(rid, relatedid);

                IsInitialized = true;
            }
        }

        public void InitForBooleanPropertyChange(ushort id, ushort pid, ModelPropertyType modelpropertytype, ModificationType modificationtype, bool value)
        {
            if(!IsInitialized)
            {
                Id = id;
                TargetId = pid;
                TargetItemType = TargetItemType.Property;
                ModificationType = modificationtype;

                ModificationDetails = (IModificationDetails)propertyFactory.Create(pid, value);

                IsInitialized = true;
            }
        }

        public void InitForIntegerPropertyChange(ushort id, ushort pid, ModelPropertyType modelpropertytype, ModificationType modificationtype, int value)
        {
            if (!IsInitialized)
            {
                Id = id;
                TargetId = pid;
                TargetItemType = TargetItemType.Property;
                ModificationType = modificationtype;

                ModificationDetails = (IModificationDetails)propertyFactory.Create(pid, value);

                IsInitialized = true;
            }
        }

        public void InitForStringPropertyChange(ushort id, ushort pid, ModelPropertyType modelpropertytype, ModificationType modificationtype, string value)
        {
            if (!IsInitialized)
            {
                Id = id;
                TargetId = pid;
                TargetItemType = TargetItemType.Property;
                ModificationType = modificationtype;

                ModificationDetails = (IModificationDetails)propertyFactory.Create(pid, value);

                IsInitialized = true;
            }
        }
    }
}
