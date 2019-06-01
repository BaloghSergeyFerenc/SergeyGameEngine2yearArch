using System.Collections;
using System.Collections.Generic;

namespace PersistenceTopLayer.ModelInstanceManager.Model
{
    internal class ModelRelations : IModelRelationsInternal
    {
        private IList<IModelRelation> modelRelations;

        public ModelRelations()
        {
            modelRelations = new List<IModelRelation>();
        }

        public void Add(IModelRelation modelRelation)
        {
            modelRelations.Add(modelRelation);
        }

        public IEnumerator<IModelRelation> GetEnumerator()
        {
            return modelRelations.GetEnumerator();
        }

        public void Remove(IModelRelation modelRelation)
        {
                modelRelations.Remove(modelRelation);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
