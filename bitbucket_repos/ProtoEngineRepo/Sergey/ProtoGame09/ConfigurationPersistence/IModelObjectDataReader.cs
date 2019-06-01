namespace ConfigurationPersistence
{
    public interface IModelObjectDataReader
    {
        bool Next();
        void Read(out uint id, out uint tid);
    }
}