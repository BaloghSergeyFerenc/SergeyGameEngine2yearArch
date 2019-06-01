using GameEngine.ContextLayer.ContextPool.Context;

namespace GameEngine.RealPersistenceLayer.ConfigurationPersistence.Context
{
    internal interface IRfcpLocalContextProvider : ILocalContextPovider
    {
        IDataBaseLocalContext Get { get; }
    }
}
