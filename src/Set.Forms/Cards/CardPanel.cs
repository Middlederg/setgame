using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Set.Core;

namespace Set.Forms
{
    public class CardPanel : Panel
    {
        public static System.Drawing.Color ColorSeleccion = System.Drawing.Color.LightGray;

        public ICard Card { get; set; }

        private bool seleccionada;
        public bool Seleccionada { get { return seleccionada; } }

        public CardPanel(ICard card)
        {
            Card = card;
        }

        public void Seleccionar(bool seleccionar)
        {
            seleccionada = seleccionar;
            BackColor = seleccionada ? ColorSeleccion : System.Drawing.Color.White;
        }

        public void ChildControlClick(object sender, EventArgs e)
        {
            // just raise user control's click event using inherited method OnClick()
            OnClick(e);
        }
    }
}
