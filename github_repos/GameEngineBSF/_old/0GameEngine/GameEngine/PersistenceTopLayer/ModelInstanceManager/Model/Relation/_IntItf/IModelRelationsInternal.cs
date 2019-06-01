namespace PersistenceTopLayer.ModelInstanceManager.Model
{
    internal interface IModelRelationsInternal : IModelRelations
    {
        void Add(IModelRelation modelRelation);
        void Remove(IModelRelation modelRelation);
    }
}
