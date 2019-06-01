using System.Collections;
using System.Collections.Generic;

namespace GameEngine.PersistenceTopLayer.ModelInstanceManager.Model
{
    internal class ModelChildren : IModelChildrenInternal
    {
        private IList<ushort> modelChildren;

        public ModelChildren()
        {
            modelChildren = new List<ushort>();
        }

        public void Add(ushort id)
        {
            modelChildren.Add(id);
        }

        public IEnumerator<ushort> GetEnumerator()
        {
            return modelChildren.GetEnumerator();
        }

        public void Remove(ushort id)
        {
            modelChildren.Remove(id);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
