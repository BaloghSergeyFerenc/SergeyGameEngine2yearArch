using System;
using System.Collections;
using System.Collections.Generic;

namespace ProtoGame01
{
    public class ClientServer
    {
        internal OpRouter opRouter { get; set; }
        public ClientServer()
        {
            opRouter = new OpRouter();
            GetCreatorAdapter = new FakeAdapterCreate(this);
            GetGetterAdapter = new FakeAdapterGet(this);
            DeletionAdapter = new FakeAdapterDelete(this);
        }

        public FakeAdapterCreate GetCreatorAdapter { get; }
        public FakeAdapterGet GetGetterAdapter { get; }
        public FakeAdapterDelete DeletionAdapter { get; }
    }

    public class FakeAdapterCreate
    {
        private readonly ClientServer parent;
        private const byte tid = 1;

        internal FakeAdapterCreate(ClientServer parent)
        {
            this.parent = parent;
        }

        public int Create
        {
            get => CreateInternal();
        }

        private int CreateInternal()
        {
            return parent.opRouter.Create(tid);
        }
    }

    public class FakeAdapterGet
    {
        private readonly ClientServer parent;

        internal FakeAdapterGet(ClientServer parent)
        {
            this.parent = parent;
        }

        public FakeAdapterInstance GetInstance(int id)
        {
            return GetInstanceInternal(id);
        }

        private FakeAdapterInstance GetInstanceInternal(int id)
        {
            Instance temp = parent.opRouter.GetInstance(id);
            if (temp == null)
                return null;
            return new FakeAdapterInstance(parent, temp);
        }
    }

    public class FakeAdapterInstance
    {
        private readonly ClientServer parent;
        private string m_PropertyToChange;
        IDictionary<string, string> PropertyToSend;

        internal FakeAdapterInstance(ClientServer parent, Instance instance)
        {
            PropertyToSend = new Dictionary<string, string>();
            PropertyToSend.Add("xProp", PropertyToChange);
            this.parent = parent;
            m_PropertyToChange = instance.PropertyToChange;
            TypeId = instance.TypeId;
            Id = instance.Id;
        }

        public string PropertyToChange
        {
            get
            {
                return m_PropertyToChange;
            }
            set
            {
                m_PropertyToChange = value;
                PropertyToSend["xProp"] = value; 
                parent.opRouter.UpdateInstance(this.Id, PropertyToSend);
            }
        }

        public void Delete()
        {
            parent.opRouter.DeleteInstance(Id);
        }

        public byte TypeId
        {
            get;
        }
        public int Id
        {
            get;
        }
    }

    public class FakeAdapterDelete
    {
        private ClientServer parent;

        public FakeAdapterDelete(ClientServer parent)
        {
            this.parent = parent;
        }

        public void Delete(int id) => parent.opRouter.DeleteInstance(id);
    }
}
