using Set.Core.ViewModels;

namespace Set.Core
{
    public class MultiplayerDemand : IDemandPlayer
    {
        private readonly Game game;
        private IPlayersViewModel view;

        public MultiplayerDemand(Game game, IPlayersViewModel view)
        {
            this.game = game;
            this.view = view;
        }

        public Player GetPlayer()
        {
            view.Players = game.Players;
            view.ShowWindow();
            return view.SelectedPlayer;
        }
    }
}
