using System;
using System.Collections.Generic;
using System.Linq;

namespace Set.Core
{
    public class Player
    {
        public const int MaxPlayerNumber = 10;
        public static IEnumerable<Player> CreatePlayers(IEnumerable<string> names)
        {
            if (names == null || !names.Any())
                throw new ArgumentNullException(nameof(names));

            if (names.Count() > MaxPlayerNumber)
                throw new ArgumentOutOfRangeException($"Maximo número de jugadores: {MaxPlayerNumber}");

            foreach (var name in names)
                yield return new Player(name);
        }

        private string name;
        public Score Score { get; private set; }
        public int SetCount => Score.SetCount;
        public void AddSet() => Score.AddSet();
        public int MistakeCount => Score.SetCount;
        public void AddMistake() => Score.AddMistake();
        public Record GetRecord(Time time) => new Record(name, Score, time);

        public Player(string name)
        {
            this.name = name;
            Reset();
        }

        public void Reset()
        {
            Score = new Score();
        }

        public override string ToString() => name;

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            var player = obj as Card;
            return (player.ToString().Equals(name));
        }

        public override int GetHashCode() => name.GetHashCode();
    }
}
