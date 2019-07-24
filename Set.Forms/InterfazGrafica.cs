using System;
using Set.Core.Model;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;

namespace Set.Forms
{
    internal class InterfazGrafica
    {
        private static double cardWidth = 140;
        private static double cardHeight = 90;

        private static int[] Puntos(int num)
        {
            switch (num)
            {
                case 1:
                    return new int[] { 50 };
                case 2:
                    return new int[] { 33, 33 };
                case 3:
                    return new int[] { 25, 25, 25 };
            }
            throw new ArgumentOutOfRangeException("num debe ser un número entre 1 y 3");
        }

        internal static PanelCarta DibujarCarta(Carta c, double escala = 1.0)
        {
            cardWidth *= escala;
            cardHeight *= escala;

            PanelCarta p = new PanelCarta(c)
            {
                Size = new Size((int)cardWidth, (int)cardHeight),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = System.Drawing.Color.White
            };
            foreach (int num in Enumerable.Range(1, c.Numero))
            {
                PictureBox pbx = new PictureBox()
                {
                    Name = "pbx" + (num),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Size = new Size(40, (int)cardHeight),
                    BackColor = System.Drawing.Color.Transparent,
                    //BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(0),
                    Image = Set.Core.Negocio.Util.ObtenerRecurso(c.Ruta())
                };
                var punto = (cardWidth / (c.Numero + 1)) * num; //punto del centro de la imagen
                pbx.Location = new Point((int)Math.Truncate(punto - (pbx.Size.Width / 2)), 0);
                pbx.Click += p.ChildControlClick;
                p.Controls.Add(pbx);
            }
            return p;
        }

        
    }
}