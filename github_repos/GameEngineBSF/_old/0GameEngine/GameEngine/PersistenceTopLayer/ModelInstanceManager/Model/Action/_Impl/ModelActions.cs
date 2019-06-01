using System.Collections;
using System.Collections.Generic;

namespace PersistenceTopLayer.ModelInstanceManager.Model
{
    internal class ModelActions : IModelActionsInternal
    {
        private IList<ushort> modelActions;

        public ModelActions()
        {
            modelActions = new List<ushort>();
        }

        public void Add(ushort aid)
        {
            modelActions.Add(aid);
        }

        public IEnumerator<ushort> GetEnumerator()
        {
            return modelActions.GetEnumerator();
        }

        public void Remove(ushort aid)
        {
            modelActions.Remove(aid);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
