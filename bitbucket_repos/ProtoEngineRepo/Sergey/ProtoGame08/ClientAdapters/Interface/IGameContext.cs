namespace ClientAdapters.Interface
{
    public interface IGameContext
    {
        uint RootObject { get; }
        string ConfigName { get; }
    }
}