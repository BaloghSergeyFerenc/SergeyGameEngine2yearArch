using GameEngine.ContextPool.PersistenceTopLayer.ModelInstanceManager.Model;
using System.Collections;
using System.Collections.Generic;

namespace GameEngine.PersistenceTopLayer.ModelInstanceManager.Model
{
    internal class ModelProperties : IModelPropertiesInternal
    {
        private IDictionary<ushort, IModelProperty> modelProperties;

        public ModelProperties()
        {
            modelProperties = new Dictionary<ushort, IModelProperty>();
        }

        public void Add(IModelProperty modelProperty)
        {
            if (modelProperties.Keys.Contains(modelProperty.Pid))
            {
                modelProperties.Remove(modelProperty.Pid);
            }
            modelProperties.Add(modelProperty.Pid, modelProperty);
        }

        public IEnumerator<IModelProperty> GetEnumerator()
        {
            return modelProperties.Values.GetEnumerator();
        }

        public void Remove(ushort pid)
        {
            modelProperties.Remove(pid);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
