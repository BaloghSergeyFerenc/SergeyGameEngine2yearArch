using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoGame00
{
    internal class InstanceManager
    {
        private Instance instance;
        internal int NewInstance(byte type)
        {
            instance = new Instance(type, 1);
            return 1;
        }
        internal object GetInstance(int id)
        {
            return instance?.id == id ? instance : null;
        }
    }

    internal class Instance
    {
        internal byte type { get; }
        internal int id { get; }
        internal Instance(byte type, int id)
        {
            this.type = type;
            this.id = id;
        }
    }
}
