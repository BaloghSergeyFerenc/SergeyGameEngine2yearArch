using PersistenceTopLayer.Interface;

namespace PersistenceTopLayer.Fake
{
    internal class PltSavingContext : IPtlSavingContext
    {
        public string SaveFileName { get; }

        public PltSavingContext(string saveFileName)
        {
            SaveFileName = saveFileName;
        }
    }
}