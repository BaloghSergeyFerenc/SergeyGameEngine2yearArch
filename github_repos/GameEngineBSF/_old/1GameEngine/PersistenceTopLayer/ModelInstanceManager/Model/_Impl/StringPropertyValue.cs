using GameEngine.ContextPool.PersistenceTopLayer.ModelInstanceManager.Model;

namespace GameEngine.PersistenceTopLayer.ModelInstanceManager.Model
{
    internal class StringPropertyValue : IStringPropertyValue
    {
        public string Get { get; }
        public StringPropertyValue(string value)
        {
            Get = value;
        }
    }
}
