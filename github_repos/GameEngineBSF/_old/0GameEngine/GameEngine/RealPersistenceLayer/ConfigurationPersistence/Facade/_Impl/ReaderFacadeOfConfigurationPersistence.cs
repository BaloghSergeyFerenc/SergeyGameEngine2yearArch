using RealPersistenceLayer.ConfigurationPersistence.ModelReading;

namespace RealPersistenceLayer.ConfigurationPersistence.Facade
{
    internal class ReaderFacadeOfConfigurationPersistence : IReaderFacadeOfConfigurationPersistence
    {
        public IActionDataSet ReadActionData()
        {
            return new ActionDataSet();
        }

        public IBooleanPropertyDataSet ReadBooleanPropertyData()
        {
            return new BooleanPropertyDataSet();
        }

        public ICreateDataSet ReadCreateData()
        {
            return new CreateDataSet();
        }

        public IIntegerPropertyDataSet ReadIntegerPropertyData()
        {
            return new IntegerPropertyDataSet();
        }

        public IRelationDataSet ReadRelationData()
        {
            return new RelationDataSet();
        }

        public IStringPropertyDataSet ReadStringPropertyData()
        {
            return new StringPropertyDataSet();
        }
    }
}
