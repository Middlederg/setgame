using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Set.Core.Model;

namespace Set.Forms
{
    public class PanelCarta : Panel
    {
        public static System.Drawing.Color ColorSeleccion = System.Drawing.Color.LightGray;

        public Carta Card { get; set; }

        private bool seleccionada;
        public bool Seleccionada { get { return seleccionada; } }

        public PanelCarta(Carta c)
        {
            Card = c;
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
