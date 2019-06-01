namespace PersistenceTopLayer.IdentifierManager.Facade
{
    internal interface IModelIdentifierManager
    {
        ushort GetNewModelId();
        bool RegisterId(IdentifierType identifierType, ushort identifier, string idname);
    }
}
