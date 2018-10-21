using System;
using System.ComponentModel;

namespace Set.Core.Enums
{
    public enum Dificultad
    {
        [Opciones(27)]
        [Description("En el modo tutorial solo tenemos en cuenta las cartas con fondo sólido. " +
            "Además, puedes contar con la ayuda especial si te quedas atascado")]
        Tutorial = 0,

        [Opciones(81)]
        [Description("En el modo sencillo puedes contar con la ayuda especial si te quedas atascado")]
        Sencillo = 1,

        [Opciones(81)]
        [Description("En el modo normal jugamos con todas las cartas, y no hay ayudas")]
        Normal = 2,
    }

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
