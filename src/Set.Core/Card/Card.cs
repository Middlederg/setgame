using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Set.Core
{
    public class Card : SimpleCard
    {
        public override Shading Shading { get; }

        public Card(int number, Background background, Shape shape, Shading shading) : base(number, background, shape)
        {
            Shading = shading;
        }
        public override string ToString() => $"{Number} {Background} {Shading} {Shape}";
    }
}
