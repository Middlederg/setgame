using System.Collections.Generic;

namespace Set.Core
{

    public class Player
    {
        private readonly string name;
        public Score Score { get; private set; }
        public int SetCount => Score.SetCount;
        public void AddSet() => Score.AddSet();
        public int MistakeCount => Score.SetCount;
        public void AddMistake() => Score.AddMistake();
        public void AddHelp() => Score.AddHelp();
        public void AddSurrender() => Score.AddSurrender();

        public List<CardTrio> DiscoveredSets { get; }
        public void Discover(CardTrio trio) => DiscoveredSets.Add(new CardTrio(trio.Cards));

        public Player(string name)
        {
            this.name = name;
            Score = new Score();
            DiscoveredSets = new List<CardTrio>();
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
