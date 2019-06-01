using PersistenceTopLayer.Interface;
using System;
using System.Diagnostics;

namespace PersistenceTopLayer.Fake
{
    public class Loader : ILoader
    {
        private IModelFacade m_ModelFacade;
        public IModelFacade Load(IPtlLoadingContext ptlLoadingContext)
        {
            Console.WriteLine("----------> Loading called.");
            m_ModelFacade = new ModelFacade();
            return m_ModelFacade;
        }

        public IPtlSavingContext Save(IModelFacade modelFacade)
        {
            if(modelFacade.Equals(m_ModelFacade))
                Console.WriteLine("----------> Valid Save called.");
            else
                Console.WriteLine("----------> Invalid Save called.");
            return new PltSavingContext("MockSaveFileName");
        }
    }
}
