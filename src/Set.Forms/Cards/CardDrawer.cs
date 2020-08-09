using System;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;
using Set.Core;
using System.IO;

namespace Set.Forms
{
    public class CardDrawer
    {
        public readonly double cardWidth = 140;
        public readonly double cardHeight = 90;
        private readonly double escala;

        public CardDrawer(double escala = 1.0)
        {
            this.escala = escala;
            cardWidth *= escala;
            cardHeight *= escala;
        }

        internal CardPanel Draw(ICard card)
        {
            CardPanel p = new CardPanel(card)
            {
                Size = new Size((int)cardWidth, (int)cardHeight),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White
            };
            foreach (int num in Enumerable.Range(1, card.Number))
            {
                PictureBox pbx = new PictureBox()
                {
                    Name = "pbx" + (num),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Size = new Size(40, (int)cardHeight),
                    BackColor = System.Drawing.Color.Transparent,
                    //BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(0),
                    Image = ObtenerRecurso(card.Path)
                };
                var punto = (cardWidth / (card.Number + 1)) * num; //punto del centro de la imagen
                pbx.Location = new Point((int)Math.Truncate(punto - (pbx.Size.Width / 2)), 0);
                pbx.Click += p.ChildControlClick;
                p.Controls.Add(pbx);
            }
            return p;
        }

        private Image ObtenerRecurso(string nombre)
        {
            var file = Properties.Resources.ResourceManager.GetObject(nombre) as byte[];
            using (var ms = new MemoryStream(file))
            {
                return new Bitmap(ms);
            }
        }
    }
}