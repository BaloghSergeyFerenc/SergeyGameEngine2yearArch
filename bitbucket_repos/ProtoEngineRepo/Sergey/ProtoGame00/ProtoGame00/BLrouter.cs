using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoGame00
{
    internal class BLrouter
    {
        private InstanceManager im;
        private TypeManager tm;
        public BLrouter()
        {
            im = new InstanceManager();
            tm = new TypeManager(im);
        }

        internal int Create(byte type)
        {
            return tm.NewInstance(type);
        }

        internal object Get(int id)
        {
            return im.GetInstance(id);
        }
    }
}
