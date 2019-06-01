namespace ConfigurationPersistence
{
    public interface IConfigurationPersistenceFacade
    {
        IModelObjectDataReader ModelObjectDataReader { get; }
        IParentRelationReader ParentRelationDataReader { get; }
        IPropertyDataReader PropertyDataReader { get; }
        IActionDataReader ActionDataReader { get; }
    }
}
