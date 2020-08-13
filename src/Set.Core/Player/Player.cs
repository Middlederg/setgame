using System;
using System.Collections.Generic;
using System.Linq;

namespace Set.Core
{
    public class Player
    {
        private readonly string name;
        public Score Score => new Score(discoveredSets.Count, mistakeCount, helpCount, surrenderCount);

        private int mistakeCount;
        public void AddMistake() => mistakeCount++;

        private int helpCount;
        public void AddHelpRequest() => helpCount++;

        private int surrenderCount;
        public void AddSurrenderRequest() => surrenderCount++;

        private readonly List<DiscoveredSet> discoveredSets;
        public IEnumerable<DiscoveredSet> DiscoveredSets => discoveredSets.AsReadOnly();

        public Guid Id { get; }

        public void Discover(CardTrio trio, Time time)
        {
            var set = new CardTrio(trio.Cards.Select(x => x.Copy()));
            discoveredSets.Add(new DiscoveredSet(set, set.ToString(), time.TimeSpan));
        }

        public Player(Guid id, string name)
        {
            Id = id;
            this.name = name;
            mistakeCount = 0;
            helpCount = 0;
            surrenderCount = 0;
            discoveredSets = new List<DiscoveredSet>();
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
