using System;
using System.Collections.Generic;
using System.Linq;

namespace Set.Core
{
    public static class PlayersCreator
    {
        public const int MaxPlayerNumber = 10;

        public static IEnumerable<Player> CreatePlayers(params (Guid id, string name)[] players)
        {
            if (players == null || !players.Any())
            {
                throw new ArgumentNullException(nameof(players));
            }

            if (players.Any(x => string.IsNullOrWhiteSpace(x.name)))
            {
                throw new ArgumentNullException("Names can not be empty");
            }

            if (players.Count() > MaxPlayerNumber)
            {
                throw new ArgumentOutOfRangeException($"Max. number of players: {MaxPlayerNumber}");
            }

            if (players.Select(x => x.name.Trim().ToLower()).Distinct().Count() != players.Count())
            {
                throw new ArgumentException("All names must be different");
            }

            foreach (var player in players)
            { 
                yield return new Player(player.id, player.name);
            }
        }
    }
}
