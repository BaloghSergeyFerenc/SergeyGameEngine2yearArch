using GameEngine.PersistenceTopLayer.ConfigurationHandler.Context;

namespace GameEngine.PersistenceTopLayer.ConfigurationHandler.Load
{
    internal interface ILoadHandler
    {
        void Load(IMfchLocalContextProvider mfchlocalcontextprovider);
    }
}
