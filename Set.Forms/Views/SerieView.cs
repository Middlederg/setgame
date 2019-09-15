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
    public partial class SerieView : Form
    {
        private WinFormLogger log;
        private Serie serie;
        private Game game;
        private MainPanelDrawer mainPanelDrawer;
        private Time time;

        public SerieView(Serie serie)
        {
            InitializeComponent();

            log = new WinFormLogger(LvwLog);          
        }

        private void PrepareGame(Step step)
        {
            game = new Game(new GameOptions(step.CardNumber, GameModeFactory.Regular), log);
            time = new Time();

            mainPanelDrawer = new MainPanelDrawer(pCartas, SetCheckButton);

            if (game.Players.Count > 1)
            {
                InfoSets.Visible = false;
                InfoMistakes.Visible = false;
            }

            game.StartGame();
            DrawMainPanel();
            DrawInfo();
            SetCheckButton();
        }

        private void SetCheckButton() => BtnCheck.Enabled = mainPanelDrawer.IsTrioSelected;

        public void DrawMainPanel()
        {
            mainPanelDrawer.Draw(game.AvaliableCardList);
        }

        private void DrawInfo()
        {
            Info.Text = log.LogEntries.LastOrDefault()?.Message ?? string.Empty;
            InfoCards.Text = $"Cartas restantes: {game.Deck.Count}";
            InfoSets.Text = $"Sets encontrados: {game.TotalSets}";
            InfoMistakes.Text = $"Fallos cometidos: {game.TotalMistakes}";

            //PositionsList.Positions = game.PlayerPositions(time);
        }

        private void TimerTiempo_Tick(object sender, EventArgs e)
        {
            time.AddScecond();
            LblTiempo.Text = time.ToString();
        }

        public void EndOfGame()
        {
            timerTiempo.Stop();
            Info.Text = "Fin de partida";

            MainFactory.EndGame(game).Process(time);
           
            foreach (var btn in TlpPrincipal.Controls.OfType<Button>())
                btn.Enabled = false;
        }

        private void OnCloseClicked(object sender, EventArgs e) => Close();
        private void OnMinimizeClicked(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void OnCheckButtonClicked(object sender, EventArgs e)
        {
            var cardTrio = mainPanelDrawer.SelectedTrio;

            var player = MainFactory.DemandPlayer(game, Location, Width).GetPlayer();
            if (game.Check(cardTrio, player))
            {
                game.RefreshCards(cardTrio);
                DrawMainPanel();
                if (game.IsGameEnd())
                    EndOfGame();
            }
            DrawInfo();
            SetCheckButton();
        }

        private async void OnHowManyButtonClickedAsync(object sender, EventArgs e)
        {
            Info.Text = await game.SetCountHelp();
        }

        private void OnHelpClicked(object sender, EventArgs e)
        {
            mainPanelDrawer.ShowHelp();
            SetCheckButton();
        }

        private void OnHowManyButtonClicked(object sender, EventArgs e)
        {

        }
    }
}
