using System.Linq;

namespace Set.Core
{
    public class SimpleCard : ICard
    {
	    public int Number { get; }
        public Background Background { get; }
        public Shape Shape { get; }
        public virtual Shading Shading => Shading.Solid;

        public SimpleCard(int number, Background background,  Shape shape)
	    {
		    Number = number;
		    Background = background;
            Shape = shape;
	    }

        public int Id => Number * 1000 + ((int)Background + 1) * 100 + ((int)Shape + 1) * 10 + ((int)Shading + 1) * 1;
        public string Path => $"{Shape}{Shading}{Background}";
	    public override string ToString() => $"{Number} {Background} {Shape}"; 

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            var carta = obj as ICard;
            return (carta.Number == Number && carta.Background.Equals(Background) && carta.Shape.Equals(Shape) && carta.Shading.Equals(Shading));
        }

        public override int GetHashCode() => Path.GetHashCode();

        public ICard Copy() => new Card(Number, Background, Shape, Shading);
    }
}
