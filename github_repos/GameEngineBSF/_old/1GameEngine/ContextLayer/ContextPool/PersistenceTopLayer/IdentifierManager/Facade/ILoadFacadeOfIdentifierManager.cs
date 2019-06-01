using GameEngine.ContextPool.Enums;
using System;

namespace GameEngine.ContextPool.PersistenceTopLayer.IdentifierManager.Facade
{
    public interface ILoadFacadeOfIdentifierManager
    {
        void Init();
        void RegisterId(EIdentifierType identifiertype, ushort identifier, string idname);
        void FinalizeLoad();
    }
}
