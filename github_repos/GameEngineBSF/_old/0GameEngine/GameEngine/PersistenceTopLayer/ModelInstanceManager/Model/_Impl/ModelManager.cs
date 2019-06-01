namespace PersistenceTopLayer.ModelInstanceManager.Model
{
    internal class ModelManager : IModelManager
    {
        private IModelFactory factory;
        private IModelRepository repository;
        private IModelModifier modifier;

        public ModelManager()
        {
            factory = new ModelFactory();
            repository = new ModelRepository();
            modifier = new ModelModifier();
        }

        public IModelObject Create(ushort id, ushort tid, ushort parentid)
        {
            repository.Add(factory.Create(id, tid, parentid));
            return repository.Get(id);
        }

        public IModelObject Create(ushort tid, ushort parentid)
        {
            return repository.Get(
                repository.Add(
                    factory.Create(tid, parentid)));
        }

        public void Delete(ushort id)
        {
            repository.Remove(id);
        }

        public IModelObject Read(ushort id)
        {
            return repository.Get(id);
        }

        public void Update(IModificationDataCarrierInternal modificationdata)
        {
            modifier.Update(repository.Get(modificationdata.Id), modificationdata, repository);
        }
    }
}
