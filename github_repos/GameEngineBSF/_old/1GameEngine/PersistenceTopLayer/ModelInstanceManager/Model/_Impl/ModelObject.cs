using GameEngine.ContextPool.PersistenceTopLayer.ModelInstanceManager.Model;

namespace GameEngine.PersistenceTopLayer.ModelInstanceManager.Model
{
    internal class ModelObject : IModelObject
    {
        public ushort Id { get; }

        public ushort Tid { get; }

        public ushort Parent { get; internal set; }//fix

        public IModelChildren ModelChildren { get; }

        public IModelActions ModelActions { get; }

        public IModelRelations ModelRelations { get; }

        public IModelProperties ModelProperties { get; }

        public ModelObject(ushort id, ushort tid, ushort parentid)
        {
            Id = id;
            Tid = tid;
            Parent = parentid;
            ModelChildren = new ModelChildren();
            ModelActions = new ModelActions();
            ModelRelations = new ModelRelations();
            ModelProperties = new ModelProperties();
        }
    }
}
