namespace ProtoGame04.InstanceManager
{
    public interface IInstanceManagerFacade
    {
        uint Create(uint tid);
        bool Delete(uint id);
        IInstance Read(uint id);
        bool Update(uint id);
    }
}