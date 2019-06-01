using ProtoGame04.InstanceManager.ModelInitializer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProtoGame04.InstanceManager
{
    public enum ConfigModel
    {
        ProtoModel1,
        ProtoModel2
    }

    public class InstanceManagerFacade : IInstanceManagerFacade
    {
        public IDictionary<uint, IInstance> instances;
        public InstanceManagerFacade(ConfigModel model)
        {
            switch(model)
            {
                case ConfigModel.ProtoModel1:
                    instances = (new ProtoModel1()).InitModel();
                    break;
                case ConfigModel.ProtoModel2:
                    instances = (new ProtoModel2()).InitModel();
                    break;
                default:
                    instances = new Dictionary<uint, IInstance>();
                    break;
            }
        }

        public uint Create(uint tid)
        {
            Debug.Assert(false, "Create method in InstanceManagerFacade has no implmentation yet.");
            return 0;
        }

        public IInstance Read(uint id)
        {
            return instances[id];
        }

        public bool Delete(uint id)
        {
            Debug.Assert(false, "Create method in InstanceManagerFacade has no implmentation yet.");
            return false;
        }

        public bool Update(uint id) //Needs more argument about new values
        {
            Debug.Assert(false, "Create method in InstanceManagerFacade has no implmentation yet.");
            return false;
        }
    }
}
