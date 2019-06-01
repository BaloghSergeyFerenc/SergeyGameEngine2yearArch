using GameEngine.ContextLayer.ContextPoolModule.Enums;
using GameEngine.ContextLayer.ContextPool.Context;
using System;


namespace GameEngine.ContextLayer.ContextPoolModule.ModuleManager
{
    public interface IModuleStorage
    {
        T GetModule<T>() where T : IEngineModule;
        void FinalizeModule<T>(T enginemodule) where T : IEngineModule;
        void FinalizeAllModules();
    }
}
