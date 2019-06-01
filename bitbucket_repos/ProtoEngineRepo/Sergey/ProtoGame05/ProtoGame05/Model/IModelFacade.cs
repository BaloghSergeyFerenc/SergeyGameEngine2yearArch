using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoGame05.Model
{
    interface IModelFacade
    {
        uint Create(uint tid);
        IModelObject Read(uint id);
        bool Update(uint id);
        bool Delete(uint id);
    }
}
