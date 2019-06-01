using System;
using System.Collections.Generic;
using System.Text;
using PersistenceTopLayer.ModelProvier;

namespace PersistenceTopLayer.ConfigurationHandler
{
    public class ConfigurationHandler : IConfigurationHandler
    {
        public IModelFacade Load()
        {
            return new ModelFacade(ConfigModel.ProtoModel1);
        }
    }
}
