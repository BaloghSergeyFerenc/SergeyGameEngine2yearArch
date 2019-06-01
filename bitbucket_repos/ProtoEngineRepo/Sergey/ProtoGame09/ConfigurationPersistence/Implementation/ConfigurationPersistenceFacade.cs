namespace ConfigurationPersistence
{
    public class ConfigurationPersistenceFacade : IConfigurationPersistenceFacade
    {
        #region Interface
        public IModelObjectDataReader ModelObjectDataReader { get; }

        public IParentRelationReader ParentRelationDataReader { get; }

        public IPropertyDataReader PropertyDataReader { get; }

        public IActionDataReader ActionDataReader { get; }
        #endregion Interface

        #region CDIR
        public ConfigurationPersistenceFacade()
        {
            ModelObjectDataReader = new ModelObjectDataReader();
            ParentRelationDataReader = new ParentRelationDataReader();
            PropertyDataReader = new PropertyDataReader();
            ActionDataReader = new ActionDataReader();
        }
        #endregion CDIR
    }
}
