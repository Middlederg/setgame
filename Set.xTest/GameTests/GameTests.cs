using Set.Core;
using System.Linq;

namespace Set.xTest
{
    public abstract class GameTests
    {
        protected readonly ILogger log;
        protected Game game;

        public GameTests(int cardNumber, GameMode gameMode, int playerNumber)
        {
            //Arrange
            log = new TestLogger();
            var playerNames = Enumerable.Range(0, playerNumber).Select(i => $"Player {i + 1}");
            game = new Game(new GameOptions(cardNumber, gameMode, playerNames.ToArray()), log);
        }
    }
}
