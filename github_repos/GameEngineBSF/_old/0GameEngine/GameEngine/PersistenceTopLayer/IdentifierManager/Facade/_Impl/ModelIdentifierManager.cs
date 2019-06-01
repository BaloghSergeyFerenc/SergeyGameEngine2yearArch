using System.Collections.Generic;

namespace PersistenceTopLayer.IdentifierManager.Facade
{
    internal class ModelIdentifierManager : IModelIdentifierManager
    {
        IDictionary<ushort, bool> identifiers;
        public ModelIdentifierManager()
        {
            identifiers = new Dictionary<ushort, bool>();
            for (ushort i = 0; i < ushort.MaxValue; i++)
            {
                identifiers.Add(i, false);
            }
            identifiers[0] = true;
        }

        public ushort GetNewModelId()
        {
            foreach (ushort id in identifiers.Keys)
            {
                if (identifiers[id] == true)
                {
                    identifiers[id] = false;
                    return id;
                }
            }
            return 0;
        }

        public bool RegisterId(IdentifierType identifierType, ushort identifier, string idname)
        {
            if (identifiers[identifier] == true)
            {
                identifiers[identifier] = false;
                return true;
            }
            return false;
        }
    }
}
