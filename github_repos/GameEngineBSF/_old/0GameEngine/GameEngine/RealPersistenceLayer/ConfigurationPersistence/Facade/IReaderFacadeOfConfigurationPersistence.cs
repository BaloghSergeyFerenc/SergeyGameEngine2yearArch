using RealPersistenceLayer.ConfigurationPersistence.ModelReading;

namespace RealPersistenceLayer.ConfigurationPersistence.Facade
{
    public interface IReaderFacadeOfConfigurationPersistence
    {
        ICreateDataSet ReadCreateData();
        IActionDataSet ReadActionData();
        IRelationDataSet ReadRelationData();
        IStringPropertyDataSet ReadStringPropertyData();
        IBooleanPropertyDataSet ReadBooleanPropertyData();
        IIntegerPropertyDataSet ReadIntegerPropertyData();
    }
}
