using System;
using System.Collections.Generic;
using System.Text;

namespace PersistenceTopLayer.Model
{
    //public enum ChangedItem
    //{
    //    Property,
    //    Action,
    //    Parent,
    //    Child,
    //    Relation
    //}

    //public interface IChangingParameters
    //{
    //    ChangedItem WhatKind { get; }
    //    uint What { get; }
    //    string To { get; }
    //}

    //public class ChangingParameters : IChangingParameters
    //{
    //    public ChangingParameters(ChangedItem changed, uint what, string to)
    //    {
    //        this.WhatKind = changed;
    //        this.What = what;
    //        this.To = to;
    //    }

    //    public ChangedItem WhatKind { get; }

    //    public uint What { get; }

    //    public string To { get; }
    //}




    public enum ChangeType
    {
        Parent,
        Delete,
        Action,
        Relation,
        Property
    }

    public interface IChangingParameters
    {
        uint Id { get; }
        IChangeData ChangeData { get; }
    }

    public interface IChangeData
    {
        ChangeType Changed { get; }
        uint Id { get; }
    }

    public class ChangingParameters : IChangingParameters
    {
        public uint Id { get; }
        public IChangeData ChangeData { get; }
        public ChangingParameters(uint id, IChangeData changeData)
        {
            this.Id = id;
            this.ChangeData = changeData;
        }
    }

    public class ParentChangeData : IChangeData
    {
        private readonly uint newParentId;
        public ChangeType Changed { get { return ChangeType.Parent; } }
        public uint Id { get { return 0; } }
        public ParentChangeData(uint newParentId)
        {
            this.newParentId = newParentId;
        }
    }

    public class DeleteChangeData : IChangeData
    {
        public uint Id { get { return 0; } }
        public ChangeType Changed { get { return ChangeType.Delete; } }
    }

    public class ActionChangeData : IChangeData
    {
        private readonly ActionModified actionModified;
        public enum ActionModified
        {
            Add,
            Removed
        }
        public uint Id { get; }
        public ChangeType Changed { get { return ChangeType.Action; } }
        public ActionChangeData(uint id, ActionModified actionModified)
        {
            this.Id = id;
            this.actionModified = actionModified;
        }
    }

    public class PropertyChangeData : IChangeData
    {
        private readonly PropertyModified propertyModified;
        private readonly string value;
        public enum PropertyModified
        {
            Add,
            Remove,
            Modifiy
        }
        public uint Id { get; }
        public ChangeType Changed { get { return ChangeType.Property; } }
        public PropertyChangeData(uint id, PropertyModified propertyModified, string value)
        {
            this.Id = id;
            this.propertyModified = propertyModified;
            this.value = value;
        }
    }
}
