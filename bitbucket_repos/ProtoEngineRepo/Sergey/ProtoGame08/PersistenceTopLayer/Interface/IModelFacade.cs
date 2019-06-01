namespace PersistenceTopLayer.Interface
{
    public interface IModelFacade
    {
        uint Create(uint tid);
        IModelObject Read(uint id);
        void Update(IChangeingParameters changeingParameters);
        void Delete(uint id);
    }
}