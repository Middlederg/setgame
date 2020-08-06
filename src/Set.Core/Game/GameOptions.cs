using System.Collections.Generic;
using System.Linq;

namespace Set.Core
{
    public sealed class GameOptions
    {
        public const int DefaultMinCardNumber = 27;
        public const int DefaultMaxCardnumber = 81;

        public int CardNumber { get; private set; }
        public GameMode GameMode { get; private set; }
        public IEnumerable<string> PlayerNames { get; private set; }

        public GameOptions(int cardNumber, GameMode gameMode, params string[] playerNames)
        {
            CardNumber = cardNumber;
            GameMode = gameMode;

            if (playerNames == null || !playerNames.Any())
                playerNames = new string[] { "Player 1" };
            PlayerNames = playerNames;
        }
    }
}
