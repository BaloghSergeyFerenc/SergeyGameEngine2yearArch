namespace PersistenceTopLayer.Interface
{
    public enum ChangedItem
    {
        Property,
        Action,
        Relation
    }

    public interface IChangeingParameters
    {
        ChangedItem WhatKind { get; }
        uint What { get; }
        object To { get; }
    }
}