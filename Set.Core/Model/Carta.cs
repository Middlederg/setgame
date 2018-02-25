using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set.Core.Model
{
    public class Carta
    {
	    public int Numero { get; set; }
        public Color ColorCarta { get; set; }
        public Shape Forma { get; set; }
        public Shading Interior { get; set; }

        /// <summary>
        /// Para el modo principiante, todas las figuras tienen fondo relleno (solid)
        /// </summary>
        /// <param name="numero"></param>
        /// <param name="color"></param>
        /// <param name="interior"></param>
        /// <param name="forma"></param>
        public Carta(int numero, Color color,  Shape forma, Shading interior = Shading.Solid)
	    {
		    Numero = numero;
		    ColorCarta = color;
            Forma = forma;
            Interior = interior;
	    }

        public int Id() => Numero * 1000 + ((int)ColorCarta + 1) * 100 + ((int)Forma + 1) * 10 + ((int)Interior + 1) * 1;

        public string Ruta() => Forma.ToString().ToLower().First() + Interior.ToString().ToLower().Substring(0, 2) + ColorCarta.ToString();

	    public override string ToString() => Numero + " " + ColorCarta.ToString() + " " + Interior.ToString() + " " + Forma.ToString(); 

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            var carta = obj as Carta;
            return (carta.Numero == Numero && carta.ColorCarta.Equals(ColorCarta) && carta.Forma.Equals(Forma) && carta.Interior.Equals(Interior));
        }

        public override int GetHashCode() => Numero.GetHashCode();
    }
}
