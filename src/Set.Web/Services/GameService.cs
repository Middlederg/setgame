using Set.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Set.Web.Services
{
    public class GameService
    {
        public GameOptions GameOptions { get; private set; }
        public void SetNextGameOptions(GameOptions gameOptions) => GameOptions = gameOptions;

        public Guid CurrentPlayer { get; private set; }
        public Guid CreatePlayer()
        {
            CurrentPlayer = Guid.NewGuid();
            return CurrentPlayer;
        }
    }
}
