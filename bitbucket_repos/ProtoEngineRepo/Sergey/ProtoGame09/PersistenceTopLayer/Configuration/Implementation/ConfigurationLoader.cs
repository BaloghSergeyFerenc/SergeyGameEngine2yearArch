using ConfigurationPersistence;
using PersistenceTopLayer.Model;

namespace PersistenceTopLayer.Configuration
{
    class ConfigurationLoader : IConfigurationLoader
    {
        #region Fields
        private IModelInitializer _ModelInitializer;
        private IConfigurationPersistenceFacade _ConfigurationPersistenceFacade;
        #endregion Fields

        #region Interface
        public IModelFacade CreatedModel { get; private set; }

        public void Load()
        {
            Init();
            LoadModelObjects();
            LoadParentRelations();
            LoadProperties();
            LoadActions();
        }
        #endregion Interface

        #region Private
        private void Init()
        {
            this._ModelInitializer = null;//fix
            this._ConfigurationPersistenceFacade = new ConfigurationPersistenceFacade();
        }

        private void LoadModelObjects()
        {
            while(_ConfigurationPersistenceFacade.ModelObjectDataReader.Next())
            {
                uint id;
                uint tid;
                _ConfigurationPersistenceFacade.ModelObjectDataReader.Read(out id, out tid);
                _ModelInitializer.Create(id, tid);
            }
        }

        private void LoadParentRelations()
        {
            while(_ConfigurationPersistenceFacade.ParentRelationDataReader.Next())
            {
                uint parentId;
                uint childId;
                _ConfigurationPersistenceFacade.ParentRelationDataReader.Read(out childId, out parentId);
                _ModelInitializer.Update(new ChangingParameters(childId, new ParentChangeData(parentId)));//fix
            }
        }

        private void LoadActions()
        {
            while(_ConfigurationPersistenceFacade.ActionDataReader.Next())
            {
                uint ownerId;
                uint actionId;
                _ConfigurationPersistenceFacade.ActionDataReader.Read(out ownerId, out actionId);
                _ModelInitializer.Update(new ChangingParameters(ownerId, new ActionChangeData(actionId, ActionChangeData.ActionModified.Add)));
            }
        }

        private void LoadProperties()
        {
            while(_ConfigurationPersistenceFacade.PropertyDataReader.Next())
            {
                uint ownerId;
                uint propertyId;
                string details;
                _ConfigurationPersistenceFacade.PropertyDataReader.Read(out ownerId, out propertyId, out details);
                _ModelInitializer.Update(new ChangingParameters(ownerId, new PropertyChangeData(propertyId, PropertyChangeData.PropertyModified.Add, details)));
            }
        }
        #endregion Private
    }
}
