using System;

namespace ProtoGame01
{
    internal class TypeManager
    {
        private InstanceManager im;

        internal TypeManager(InstanceManager im)
        {
            this.im = im;
        }

        internal int Load(byte tid)
        {
            return im.Create(tid);
        }

        //PENDING
        internal void Save(int id) { }
        internal int Load(int sid) { return 0; }
    }
}