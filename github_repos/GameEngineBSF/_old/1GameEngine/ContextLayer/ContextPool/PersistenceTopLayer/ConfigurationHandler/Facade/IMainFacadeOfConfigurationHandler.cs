using GameEngine.ContextLayer.ContextPool.Context;

namespace GameEngine.ContextPool.PersistenceTopLayer.ConfigurationHandler.Facade
{
    public interface IMainFacadeOfConfigurationHandler : IEngineModule
    {
        void Load();
        void Save();
    }
}
