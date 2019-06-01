using GameEngine.ContextPool.PersistenceTopLayer.IdentifierManager.Facade;

namespace GameEngine.PersistenceTopLayer.IdentifierManager.Facade
{
    internal class MainFacadeOfIdentifierManager : IMainFacadeOfIdentifierManager
    {
        private IModelIdentifierManager modelIdentifierManager;

        public MainFacadeOfIdentifierManager(IModelIdentifierManager modelidentifiermanager)
        {
            modelIdentifierManager = modelidentifiermanager;
        }

        public ushort GetNewModelId()
        {
            return modelIdentifierManager.GetNewModelId();
        }
    }
}
