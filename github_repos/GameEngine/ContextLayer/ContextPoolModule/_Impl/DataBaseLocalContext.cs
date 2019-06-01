using GameEngine.RealPersistenceLayer.ConfigurationPersistence.Context;

namespace GameEngine.ContextLayer.ContextPoolModule._Impl
{
    internal class DataBaseLocalContext : IDataBaseLocalContext
    {
        public string GetDbNameWithPath
        {
            get { return @"Data Source=c:\trydb.db"; }
        }
    }
}
