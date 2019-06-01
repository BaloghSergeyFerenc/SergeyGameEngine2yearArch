namespace GameEngine.ContextLayer.ContextPool.Context
{
    public interface IEngineModule
    {
        T GetLocalContextPovider<T>() where T : ILocalContextPovider;
    }
}
