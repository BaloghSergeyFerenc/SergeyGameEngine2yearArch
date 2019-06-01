namespace ConfigurationPersistence
{
    public interface IParentRelationReader
    {
        bool Next();
        void Read(out uint childId, out uint parentId);
    }
}