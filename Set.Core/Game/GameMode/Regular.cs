namespace Set.Core
{
    public class Regular : GameMode
    {
        public override string Description => $"En el modo {Name} jugamos con todas las cartas, y no hay ayudas";
        protected override string Name => "Normal";
    }
}
