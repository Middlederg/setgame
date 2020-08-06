using System.Linq;

namespace Set.Core
{
    public class OnePlayerDemand : IDemandPlayer
    {
        private readonly Game game;

        public OnePlayerDemand(Game game)
        {
            this.game = game;
        }

        public Player GetPlayer() => game.Players.First();
    }
}
