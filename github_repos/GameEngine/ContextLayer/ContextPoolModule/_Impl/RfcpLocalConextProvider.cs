using GameEngine.RealPersistenceLayer.ConfigurationPersistence.Context;

namespace GameEngine.ContextLayer.ContextPoolModule._Impl
{
    internal class RfcpLocalConextProvider : IRfcpLocalConextProvider
    {
        private IDataBaseLocalContext dataBaseLocalContext;
        public IDataBaseLocalContext Get(CpLocalContextType cplocalcontexttype)
        {
            if (dataBaseLocalContext == null)
            {
                dataBaseLocalContext = new DataBaseLocalContext();
            }
            return dataBaseLocalContext;
        }
    }
}
