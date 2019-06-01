using ProtoGame05.FakeThings;
using ProtoGame05.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoGame05.Configuration
{
    interface IConfigurationHandler
    {
        IModelFacade Load(FakeContext ctx);
        bool Save();
    }
}
