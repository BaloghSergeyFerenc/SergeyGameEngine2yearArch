using GameEngine.ContextPool.Enums;
using GameEngine.ContextPool.PersistenceTopLayer.ModelInstanceManager.Model;

namespace GameEngine.PersistenceTopLayer.ModelInstanceManager.Model
{
    internal interface IModificationDataCarrierInternal : IModificationDataCarrier
    {
        ushort Id { get; }
        ETargetItemType TargetItemType { get; }
        ushort TargetId { get; }
        EModificationType ModificationType { get; }
        IModificationDetails ModificationDetails { get; }
    }
}
