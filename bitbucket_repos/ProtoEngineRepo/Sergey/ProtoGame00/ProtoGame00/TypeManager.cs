using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoGame00
{
    internal class TypeManager
    {
        InstanceManager im;
        internal TypeManager(InstanceManager im)
        {
            this.im = im;
        }

        internal int NewInstance(byte type)
        {
            return type == (byte)5 ? im.NewInstance(type) : 0;
        }
    }
}
