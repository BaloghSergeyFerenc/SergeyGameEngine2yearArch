using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine.ContextPool.PersistenceTopLayer.ModelInstanceManager.Model
{
    public interface IModelRelation
    {
        ushort Rid { get; }
        ushort Id { get; }
    }
}
