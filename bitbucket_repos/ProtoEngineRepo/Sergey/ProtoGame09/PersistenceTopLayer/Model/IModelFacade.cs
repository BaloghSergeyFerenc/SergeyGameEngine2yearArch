using System;
using System.Collections.Generic;
using System.Text;

namespace PersistenceTopLayer.Model
{
    public interface IModelFacade
    {
        uint Create(uint tid);
        IModelObject Read(uint id);
        void Update(IChangingParameters changeingParameters);//fix
        void Delete(uint id);//fix
    }
}
