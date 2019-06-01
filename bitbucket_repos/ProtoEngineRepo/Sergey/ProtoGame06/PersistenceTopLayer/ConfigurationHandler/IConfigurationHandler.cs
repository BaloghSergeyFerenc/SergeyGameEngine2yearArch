using PersistenceTopLayer.ModelProvier;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersistenceTopLayer.ConfigurationHandler
{
    public interface IConfigurationHandler
    {
        IModelFacade Load();
        //bool Save();
    }
}
