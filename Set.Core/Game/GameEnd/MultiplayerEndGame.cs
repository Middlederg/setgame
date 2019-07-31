namespace Set.Core
{
    public class MultiplayerEndGame : IEndGame
    {
        private Game game;

        public MultiplayerEndGame(Game game)
        {
            this.game = game;
        }

        public void Process(Time time)
        {
            foreach (var player in game.Players)
            {
                var record = new Record(player.ToString(), player.Score, time);
                Files.GuardarPuntuacion(record);
            }
        }
    }
}
