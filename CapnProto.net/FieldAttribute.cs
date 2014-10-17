﻿using System;

namespace CapnProto
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class FieldAttribute : Attribute
    {
        public FieldAttribute(int number)
        {
            this.Number= number;
            Offset = Pointer = -1;
        }
        public int Number { get; private set; }
        public int Offset { get; set; }
        public int Pointer { get; set; }
    }
}