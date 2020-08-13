using System;
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
        public TimeSpan AvaliableTime { get; private set; }

        public GameOptions(int cardNumber, GameMode gameMode, TimeSpan avaliableTime)
        {
            CardNumber = cardNumber;
            GameMode = gameMode;
            AvaliableTime = avaliableTime;
        }
    }
}
