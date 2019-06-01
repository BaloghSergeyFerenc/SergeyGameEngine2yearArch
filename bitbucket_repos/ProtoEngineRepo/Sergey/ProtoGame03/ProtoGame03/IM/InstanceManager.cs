using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoGame03.IM
{
    class InstanceManager
    {
        public uint Create(uint Tid)
        {
            return 0;
        }
        public IInstance Read(uint Id)
        {
            switch(Id)
            {
                case 1:
                    return new Board();
                case 2:
                    return new Field();
                case 3:
                    return new Figure();
                default:
                    return null;
            }
        }
        public void Update(uint Id)
        {
        }
        public void Delete(uint Id)
        {
        }
    }
}
