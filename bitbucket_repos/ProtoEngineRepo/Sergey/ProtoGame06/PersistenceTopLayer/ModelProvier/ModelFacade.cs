using PersistenceTopLayer.Fakes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace PersistenceTopLayer.ModelProvier
{
    internal enum ConfigModel
    {
        ProtoModel1,
        ProtoModel2
    }

    class ModelFacade : IModelFacade
    {
        public IDictionary<uint, IModelObject> instances;
        public ModelFacade(ConfigModel model)
        {
            switch (model)
            {
                case ConfigModel.ProtoModel1:
                    instances = (new ProtoModel1Fake()).InitModel();
                    break;
                case ConfigModel.ProtoModel2:
                    instances = (new ProtoModel2Fake()).InitModel();
                    break;
                default:
                    instances = new Dictionary<uint, IModelObject>();
                    break;
            }
        }

        public IModelObject Read(uint id)
        {
            return instances[id];
        }
    }
}
