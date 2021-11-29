using Set.Core;
using System;

namespace Set.Web.Services
{
    public class GameOptionsModel
    {
        public int CardNumber { get; set; } = GameOptions.DefaultMaxCardnumber;
        public string GameMode { get; set; } = GameModeFactory.Easy.ToString();
        public int AvaliableTimeInSeconds { get; set; } = 300;

        public GameOptions GetOptions() => new GameOptions(
            cardNumber: CardNumber, 
            gameMode: GameModeFactory.FromString(GameMode),  
            avaliableTime: TimeSpan.FromSeconds(AvaliableTimeInSeconds));

        public int MinCardNumber() => 1;
        public int MaxCardNumber() => GameModeFactory.FromString(GameMode).MaxCardNumber;
        
    }
}
