namespace GameEngine.ContextPool.ContextLayer
{
    public interface IEngineModule<T> where T : ILocalContextPovider
    {
        T GetLocalContextPovider { get; }
    }
}
