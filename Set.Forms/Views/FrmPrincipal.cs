using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Set.Core.Enums;
using Set.Core.Model;
using Set.Core.Negocio;

namespace Set.Forms.Views
{
    public partial class FrmPrincipal : Form
    {
        Juego j;

        /// <summary>
        /// indx del siguiente set a mostrar
        /// </summary>
        int numSetAyuda;

        public int segundos, minutos;

        public FrmPrincipal(Dificultad dificultad, int numCartas, IEnumerable<string> nombres)
        {
            InitializeComponent();

            j = new Juego(numCartas, dificultad, nombres);
            Redibujar();

            BtnRendirse.Enabled = dificultad.Equals(Dificultad.Tutorial);
            BtnComprobarSet.Enabled = pCartas.Controls.OfType<PanelCarta>().Count(x => x.Seleccionada) == 3;

            if (j.Jugadores.Count > 1)
            {
                lbnumsets.Visible = false;
                lbPuntos.Visible = false;
            }
        }

        public void Redibujar()
        {
            numSetAyuda = 0;
            pCartas.Controls.Clear();

            int x = 0; int y = 0;
            int padding = 24;
            foreach (var c in j.CartasVisibles())
            {
                var pCard = InterfazGrafica.DibujarCarta(c);
                pCard.Location = new Point(padding + (padding + pCard.Width) * x, padding + (padding + pCard.Height) * y);
                pCard.Click += ClickCard;
                pCartas.Controls.Add(pCard);
                x++;
                if (x > 3) { x = 0; y++; }
            }
  
            lbPuntos.Text = "Puntos: " + new Record(j.ElTurno(0).NumSets, j.ElTurno(0).Fallos, (int)(DateTime.Now.Subtract(j.ComienzoJuego).TotalSeconds)).Puntuacion();
            lbInfo.Text = j.Log.LastOrDefault() ?? string.Empty;
            lbnumsets.Text = "Sets: " + j.ElTurno(0).NumSets;
            lbnumsets.Text += (j.ElTurno(0).Fallos > 0) ? "\t\tFallos: " + j.ElTurno(0).Fallos : "";
            lbNumCartas.Text = "Cartas: " + j.Mazo.Count;
        }

        private void TimerTiempo_Tick(object sender, EventArgs e)
        {
            if (segundos >= 59)
            {
                minutos++;
                segundos = 0;
            }
            else
                segundos++;

            string min = (minutos < 10) ? "0" + minutos.ToString() : minutos.ToString();
            string sec = (segundos < 10) ? "0" + segundos.ToString() : segundos.ToString();

            LblTiempo.Text = min + ":" + sec;
        }

        public void ClickCard(object sender, EventArgs e)
        {
            var c = (sender as PanelCarta);
            c.Seleccionar(!c.Seleccionada);
            if (pCartas.Controls.OfType<PanelCarta>().Count(x => x.Seleccionada) == 3)
            {
                BtnComprobarSet.Enabled = true;
                
            }
            else
                BtnComprobarSet.Enabled = false;
        }

        private void BtnComprobarSet_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedCards = pCartas.Controls.OfType<PanelCarta>().Where(x => x.Seleccionada).Select(x => x.Card).ToList();
                int jugador = 0;
                if (j.Jugadores.Count > 1)
                {
                    FrmJugadores f = new FrmJugadores(j.Jugadores);
                    f.Location = new Point(Location.X + Width, Location.Y);
                    f.ShowDialog();
                    jugador = f.BotonSeleccionado;
                }
                if (j.ComprobarSet(selectedCards, jugador))
                    FinalJuego();
                else
                    Redibujar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            BtnComprobarSet.Enabled = pCartas.Controls.OfType<PanelCarta>().Count(x => x.Seleccionada) == 3;
        }

        private void BtnNoSets_Click(object sender, EventArgs e)
        {
            if (j.NoHayNingunSet())
                FinalJuego();
            else
                Redibujar();
            BtnComprobarSet.Enabled = pCartas.Controls.OfType<PanelCarta>().Count(x => x.Seleccionada) == 3;
        }

        private void BtnRendirse_Click(object sender, EventArgs e)
        {
            var sets = j.BuscarSets().ToList();

            if (sets.Count() == 0)
                lbInfo.Text = "No hay ningún set :(";
            else
            {
                foreach (var c in pCartas.Controls.OfType<PanelCarta>())
                    c.Seleccionar(sets.ElementAt(numSetAyuda).Contains(c.Card));
                numSetAyuda = numSetAyuda < sets.Count() - 1 ? numSetAyuda + 1 : 0;
            }
            BtnComprobarSet.Enabled = pCartas.Controls.OfType<PanelCarta>().Count(x => x.Seleccionada) == 3;
        }

        private void BtnLog_Click(object sender, EventArgs e) => new FrmLog(j.Log).ShowDialog();

        private void BtnMax_Click(object sender, EventArgs e) => WindowState = WindowState.Equals(FormWindowState.Maximized) ? FormWindowState.Normal : FormWindowState.Maximized;
        private void BtnClose_Click(object sender, EventArgs e) => Close();
        private void BtnMin_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        public void FinalJuego()
        {
            timerTiempo.Stop();
            lbInfo.Text = "Fin de partida";
            if (j.Jugadores.Count > 1)
            {

            }
            else
            {
                new FrmInputName(j.ElTurno(0).NumSets, j.ElTurno(0).Fallos, (int)(DateTime.Now.Subtract(j.ComienzoJuego).TotalSeconds)).ShowDialog();
                foreach (var btn in TlpPrincipal.Controls.OfType<Button>())
                    btn.Enabled = false;
            }
        }
    }
}
