using GameEngine.ContextPool.ContextLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine.RealPersistenceLayer.ConfigurationPersistence.Context
{
    internal enum CpLocalContextType
    {
        Rfcp
    }

    internal interface IRfcpLocalConextProvider : ILocalContextPovider
    {
        IDataBaseLocalContext Get(CpLocalContextType cplocalcontexttype);
    }
}
