using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Set.Core
{
    public class Card : SimpleCard
    {
        public override Shading Shading { get; }

        public Card(int numero, Background color, Shape forma, Shading shading) : base(numero, color, forma)
        {
            Shading = shading;
        }
        public override string ToString() => $"{Number} {Background.ToString()} {Shading.ToString()} {Shape.ToString()}";
    }
}
