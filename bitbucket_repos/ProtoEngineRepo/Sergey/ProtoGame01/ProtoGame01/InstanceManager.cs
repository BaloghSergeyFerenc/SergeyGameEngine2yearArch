using System;
using System.Collections;
using System.Collections.Generic;

namespace ProtoGame01
{
    internal class InstanceManager
    {
        private Instance ins;
        internal Instance Read(int id)
        {
            if(ins != null && id == 11)
            {
                return ins;
            }
            return null;
        }

        internal int Create(byte tid)
        {
            ins = new Instance(tid, 11);
            return 11;
        }

        internal void Update(int id, IDictionary<string, string> props)
        {
            if (ins.Id == id && props.ContainsKey("xProp"))
            {
                ins.PropertyToChange = props["xProp"];
            }
        }

        //PENDING
        internal void Delete(int id)
        {
            if(ins.Id == id)
            {
                ins = null;
            }
        }
    }

    internal class Instance
    {
        internal Instance(byte tid, int id)
        {
            this.TypeId = tid;
            this.Id = id;
            PropertyToChange = "nothing";
        }

        internal string PropertyToChange
        {
            get;
            set;
        }

        internal byte TypeId { get; private set; }
        internal int Id { get; private set; }
    }
}