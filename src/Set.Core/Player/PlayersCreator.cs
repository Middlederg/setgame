using System;
using System.Collections.Generic;
using System.Linq;

namespace Set.Core
{
    public static class PlayersCreator
    {
        public const int MaxPlayerNumber = 10;

        public static IEnumerable<Player> CreatePlayers(IEnumerable<string> names)
        {
            if (names == null || !names.Any())
            {
                throw new ArgumentNullException(nameof(names));
            }

            if (names.Any(x => string.IsNullOrWhiteSpace(x)))
            {
                throw new ArgumentNullException("Names can not be empty");
            }

            if (names.Count() > MaxPlayerNumber)
            {
                throw new ArgumentOutOfRangeException($"Max. number of players: {MaxPlayerNumber}");
            }

            if (names.Select(x => x.Trim().ToLower()).Distinct().Count() != names.Count())
            {
                throw new ArgumentException("All names must be different");
            }

            foreach (var name in names)
            { 
                yield return new Player(name);
            }
        }
    }
}
