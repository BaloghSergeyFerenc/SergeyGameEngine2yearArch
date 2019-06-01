using GameEngine.ContextPool.Enums;
using GameEngine.ContextPool.PersistenceTopLayer.IdentifierManager.Facade;
using GameEngine.ContextPool.PersistenceTopLayer.ModelInstanceManager.Model;

namespace GameEngine.PersistenceTopLayer.ModelInstanceManager.Model
{
    internal class ModelFactory : IModelFactory
    {
        private ILoadFacadeOfIdentifierManager loadIdentifierManager;
        private IMainFacadeOfIdentifierManager mainIdentifierManager;

        public ModelFactory()
        {
            loadIdentifierManager = null;//IdmStaticModule.LIDM;//fix
        }

        public IModelObject Create(ushort id, ushort tid, ushort parentid)
        {
            //loadIdentifierManager.RegisterId(EIdentifierType.ModelId, id, string.Empty);
            return new ModelObject(id, tid, parentid);
        }

        public IModelObject Create(ushort tid, ushort parentid)
        {
            if (mainIdentifierManager == null)
            {
                mainIdentifierManager = null;//IdmStaticModule.MIDM;
            }

            return new ModelObject(mainIdentifierManager.GetNewModelId(), tid, parentid);
        }
    }
}
