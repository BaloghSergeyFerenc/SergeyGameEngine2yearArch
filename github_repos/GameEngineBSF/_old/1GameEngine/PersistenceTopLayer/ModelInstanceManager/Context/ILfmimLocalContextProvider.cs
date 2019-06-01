using GameEngine.ContextLayer.ContextPool.Context;
using GameEngine.ContextPool.PersistenceTopLayer.ModelInstanceManager.Facade;
using GameEngine.PersistenceTopLayer.ModelInstanceManager.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine.PersistenceTopLayer.ModelInstanceManager.Context
{
    internal interface ILfmimLocalContextProvider : ILocalContextPovider
    {
        IMainFacadeOfModelInstanceManager GetMainFacadeOfModelInstanceManager { get; }
        IModelManager GetModelManager { get; }
        IPropertyFactory GetPropertyFactory { get; }
    }
}
