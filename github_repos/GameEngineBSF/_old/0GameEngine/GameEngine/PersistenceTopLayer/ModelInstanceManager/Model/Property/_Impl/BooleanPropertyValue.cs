﻿namespace PersistenceTopLayer.ModelInstanceManager.Model
{
    internal class BooleanPropertyValue : IBooleanPropertyValue
    {
        public bool Get { get; }
        public BooleanPropertyValue(bool value)
        {
            Get = value;
        }
    }
}
