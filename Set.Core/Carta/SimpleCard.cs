using System.Linq;

namespace Set.Core
{
    public class SimpleCard : ICard
    {
	    public int Number { get; }
        public Background Background { get; }
        public Shape Shape { get; }
        public virtual Shading Shading => Shading.Solid;

        public SimpleCard(int numero, Background color,  Shape forma)
	    {
		    Number = numero;
		    Background = color;
            Shape = forma;
	    }

        public int Id => Number * 1000 + ((int)Background + 1) * 100 + ((int)Shape + 1) * 10 + ((int)Shading + 1) * 1;
        public string Ruta => $"{Shape.ToString().ToLower().First()}{Shading.ToString().ToLower().Substring(0, 2)}{Background.ToString()}";
	    public override string ToString() => $"{Number} {Background.ToString()} {Shape.ToString()}"; 

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            var carta = obj as Card;
            return (carta.Number == Number && carta.Background.Equals(Background) && carta.Shape.Equals(Shape) && carta.Shading.Equals(Shading));
        }

        public override int GetHashCode() => Number.GetHashCode();
    }
}
