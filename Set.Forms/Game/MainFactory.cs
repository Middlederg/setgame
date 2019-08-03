using Set.Core;
using Set.Forms.Views;
using System.Drawing;

namespace Set.Forms
{
    public static class MainFactory
    {
        public static IDemandPlayer DemandPlayer(Game game, Point parentLocation, int parentWidth)
        {
            if (game.IsOnePlayerMode)
                return new OnePlayerDemand(game);

            return new MultiplayerDemand(game, new PlayersView() { Location = new Point(parentLocation.X + parentWidth, parentLocation.Y) });
        }

        public static IEndGame EndGame(Game game)
        {
            if (game.IsOnePlayerMode)
                return new OnePlayerEndGame(game, new InputNameView(), new FileRepository());

            return new MultiplayerEndGame(game, new FileRepository());
        }
    }
}