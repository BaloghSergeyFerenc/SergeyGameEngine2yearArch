using PersistenceTopLayer.ModelInstanceManager.Model;

namespace PersistenceTopLayer.ModelInstanceManager.Facade
{
    internal class LoadFacadeOfModelInstanceManager : ILoadFacadeOfModelInstanceManager
    {
        private bool IsFinalized;
        IPropertyFactory propertyFactory;
        private IModelManager modelManager;

        public void Init()
        {
            propertyFactory = new PropertyFactory();
            modelManager = new ModelManager();
            IsFinalized = false;
        }

        public void Create(ushort id, ushort tid, ushort parentid)
        {
            if(!IsFinalized)
                modelManager.Create(id, tid, parentid);
        }

        public void FinalizeLoading()
        {
            IsFinalized = true;
            MimStaticModule.MIM = new MainFacadeOfModelInstanceManager(modelManager, propertyFactory);
        }

        public void Update(IModificationDataCarrier modificationdata)
        {
            if(!IsFinalized)
                modelManager.Update(modificationdata as IModificationDataCarrierInternal);
        }

        public IModificationDataCarrier GetNewModificationDataCarrier()
        {
            return new ModificationDataCarrier(propertyFactory);
        }
    }
}
