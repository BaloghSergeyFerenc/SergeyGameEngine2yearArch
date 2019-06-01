using GameEngine.ContextLayer.ContextPool.Context;
using GameEngine.ContextPool.PersistenceTopLayer.ConfigurationHandler.Facade;
using GameEngine.PersistenceTopLayer.ConfigurationHandler.Context;
using GameEngine.PersistenceTopLayer.ConfigurationHandler.Load;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("GameEngine.ContextLayer.ContextPoolModule")]
namespace GameEngine.PersistenceTopLayer.ConfigurationHandler.Facade
{
    internal class MainFacadeOfConfigurationHandler : IMainFacadeOfConfigurationHandler
    {
        private IMfchLocalContextProvider mfchLocalContextProvider;

        public MainFacadeOfConfigurationHandler(IMfchLocalContextProvider mfchlocalcontextprovider)
        {
            mfchLocalContextProvider = mfchlocalcontextprovider;
        }

        public T GetLocalContextPovider<T>() where T : ILocalContextPovider
        {
            if (!(mfchLocalContextProvider is T))
            {
                return default(T);
            }
            return (T)mfchLocalContextProvider;
        }

        public void Load()
        {
            ILoadHandler loadHandler = new LoadHandler();
            loadHandler.Load(mfchLocalContextProvider);
        }

        public void Save()
        {
            //fix
        }
    }
}
