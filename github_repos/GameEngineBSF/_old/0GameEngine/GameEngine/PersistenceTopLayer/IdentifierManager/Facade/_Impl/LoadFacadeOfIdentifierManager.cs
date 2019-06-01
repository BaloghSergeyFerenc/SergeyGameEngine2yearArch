namespace PersistenceTopLayer.IdentifierManager.Facade
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
            IdmStaticModule.MIDM = new MainFacadeOfIdentifierManager(modelIdentifierManager);
        }

        public void RegisterId(IdentifierType identifiertype, ushort identifier, string idname)
        {
            modelIdentifierManager.RegisterId(IdentifierType.ModelId, identifier, idname);
        }
    }
}
