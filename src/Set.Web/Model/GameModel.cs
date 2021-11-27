using System.Collections.Generic;

namespace Set.Web.Services
{
    public class GameModel
    {
        public List<LogMessage> Log { get; set; } = new();
        public string GameResultMessage { get; set; } = "";

        public bool IsGameOver() => !string.IsNullOrWhiteSpace(GameResultMessage);
    }
}
