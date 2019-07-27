using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Set.Core;

namespace Set.Forms.Views
{
    public partial class FrmPrincipal : Form
    {
        Game game;

        /// <summary>
        /// indx del siguiente set a mostrar
        /// </summary>
        int numSetAyuda;

        public int segundos, minutos;

        public FrmPrincipal(GameOptions options)
        {
            InitializeComponent();

            var logger = new Logger(LvwLog);
            game = new Game(options, logger);
            DrawMainPanel();

            BtnRendirse.Enabled = options.GameMode.IsTutorial;
            BtnComprobarSet.Enabled = pCartas.Controls.OfType<CardPanel>().Count(x => x.Seleccionada) == 3;

            if (game.Players.Count > 1)
            {
                lbnumsets.Visible = false;
                lbPuntos.Visible = false;
                BtnClasificacion.Visible = true;
            }
        }

        public void DrawMainPanel()
        {
            numSetAyuda = 0;
         
  
            lbPuntos.Text = "Puntos: " + new Score(game.PlayerTurn(0).Score(.sco.NumSets, game.ElTurno(0).Fallos, (int)(DateTime.Now.Subtract(game.ComienzoJuego).TotalSeconds)).Puntuacion();
            lbInfo.Text = game.Log.LastOrDefault() ?? string.Empty;
            lbnumsets.Text = "Sets: " + game.ElTurno(0).NumSets;
            lbnumsets.Text += (game.ElTurno(0).Fallos > 0) ? "\t\tFallos: " + game.ElTurno(0).Fallos : "";
            lbNumCartas.Text = "Cartas: " + game.Mazo.Count;
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
            var c = (sender as CardPanel);
            c.Seleccionar(!c.Seleccionada);
            if (pCartas.Controls.OfType<CardPanel>().Count(x => x.Seleccionada) == 3)
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
                var selectedCards = pCartas.Controls.OfType<CardPanel>().Where(x => x.Seleccionada).Select(x => x.Card).ToList();
                int jugador = 0;
                if (game.Jugadores.Count > 1)
                {
                    FrmJugadores f = new FrmJugadores(game.Jugadores)
                    {
                        Location = new Point(Location.X + Width, Location.Y)
                    };
                    f.ShowDialog();
                    jugador = f.BotonSeleccionado;
                }
                if (game.ComprobarSet(selectedCards, jugador))
                    FinalJuego();
                else
                    DrawMainPanel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            BtnComprobarSet.Enabled = pCartas.Controls.OfType<CardPanel>().Count(x => x.Seleccionada) == 3;
        }

        private void BtnNoSets_Click(object sender, EventArgs e)
        {
            if (game.NoHayNingunSet())
                FinalJuego();
            else
                DrawMainPanel();
            BtnComprobarSet.Enabled = pCartas.Controls.OfType<CardPanel>().Count(x => x.Seleccionada) == 3;
        }

        private void BtnRendirse_Click(object sender, EventArgs e)
        {
            var sets = game.FindSets().ToList();

            if (sets.Count() == 0)
                lbInfo.Text = "No hay ningún set :(";
            else
            {
                foreach (var c in pCartas.Controls.OfType<CardPanel>())
                    c.Seleccionar(sets.ElementAt(numSetAyuda).Contains(c.Card));
                numSetAyuda = numSetAyuda < sets.Count() - 1 ? numSetAyuda + 1 : 0;
            }
            BtnComprobarSet.Enabled = pCartas.Controls.OfType<CardPanel>().Count(x => x.Seleccionada) == 3;
        }

        //private void BtnLog_Click(object sender, EventArgs e) => new FrmLog(game.l).ShowDialog();

        private void BtnMax_Click(object sender, EventArgs e) => WindowState = WindowState.Equals(FormWindowState.Maximized) ? FormWindowState.Normal : FormWindowState.Maximized;
        private void BtnClose_Click(object sender, EventArgs e) => Close();
        private void BtnMin_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void BtnClasificacion_Click(object sender, EventArgs e)
        {
            using (var f = new FrmClasificacion())
            {
                f.ShowDialog();
            }
        }

        public void FinalJuego()
        {
            timerTiempo.Stop();
            lbInfo.Text = "Fin de partida";
            if (game.Jugadores.Count > 1)
            {
                //Agregar record de caa jugador
                foreach (var jug in game.Jugadores)
                {
                    var record = new Record(jug.NumSets, jug.Fallos, segundos) { NombreJugador = jug.Nombre };
                    Files.GuardarPuntuacion(record);
                }

                //Mostrar clasificación
                using (var f = new FrmClasificacion(game, segundos)) { f.ShowDialog(); }
            }
            else
            {
                new FrmInputName(game.ElTurno(0).NumSets, game.ElTurno(0).Fallos, (int)(DateTime.Now.Subtract(game.ComienzoJuego).TotalSeconds)).ShowDialog();
            }
            foreach (var btn in TlpPrincipal.Controls.OfType<Button>())
                btn.Enabled = false;
        }
    }
}
