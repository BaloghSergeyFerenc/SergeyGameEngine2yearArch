using PersistenceTopLayer.ModelInstanceManager.Model;

namespace PersistenceTopLayer.ModelInstanceManager.Facade
{
    public interface ILoadFacadeOfModelInstanceManager
    {
        void Init();
        void Create(ushort id, ushort tid, ushort parentid);
        void Update(IModificationDataCarrier modificationdata);
        void FinalizeLoading();
        IModificationDataCarrier GetNewModificationDataCarrier();
    }
}
