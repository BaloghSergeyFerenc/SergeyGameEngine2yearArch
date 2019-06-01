using GameEngine.ContextLayer.ContextPool.Context;
using GameEngine.ContextPool.RealPersistenceLayer.ConfigurationPersistence.Facade;
using GameEngine.ContextPool.RealPersistenceLayer.ConfigurationPersistence.ModelReader;
using GameEngine.RealPersistenceLayer.ConfigurationPersistence.Context;
using GameEngine.RealPersistenceLayer.ConfigurationPersistence.ModelReader;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("GameEngine.ContextLayer.ContextPoolModule")]
namespace GameEngine.RealPersistenceLayer.ConfigurationPersistence.Facade
{
    internal class ReaderFacadeOfConfigurationPersistence : IReaderFacadeOfConfigurationPersistence
    {
        private IRfcpLocalContextProvider rfcpLocalConextProvider;

        public T GetLocalContextPovider<T>() where T : ILocalContextPovider
        {
            if(!(rfcpLocalConextProvider is T))
            {
                return default(T);
            }
            return (T)rfcpLocalConextProvider;
        }

        public ReaderFacadeOfConfigurationPersistence(IRfcpLocalContextProvider localcontextpovider)
        {
            rfcpLocalConextProvider = localcontextpovider;
        }

        public IActionDataSet ReadActionData()
        {
            return new ActionDataSet(rfcpLocalConextProvider);
        }

        public IBooleanPropertyDataSet ReadBooleanPropertyData()
        {
            return new BooleanPropertyDataSet(rfcpLocalConextProvider);
        }

        public ICreateDataSet ReadCreateData()
        {
            return new CreateDataSet(rfcpLocalConextProvider);
        }

        public IIntegerPropertyDataSet ReadIntegerPropertyData()
        {
            return new IntegerPropertyDataSet(rfcpLocalConextProvider);
        }

        public IRelationDataSet ReadRelationData()
        {
            return new RelationDataSet(rfcpLocalConextProvider);
        }

        public IStringPropertyDataSet ReadStringPropertyData()
        {
            return new StringPropertyDataSet(rfcpLocalConextProvider);
        }
    }
}
