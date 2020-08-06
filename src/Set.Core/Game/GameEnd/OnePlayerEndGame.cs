using Set.Core.ViewModels;
using System.Linq;

namespace Set.Core
{
    public class OnePlayerEndGame : IEndGame
    {
        private readonly Game game;
        private IPlayerNameViewModel view;
        private IRepository repository;

        public OnePlayerEndGame(Game game, IPlayerNameViewModel view, IRepository repository)
        {
            this.game = game;
            this.view = view;
            this.repository = repository;
        }

        public void Process(Time time)
        {
            var player = game.Players.First();
            view.SetInfo(player.Score, time);
            view.ShowWindow();
            string name = view.InputName;
            var record = new Record(player.ToString(), player.Score, time);
            repository.SaveRecord(record);
        }
    }
}
