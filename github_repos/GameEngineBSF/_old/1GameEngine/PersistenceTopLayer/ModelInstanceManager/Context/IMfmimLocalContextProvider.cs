using GameEngine.ContextLayer.ContextPool.Context;
using GameEngine.PersistenceTopLayer.ModelInstanceManager.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine.PersistenceTopLayer.ModelInstanceManager.Context
{
    interface IMfmimLocalContextProvider : ILocalContextPovider
    {
        IModelManager GetModelManager { get; }
        IPropertyFactory GetPropertyFactory { get; }
    }
}
