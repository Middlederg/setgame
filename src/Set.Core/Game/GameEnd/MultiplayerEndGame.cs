namespace Set.Core
{
    public class MultiplayerEndGame : IEndGame
    {
        private Game game;
        public IRepository repository;

        public MultiplayerEndGame(Game game, IRepository repository)
        {
            this.game = game;
            this.repository = repository;
        }

        public void Process(Time time)
        {
            foreach (var player in game.Players)
            {
                var record = new Record(player.ToString(), player.Score, time);
                repository.SaveRecord(record);
            }
        }
    }
}
