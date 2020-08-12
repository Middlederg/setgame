using Set.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Set.BlazorClient.Services
{
    public class GameService
    {
        public Game CurrentGame { get; private set; }
        public Game SetCurrentGame(Game game) => CurrentGame = game;
    }
}
