using System;

namespace ProtoGame03.Adapters
{
    public enum SpecType
    {
        myInteger,
        myString,
        myBool
    }
    public interface IPropertyAdapter
    {
        string Name { get; }
        uint Id { get; }
        IModelAdapter Parent { get; }
        SpecType Ptid { get; }
        string Value { get; }
    }
}