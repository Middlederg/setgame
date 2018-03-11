using System;

namespace Set.Core.Enums
{
    public class OpcionesAttribute : Attribute
    {
        public int MaxCartas { get; set; }
        public OpcionesAttribute(int maxCartas)
        {
            MaxCartas = maxCartas;
        }
    }
}