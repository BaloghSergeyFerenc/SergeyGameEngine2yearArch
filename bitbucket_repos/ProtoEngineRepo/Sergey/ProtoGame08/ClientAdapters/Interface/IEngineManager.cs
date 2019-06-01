namespace ClientAdapters.Interface
{
    interface IEngineManager
    {
        bool EngingeIsRunning { get; }
        IGameContext InitEngine(string jsonData);
        IAdapterProvider StartEngine();
        void Save(IGameContext gameContext);
        bool StopEnginge();
    }
}
