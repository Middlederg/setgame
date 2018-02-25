using System.ComponentModel;

namespace Set.Core.Model
{
    public enum Dificultad
    {
        [Description("En el modo tutorial, hay menos cartas, y puedes contar con una ayuda especial")]
        Tutorial = 0,
        Normal = 1,
    }
}
