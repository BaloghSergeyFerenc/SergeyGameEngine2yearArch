using GameEngine.ContextLayer.ContextPoolModule.ContextData;
using GameEngine.ContextLayer.ContextPoolModule.Enums;
using GameEngine.ContextLayer.ContextPool.Context;
using System;

namespace GameEngine.ContextLayer.ContextPoolModule.ModuleManager
{
    public interface IModuleFactory
    {
        IEngineModule Create(Type type, IModuleStorage modulestorage, IContextDataReader contextdatareader);
    }
}