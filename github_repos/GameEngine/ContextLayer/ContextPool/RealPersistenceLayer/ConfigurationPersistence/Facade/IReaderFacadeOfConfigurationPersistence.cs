using GameEngine.ContextPool.RealPersistenceLayer.ConfigurationPersistence.ModelReader;

namespace GameEngine.ContextPool.RealPersistenceLayer.ConfigurationPersistence.Facade
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
