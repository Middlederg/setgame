namespace Set.Core
{
    public class Tutorial : GameMode
    {
        public override string Description => $"En el modo {Name} solo tenemos en cuenta las cartas con fondo relleno. Además, puedes contar con la ayuda especial si te quedas atascado";
        protected override string Name => "Tutorial";
        public override int MaxCardNumber => GameOptions.DefaultMinCardNumber;
    }
}
