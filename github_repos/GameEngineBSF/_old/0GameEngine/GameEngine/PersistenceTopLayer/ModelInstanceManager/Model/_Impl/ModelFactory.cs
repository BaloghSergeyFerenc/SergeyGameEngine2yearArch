using PersistenceTopLayer.IdentifierManager;
using PersistenceTopLayer.IdentifierManager.Facade;

namespace PersistenceTopLayer.ModelInstanceManager.Model
{
    internal class ModelFactory : IModelFactory
    {
        private ILoadFacadeOfIdentifierManager loadIdentifierManager;
        private IMainFacadeOfIdentifierManager mainIdentifierManager;

        public ModelFactory()
        {
            loadIdentifierManager = IdmStaticModule.LIDM;//fix
        }

        public IModelObject Create(ushort id, ushort tid, ushort parentid)
        {
            loadIdentifierManager.RegisterId(IdentifierType.ModelId, id, string.Empty);
            return new ModelObject(id, tid, parentid);
        }

        public IModelObject Create(ushort tid, ushort parentid)
        {
            if(mainIdentifierManager == null)
            {
                mainIdentifierManager = IdmStaticModule.MIDM;
            }
            return new ModelObject(mainIdentifierManager.GetNewModelId(), tid, parentid);
        }
    }
}
