using System.Collections.Generic;

namespace PersistenceTopLayer.ModelInstanceManager.Model
{
    internal class ModelRepository : IModelRepository
    {
        private IDictionary<ushort, IModelObject> modelObjects;

        public ModelRepository()
        {
            modelObjects = new Dictionary<ushort, IModelObject>();
            modelObjects.Add(0, new ModelObject(0, 0, 0));
        }

        public ushort Add(IModelObject modelobject)
        {
            modelObjects.Add(modelobject.Id, modelobject);
            return modelobject.Id;
        }

        public IModelObject Get(ushort id)
        {
            return modelObjects[id];
        }

        public void Remove(ushort id)
        {
            modelObjects.Remove(id);
        }
    }
}
