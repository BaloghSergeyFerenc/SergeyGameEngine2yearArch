using System;
using System.Collections.Generic;
using System.Linq;

namespace ProtoGame02
{
    public class InstanceManagerFacade
    {
        private InstanceManager im;

        public InstanceManagerFacade()
        {
            im = new InstanceManager();
        }

        public int Create(byte tid)
        {
            return im.Add(tid);
        }

        public Instance Read(int id)
        {
            return im.Get(id);
        }

        public bool Update(int id, string property, string value)
        {
            Instance temp = im.Get(id);
            return temp.PropertyChange(property, value);
        }

        public bool Delete(int id)
        {
            return im.Remove(id);
        }
    }

    internal class InstanceManager
    {
        private static int nextId;
        private IDictionary<int, Instance> m_instances;

        public InstanceManager()
        {
            m_instances = new Dictionary<int, Instance>();
            nextId = 0;
        }

        public int Add(byte tid)
        {
            m_instances.Add(nextId++, new Instance(tid, nextId));
            return nextId;
        }

        public Instance Get(int id)
        {
            if(m_instances.Keys.Contains(id))
            {
                return m_instances[id];
            }
            return null;
        }

        public bool Remove(int id)
        {
            return m_instances.Remove(id);
        }
    }

    public class Instance
    {
        public byte TypeId { get; private set; }
        public int Id { get; private set; }

        private string changeableProperty = "changeabale";
        private string propertyValue = "";
        internal Instance(byte tid, int id)
        {
            this.TypeId = tid;
            this.Id = id;
        }

        internal bool PropertyChange(string property, string value)
        {
            if(property == changeableProperty)
            {
                propertyValue = value;
                return true;
            }
            return false;
        }

        public string PropertyGet(string property)
        {
            if(changeableProperty == property)
            {
                return propertyValue;
            }
            return "";
        }

    }
}
