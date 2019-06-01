using System.Collections.Generic;
using PersistenceTopLayer.ModelInstanceManager.Facade;
using PersistenceTopLayer.ModelInstanceManager.Model;
using RealPersistenceLayer.ConfigurationPersistence.Facade;
using RealPersistenceLayer.ConfigurationPersistence.ModelReading;

namespace PersistenceTopLayer.ConfigurationHandler.Load
{
    internal class DataLoader : IDataLoader
    {
        public void ProcessActionData(IReaderFacadeOfConfigurationPersistence persistenceaccess, ILoadFacadeOfModelInstanceManager modelaccess)
        {
            IActionDataSet data = persistenceaccess.ReadActionData();
            foreach(IActionData item in data)
            {
                IModificationDataCarrier modification = modelaccess.GetNewModificationDataCarrier();
                modification.InitForActionChange(item.Id, item.Aid, ModificationType.Add);
                modelaccess.Update(modification);
            }
        }

        public void ProcessCreationalData(IReaderFacadeOfConfigurationPersistence persistenceaccess, ILoadFacadeOfModelInstanceManager modelaccess)
        {
            IDictionary<ushort, ushort> childParent = new Dictionary<ushort, ushort>();
            ICreateDataSet data = persistenceaccess.ReadCreateData();
            foreach(ICreateData item in data)
            {
                modelaccess.Create(item.Id, item.Tid, item.ParentId);
                childParent.Add(item.Id, item.ParentId);
            }

            foreach(KeyValuePair<ushort, ushort> cp in childParent)
            {
                IModificationDataCarrier modification = modelaccess.GetNewModificationDataCarrier();
                modification.InitForParentChange(cp.Key, cp.Value);
                modelaccess.Update(modification);
            }
        }

        public void ProcessPropertyData(IReaderFacadeOfConfigurationPersistence persistenceaccess, ILoadFacadeOfModelInstanceManager modelaccess)
        {
            IBooleanPropertyDataSet dataBool = persistenceaccess.ReadBooleanPropertyData();
            foreach(IBooleanPropertyData item in dataBool)
            {
                IModificationDataCarrier modification = modelaccess.GetNewModificationDataCarrier();
                modification.InitForBooleanPropertyChange(item.Id, item.Pid, ModelPropertyType.mpBoolean, ModificationType.Add, item.Value);
                modelaccess.Update(modification);
            }

            IStringPropertyDataSet dataStr = persistenceaccess.ReadStringPropertyData();
            foreach (IStringPropertyData item in dataStr)
            {
                IModificationDataCarrier modification = modelaccess.GetNewModificationDataCarrier();
                modification.InitForStringPropertyChange(item.Id, item.Pid, ModelPropertyType.mpBoolean, ModificationType.Add, item.Value);
                modelaccess.Update(modification);
            }

            IIntegerPropertyDataSet dataInt = persistenceaccess.ReadIntegerPropertyData();
            foreach (IIntegerPropertyData item in dataInt)
            {
                IModificationDataCarrier modification = modelaccess.GetNewModificationDataCarrier();
                modification.InitForIntegerPropertyChange(item.Id, item.Pid, ModelPropertyType.mpBoolean, ModificationType.Add, item.Value);
                modelaccess.Update(modification);
            }
        }

        public void ProcessRelationData(IReaderFacadeOfConfigurationPersistence persistenceaccess, ILoadFacadeOfModelInstanceManager modelaccess)
        {
            IRelationDataSet data = persistenceaccess.ReadRelationData();
            foreach(IRelationData item in data)
            {
                IModificationDataCarrier modification = modelaccess.GetNewModificationDataCarrier();
                modification.InitForRelationChange(item.Id, item.Rid, item.RelatedId, ModificationType.Add);
                modelaccess.Update(modification);
            }
        }
    }
}
