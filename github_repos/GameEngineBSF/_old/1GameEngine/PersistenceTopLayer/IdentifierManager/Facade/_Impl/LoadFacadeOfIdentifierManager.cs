using GameEngine.ContextPool.Enums;
using GameEngine.ContextPool.PersistenceTopLayer.IdentifierManager.Facade;

namespace GameEngine.PersistenceTopLayer.IdentifierManager.Facade
{
    internal class LoadFacadeOfIdentifierManager : ILoadFacadeOfIdentifierManager
    {
        private IModelIdentifierManager modelIdentifierManager;

        public void Init()
        {
            modelIdentifierManager = new ModelIdentifierManager();
        }

        public void FinalizeLoad()
        {
            //IdmStaticModule.MIDM = new MainFacadeOfIdentifierManager(modelIdentifierManager);
        }

        public void RegisterId(EIdentifierType identifiertype, ushort identifier, string idname)
        {
            modelIdentifierManager.RegisterId(EIdentifierType.ModelId, identifier, idname);
        }
    }
}
