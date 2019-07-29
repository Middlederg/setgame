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
        private WinFormLogger log;
        private Game game;
        private MainPanelDrawer mainPanelDrawer;

        private Time time;

        public FrmPrincipal(GameOptions options)
        {
            InitializeComponent();

            log = new WinFormLogger(LvwLog);
            game = new Game(options, log);
            time = new Time();

            mainPanelDrawer = new MainPanelDrawer(pCartas, SetCheckButton);
            DrawMainPanel();

            BtnRendirse.Enabled = options.GameMode.IsTutorial;
            SetCheckButton();

            if (game.Players.Count > 1)
            {
                InfoSets.Visible = false;
                InfoMistakes.Visible = false;
                BtnClasificacion.Visible = true;
            }
        }

        private void SetCheckButton() => BtnComprobarSet.Enabled = mainPanelDrawer.IsTrioSelected;

        public void DrawMainPanel()
        {
            mainPanelDrawer.Draw(game.AvaliableCardList);

            Info.Text = log.LogEntries.LastOrDefault()?.Message ?? string.Empty;
            InfoCards.Text = $"Cartas restantes: {game.Deck.Count}";
            InfoSets.Text = $"Sets encontrados: {game.TotalSets}";
            InfoMistakes.Text = $"Fallos cometidos: {game.TotalMistakes}";            
        }

        private void TimerTiempo_Tick(object sender, EventArgs e)
        {
            time.AddScecond();
            LblTiempo.Text = time.ToString();
        }

        private void OnCheckButtonClicked(object sender, EventArgs e)
        {
            var cardTrio = mainPanelDrawer.SelectedTrio;

            var player = DemandPlayer();
            if (game.Check(cardTrio, player))
                FinalJuego();
            else
                DrawMainPanel();
            
            BtnComprobarSet.Enabled = mainPanelDrawer.IsTrioSelected;
        }

        private void OnHowManyButtonClicked(object sender, EventArgs e)
        {
            Info.Text = game.SetCountHelp();
        }

        private void OnHelpClicked(object sender, EventArgs e)
        {
            mainPanelDrawer.ShowHelp();
        }

        private Player DemandPlayer()
        {
            if (game.IsOnePlayerMode)
                return game.Players.First();

            using (var playerView = new FrmJugadores(game.Players) { Location = new Point(this.Location.X + Width, this.Location.Y) })
            {
                playerView.ShowDialog();
                return playerView.SelectedPlayer;
            };
        }

        private void BtnMax_Click(object sender, EventArgs e) => WindowState = WindowState.Equals(FormWindowState.Maximized) ? FormWindowState.Normal : FormWindowState.Maximized;
        private void BtnClose_Click(object sender, EventArgs e) => Close();
        private void BtnMin_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;


        public void FinalJuego()
        {
            timerTiempo.Stop();
            Info.Text = "Fin de partida";
           
            foreach (var btn in TlpPrincipal.Controls.OfType<Button>())
                btn.Enabled = false;
        }
    }
}
