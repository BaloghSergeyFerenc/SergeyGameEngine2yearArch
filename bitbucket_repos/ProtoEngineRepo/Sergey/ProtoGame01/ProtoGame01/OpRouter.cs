using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoGame01
{
    class OpRouter
    {
        InstanceManager im;
        TypeManager tm;

        internal OpRouter()
        {
            im = new InstanceManager();
            tm = new TypeManager(im);
        }

        internal int Create(byte tid)
        {
            return tm.Load(tid);
        }

        internal Instance GetInstance(int id)
        {
            return im.Read(id);
        }

        internal void DeleteInstance(int id)
        {
            im.Delete(id);
        }

        internal void UpdateInstance(int id, IDictionary<string, string> props)
        {
            im.Update(id, props);
        }

        //PENDING
        internal void Save() { }

        
    }
}
