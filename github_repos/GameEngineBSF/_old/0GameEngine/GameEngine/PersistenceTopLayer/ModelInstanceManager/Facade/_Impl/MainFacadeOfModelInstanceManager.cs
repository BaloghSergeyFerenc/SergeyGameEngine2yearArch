using PersistenceTopLayer.ModelInstanceManager.Model;

namespace PersistenceTopLayer.ModelInstanceManager.Facade
{
    internal class MainFacadeOfModelInstanceManager : IMainFacadeOfModelInstanceManager
    {
        private IPropertyFactory propertyFactory;
        private IModelManager modelManager;

        public MainFacadeOfModelInstanceManager(IModelManager modelmanager, IPropertyFactory propertyfactory)
        {
            propertyFactory = propertyfactory;
            modelManager = modelmanager;
        }

        public void Create(ushort tid, ushort parentid)
        {
            modelManager.Create(tid, parentid);
        }

        public void Delete(ushort id)
        {
            modelManager.Delete(id);
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
