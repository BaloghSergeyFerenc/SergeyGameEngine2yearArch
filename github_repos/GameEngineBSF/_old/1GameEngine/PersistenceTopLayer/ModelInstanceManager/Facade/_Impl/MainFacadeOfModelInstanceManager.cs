using GameEngine.ContextLayer.ContextPool.Context;
using GameEngine.ContextPool.PersistenceTopLayer.ModelInstanceManager.Facade;
using GameEngine.ContextPool.PersistenceTopLayer.ModelInstanceManager.Model;
using GameEngine.PersistenceTopLayer.ModelInstanceManager.Context;
using GameEngine.PersistenceTopLayer.ModelInstanceManager.Model;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("GameEngine.ContextLayer.ContextPoolModule")]
namespace GameEngine.PersistenceTopLayer.ModelInstanceManager.Facade
{
    internal class MainFacadeOfModelInstanceManager : IMainFacadeOfModelInstanceManager
    {
        private IMfmimLocalContextProvider mfmimLocalContextProvider;
        private IPropertyFactory propertyFactory;
        private IModelManager modelManager;

        public MainFacadeOfModelInstanceManager(IMfmimLocalContextProvider mfmimlocalcontextprovider)
        {
            mfmimLocalContextProvider = mfmimlocalcontextprovider;
            propertyFactory = mfmimLocalContextProvider.GetPropertyFactory;
            modelManager = mfmimLocalContextProvider.GetModelManager;
        }

        public void Create(ushort tid, ushort parentid)
        {
            modelManager.Create(tid, parentid);
        }

        public void Delete(ushort id)
        {
            modelManager.Delete(id);
        }

        public T GetLocalContextPovider<T>() where T : ILocalContextPovider
        {
            if (!(mfmimLocalContextProvider is T))
            {
                return default(T);
            }
            return (T)mfmimLocalContextProvider;
        }

        public IModificationDataCarrier GetNewModificationDataCarrier()
        {
            return new ModificationDataCarrier(propertyFactory);
        }

        public IModelObject Read(ushort id)
        {
            return modelManager.Read(id);
        }

        public void Update(IModificationDataCarrier modificationdata)
        {
            modelManager.Update(modificationdata as IModificationDataCarrierInternal);
        }
    }
}
