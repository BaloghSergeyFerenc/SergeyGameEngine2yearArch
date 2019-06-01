using System;
using System.Collections.Generic;
using System.Text;

namespace PersistenceTopLayer.Model
{
    internal interface IModelInitializer
    {
        void Create(uint id, uint tid);
        void Update(IChangingParameters changingParameters);
    }
}
