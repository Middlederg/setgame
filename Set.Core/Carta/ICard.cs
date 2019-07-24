namespace Set.Core
{
    public interface ICard
    {
        Background Background { get; }
        int Id { get; }
        int Number { get; }
        string Ruta { get; }
        Shading Shading { get; }
        Shape Shape { get; }
    }
}