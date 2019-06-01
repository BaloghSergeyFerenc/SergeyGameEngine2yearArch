namespace PersistenceTopLayer.ModelInstanceManager.Model
{
    internal class IntegerPropertyValue : IIntegerPropertyValue
    {
        public int Get { get; }
        public IntegerPropertyValue(int value)
        {
            Get = value;
        }
    }
}
