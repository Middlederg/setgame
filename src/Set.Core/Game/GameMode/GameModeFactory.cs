using System.Collections.Generic;

namespace Set.Core
{
    public static class GameModeFactory
    {
        public static GameMode Tutorial => new Tutorial();
        public static GameMode Easy => new Easy();
        public static GameMode Regular => new Regular();

        public static GameMode FromString(string name)
        {
            return name switch
            {
                nameof(Tutorial) => Tutorial,
                nameof(Easy) => Easy,
                _ => Regular,
            };
        }

        public static IEnumerable<GameMode> GetAll() => new List<GameMode>() { Tutorial, Easy, Regular };
    }
}
