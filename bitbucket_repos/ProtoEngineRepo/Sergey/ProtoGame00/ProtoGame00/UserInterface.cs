using System;

namespace ProtoGame00
{
    public class FakeAdapterCreate
    {
        private BLrouter bl;
        internal FakeAdapterCreate(BLrouter bl)
        {
            this.bl = bl;
        }
        public int Create(byte type)
        {
            return bl.Create(type);
        }
    }

    public class FakeAdapterGet
    {
        private BLrouter bl;
        internal FakeAdapterGet(BLrouter bl)
        {
            this.bl = bl;
        }
        public object Get(int id)
        {
            return bl.Get(id);
        }
    }

    public class UIfacade
    {
        private BLrouter blr;
        private FakeAdapterCreate fac;
        private FakeAdapterGet fag;
        public UIfacade()
        {
            blr = new BLrouter();
            fac = new FakeAdapterCreate(blr);
            fag = new FakeAdapterGet(blr);
        }
        public FakeAdapterCreate adapterCreate
        {
            get { return fac; }
        }
        public FakeAdapterGet adapterGet
        {
            get { return fag; }
        }
    }
}
