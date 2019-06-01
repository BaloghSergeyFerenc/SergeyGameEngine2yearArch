namespace PersistenceTopLayer.ModelInstanceManager.Model
{
    internal interface IModificationDataCarrierInternal : IModificationDataCarrier
    {
        ushort Id { get; }
        TargetItemType TargetItemType { get; }
        ushort TargetId { get; }
        ModificationType ModificationType { get; }
        IModificationDetails ModificationDetails { get; }
    }
}