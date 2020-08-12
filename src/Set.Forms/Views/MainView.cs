using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Set.Core;

namespace Set.Forms.Views
{
    public partial class MainView : Form
    {
        private WinFormLogger log;
        private Game game;
        private MainPanelDrawer mainPanelDrawer;

        private Time time;

        public MainView(GameOptions options)
        {
            InitializeComponent();

            log = new WinFormLogger(LvwLog);
            game = new Game(options, log);
            time = new Time();

            mainPanelDrawer = new MainPanelDrawer(pCartas, SetCheckButton);
            BtnHelp.Enabled = options.GameMode.IsTutorial;

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

            PositionsList.Positions = game.PlayerPositions();
        }

        private void TimerTiempo_Tick(object sender, EventArgs e)
        {
            time.RemoveSecond();
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
                if (game.LevelCompleted())
                    EndOfGame();
            }
            DrawInfo();
            SetCheckButton();
        }

        private async void OnHowManyButtonClickedAsync(object sender, EventArgs e)
        {
            var oldIcon = BeginLoadingForButton(sender as CustomIconButton);
            Info.Text = await game.SetCountHelp();
            EndLoadingForButton(sender as CustomIconButton, oldIcon);
        }

        private async void OnHelpClickedAsync(object sender, EventArgs e)
        {
            var oldIcon = BeginLoadingForButton(sender as CustomIconButton);
            await mainPanelDrawer.ShowHelp();
            EndLoadingForButton(sender as CustomIconButton, oldIcon);
        }

        private IconChar BeginLoadingForButton(CustomIconButton btn)
        {
            var oldIcon = btn.IconChar;
            btn.IconChar = IconChar.Spinner;
            BtnCheck.Enabled = BtnHowMany.Enabled = BtnHelp.Enabled = false;
            return oldIcon;
        }

        private void EndLoadingForButton(CustomIconButton btn, IconChar icon)
        {
            BtnHowMany.Enabled = BtnHelp.Enabled = true;
            SetCheckButton();
            btn.IconChar = icon;
        }
    }
}
