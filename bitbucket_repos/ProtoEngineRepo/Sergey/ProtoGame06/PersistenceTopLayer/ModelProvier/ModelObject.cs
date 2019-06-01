using System;
using System.Collections.Generic;
using System.Text;

namespace PersistenceTopLayer.ModelProvier
{
    class ModelObject : IModelObject
    {
        public ModelObject()
        {
            Children = new List<uint>();
            Properties = new Dictionary<uint, string>();
            Actions = new List<uint>();
        }

        public uint Tid
        {
            get;
            internal set;
        }

        public uint Id
        {
            get;
            internal set;
        }

        public uint Parent
        {
            get;
            internal set;
        }

        public IList<uint> Children
        {
            get;
        }

        public IDictionary<uint, string> Properties
        {
            get;
        }

        public IList<uint> Actions
        {
            get;
        }
    }
}
