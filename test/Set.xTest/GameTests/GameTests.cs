using Set.Core;
using System;
using System.Linq;

namespace Set.xTest
{
    public abstract class GameTests
    {
        protected Game game;

        public GameTests(int cardNumber, GameMode gameMode, int playerNumber)
        {
            //Arrange
            var players = Enumerable.Range(0, playerNumber).Select(i => (Guid.NewGuid(), $"Player {i + 1}"));
            game = new Game(new GameOptions(cardNumber, gameMode, new TimeSpan(0, 0, 50)), players.ToArray());
        }
    }
}
