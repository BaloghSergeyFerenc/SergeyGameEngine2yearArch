using PersistenceTopLayer.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace PersistenceTopLayer.Fake
{
    class ModelFacade : IModelFacade
    {
        private IDictionary<uint, IModelObject> m_ModelObjects;

        internal ModelFacade()
        {
            m_ModelObjects = new Dictionary<uint, IModelObject>();
        }

        public uint Create(uint tid)
        {
            Console.WriteLine($"----------> InstaceCreation requested: {tid}");
            return 0;
        }

        public void Delete(uint id)
        {
            Console.WriteLine($"----------> InstaceDeletion requested: {id}");
        }

        public IModelObject Read(uint id)
        {
            Console.WriteLine($"----------> InstaceRead requested: {id}");
            return new ModelObject();
        }

        public void Update(IChangeingParameters changeingParameters)
        {
            Console.WriteLine($"----------> InstaceModification requested.");
        }
    }
}
