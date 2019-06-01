namespace PersistenceTopLayer.Interface
{
    public interface ILoader
    {
        IModelFacade Load(IPtlLoadingContext ptlLoadingContext);
        IPtlSavingContext Save(IModelFacade modelFacade);
    }
}
