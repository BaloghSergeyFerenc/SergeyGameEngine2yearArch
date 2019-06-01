using GameEngine.ContextPool.Enums;

namespace GameEngine.PersistenceTopLayer.IdentifierManager.Facade
{
    internal interface IModelIdentifierManager
    {
        ushort GetNewModelId();
        bool RegisterId(EIdentifierType identifierType, ushort identifier, string idname);
    }
}
