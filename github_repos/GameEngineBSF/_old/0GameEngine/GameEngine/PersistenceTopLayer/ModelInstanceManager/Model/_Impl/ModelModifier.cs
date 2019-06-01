namespace PersistenceTopLayer.ModelInstanceManager.Model
{
    internal class ModelModifier : IModelModifier
    {
        public void Update(IModelObject modelobject, IModificationDataCarrierInternal modificationdata, IModelRepository repository)
        {
            switch(modificationdata.TargetItemType)
            {
                case TargetItemType.Parent:
                    ModifyParent(modelobject as ModelObject, modificationdata, repository);
                    break;
                case TargetItemType.Action:
                    ModifyAction(modelobject as ModelObject, modificationdata);
                    break;
                case TargetItemType.Relation:
                    ModifyRelation(modelobject as ModelObject, modificationdata);
                    break;
                case TargetItemType.Property:
                    ModifyProperty(modelobject as ModelObject, modificationdata);
                    break;
            }
        }

        private void ModifyParent(ModelObject modelobject, IModificationDataCarrierInternal modificationdata, IModelRepository repository)
        {
            IModelObject oldParent = repository.Get(modelobject.Parent);
            IModelObject newParent = repository.Get(modificationdata.TargetId);
            modelobject.Parent = modificationdata.TargetId;
            (oldParent.ModelChildren as IModelChildrenInternal).Remove(modificationdata.Id);
            (newParent.ModelChildren as IModelChildrenInternal).Add(modificationdata.Id);
        }

        private void ModifyAction(ModelObject modelobject, IModificationDataCarrierInternal modificationdata)
        {
            if(modificationdata.ModificationType.Equals(ModificationType.Add))
            {
                (modelobject.ModelActions as IModelActionsInternal).Add(modificationdata.TargetId);
            }
            else
            {
                (modelobject.ModelActions as IModelActionsInternal).Remove(modificationdata.TargetId);
            }
        }

        private void ModifyRelation(ModelObject modelobject, IModificationDataCarrierInternal modificationdata)
        {
            if(modificationdata.ModificationType.Equals(ModificationType.Add))
            {
                (modelobject.ModelRelations as IModelRelationsInternal).Add(modificationdata.ModificationDetails as IModelRelation);
            }
            else
            {
                (modelobject.ModelRelations as IModelRelationsInternal).Remove(modificationdata.ModificationDetails as IModelRelation);
            }
        }

        private void ModifyProperty(ModelObject modelobject, IModificationDataCarrierInternal modificationdata)
        {
            if(modificationdata.ModificationType.Equals(ModificationType.Add))
            {
                (modelobject.ModelProperties as IModelPropertiesInternal).Add(modificationdata.ModificationDetails as IModelProperty);
            }
            else
            {
                (modelobject.ModelProperties as IModelPropertiesInternal).Remove(modificationdata.TargetId);
            }
        }
    }
}
