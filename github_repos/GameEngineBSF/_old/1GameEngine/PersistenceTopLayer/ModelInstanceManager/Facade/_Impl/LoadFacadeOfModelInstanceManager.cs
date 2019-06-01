using GameEngine.ContextLayer.ContextPool.Context;
using GameEngine.ContextPool.PersistenceTopLayer.ModelInstanceManager.Facade;
using GameEngine.ContextPool.PersistenceTopLayer.ModelInstanceManager.Model;
using GameEngine.PersistenceTopLayer.ModelInstanceManager.Context;
using GameEngine.PersistenceTopLayer.ModelInstanceManager.Model;

namespace GameEngine.PersistenceTopLayer.ModelInstanceManager.Facade
{
    internal class LoadFacadeOfModelInstanceManager : ILoadFacadeOfModelInstanceManager
    {
        private bool IsFinalized;
        private IPropertyFactory propertyFactory;
        private IModelManager modelManager ;
        private ILfmimLocalContextProvider lfmimLocalContextProvider;

        public LoadFacadeOfModelInstanceManager(ILfmimLocalContextProvider lfmimlocalcontextprovider)
        {
            lfmimLocalContextProvider = lfmimlocalcontextprovider;
            propertyFactory = lfmimLocalContextProvider.GetPropertyFactory;
            modelManager = lfmimLocalContextProvider.GetModelManager;
            IsFinalized = false;
        }

        public void Create(ushort id, ushort tid, ushort parentid)
        {
            if (!IsFinalized)
                modelManager.Create(id, tid, parentid);
        }

        public void FinalizeLoading()
        {
            IsFinalized = true;
            //MimStaticModule.MIM = new MainFacadeOfModelInstanceManager(modelManager, propertyFactory);
        }

        public void Update(IModificationDataCarrier modificationdata)
        {
            if (!IsFinalized)
                modelManager.Update(modificationdata as IModificationDataCarrierInternal);
        }

        public IModificationDataCarrier GetNewModificationDataCarrier()
        {
            return new ModificationDataCarrier(propertyFactory);
        }

        public T GetLocalContextPovider<T>() where T : ILocalContextPovider
        {
            if (!(lfmimLocalContextProvider is T))
            {
                return default(T);
            }
            return (T)lfmimLocalContextProvider;
        }
    }
}
