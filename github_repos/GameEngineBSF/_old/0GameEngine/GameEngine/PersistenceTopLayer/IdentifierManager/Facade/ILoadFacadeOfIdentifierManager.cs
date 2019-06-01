namespace PersistenceTopLayer.IdentifierManager.Facade
{
    public interface ILoadFacadeOfIdentifierManager
    {
        void Init();
        void RegisterId(IdentifierType identifiertype, ushort identifier, string idname);
        void FinalizeLoad();
    }
}
