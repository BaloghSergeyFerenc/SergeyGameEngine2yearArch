using GameEngine.ContextPool.ContextLayer;
using GameEngine.ContextPool.RealPersistenceLayer.ConfigurationPersistence.Facade;
using GameEngine.ContextPool.RealPersistenceLayer.ConfigurationPersistence.ModelReader;
using GameEngine.RealPersistenceLayer.ConfigurationPersistence.Context;
using GameEngine.RealPersistenceLayer.ConfigurationPersistence.ModelReader;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("GameEngine.ContextLayer.ContextPoolModule")]
namespace GameEngine.RealPersistenceLayer.ConfigurationPersistence.Facade
{
    internal class ReaderFacadeOfConfigurationPersistence : IReaderFacadeOfConfigurationPersistence, IEngineModule<IRfcpLocalConextProvider>
    {
        public IRfcpLocalConextProvider GetLocalContextPovider {get;}

        public ReaderFacadeOfConfigurationPersistence(IRfcpLocalConextProvider localcontextpovider)
        {
            GetLocalContextPovider = localcontextpovider;
        }

        public IActionDataSet ReadActionData()
        {
            return new ActionDataSet(GetLocalContextPovider);
        }

        public IBooleanPropertyDataSet ReadBooleanPropertyData()
        {
            return new BooleanPropertyDataSet(GetLocalContextPovider);
        }

        public ICreateDataSet ReadCreateData()
        {
            return new CreateDataSet(GetLocalContextPovider);
        }

        public IIntegerPropertyDataSet ReadIntegerPropertyData()
        {
            return new IntegerPropertyDataSet(GetLocalContextPovider);
        }

        public IRelationDataSet ReadRelationData()
        {
            return new RelationDataSet(GetLocalContextPovider);
        }

        public IStringPropertyDataSet ReadStringPropertyData()
        {
            return new StringPropertyDataSet(GetLocalContextPovider);
        }
    }
}
