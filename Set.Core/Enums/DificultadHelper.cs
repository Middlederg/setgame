using System;

namespace Set.Core.Enums
{
    public static class DificultadHelper
    {
        public static int NumeroMaximo(this Dificultad dif)
        {
            Type type = dif.GetType();
            OpcionesAttribute atributo = Attribute.GetCustomAttribute(type.GetField(Enum.GetName(typeof(Dificultad), dif)),
                               typeof(OpcionesAttribute)) as OpcionesAttribute;
            return atributo.MaxCartas;
        }

    }
}
