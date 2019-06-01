namespace ConfigurationPersistence
{
    public  interface IActionDataReader
    {
        bool Next();
        void Read(out uint ownerId, out uint actionId);
    }
}