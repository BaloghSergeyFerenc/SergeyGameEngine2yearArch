using GameEngine.ContextLayer.ContextPool.Context;
using GameEngine.ContextPool.PersistenceTopLayer.ModelInstanceManager.Facade;
using GameEngine.ContextPool.RealPersistenceLayer.ConfigurationPersistence.Facade;

namespace GameEngine.PersistenceTopLayer.ConfigurationHandler.Context
{
    internal interface IMfchLocalContextProvider : ILocalContextPovider
    {
        IReaderFacadeOfConfigurationPersistence readerFacadeOfConfigurationPersistence { get; }
        ILoadFacadeOfModelInstanceManager loadFacadeOfModelInstanceManager { get; }
    }
}
